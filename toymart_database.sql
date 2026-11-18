/* =====================================================================
   ToyMart B2C E-Commerce System - Complete Database Script (SQL Server)
   Includes every change made during development.

   HOW TO USE
   1. Create an empty database named toymart
      (SQL Server Object Explorer > (localdb)\MSSQLLocalDB > Databases > Add New Database)
   2. Open a New Query on toymart, paste this whole file, and Execute.

   Run PART 1 to 3 on a fresh database. If you already built your tables,
   do NOT rerun them: only run the ALTER statements listed in PART 4
   that you have not run yet.
   ===================================================================== */

USE toymart;
GO

/* ---------------------------------------------------------------------
   PART 1: TABLES (final version, with all later changes included)
   --------------------------------------------------------------------- */

CREATE TABLE users (
  user_id        INT IDENTITY(1,1) PRIMARY KEY,
  username       NVARCHAR(50)  NOT NULL UNIQUE,
  password_hash  NVARCHAR(100) NOT NULL,
  full_name      NVARCHAR(100),
  email          NVARCHAR(100),
  contact_no     NVARCHAR(20),
  address        NVARCHAR(255),
  role           NVARCHAR(20)  NOT NULL DEFAULT 'customer'
                 CHECK (role IN ('customer','admin','service')),
  -- saved delivery details (reused at checkout)
  recipient_name NVARCHAR(100) NULL,
  province       NVARCHAR(60)  NULL,
  city           NVARCHAR(60)  NULL,
  barangay       NVARCHAR(60)  NULL,
  street         NVARCHAR(150) NULL,
  postal_code    NVARCHAR(10)  NULL,
  payment_pref   NVARCHAR(30)  NULL
);

CREATE TABLE categories (
  category_id INT IDENTITY(1,1) PRIMARY KEY,
  name        NVARCHAR(60) NOT NULL
);

CREATE TABLE products (
  product_id  INT IDENTITY(1,1) PRIMARY KEY,
  name        NVARCHAR(100) NOT NULL,
  description NVARCHAR(MAX),
  price       DECIMAL(10,2) NOT NULL,
  stock       INT NOT NULL,
  category_id INT FOREIGN KEY REFERENCES categories(category_id),
  image_path  NVARCHAR(255)
);

CREATE TABLE cart (
  cart_id    INT IDENTITY(1,1) PRIMARY KEY,
  user_id    INT FOREIGN KEY REFERENCES users(user_id),
  product_id INT FOREIGN KEY REFERENCES products(product_id),
  quantity   INT NOT NULL
);

CREATE TABLE orders (
  order_id       INT IDENTITY(1,1) PRIMARY KEY,
  user_id        INT FOREIGN KEY REFERENCES users(user_id),
  order_date     DATETIME NOT NULL DEFAULT GETDATE(),
  total          DECIMAL(10,2),
  payment_method NVARCHAR(30),
  status         NVARCHAR(20) NOT NULL DEFAULT 'Pending'
                 CHECK (status IN ('Pending','Processing','Shipped','Delivered','Cancelled')),
  -- delivery details (separate fields)
  recipient_name NVARCHAR(100) NULL,
  contact_no     NVARCHAR(20)  NULL,
  province       NVARCHAR(60)  NULL,
  city           NVARCHAR(60)  NULL,
  barangay       NVARCHAR(60)  NULL,
  street         NVARCHAR(150) NULL,
  postal_code    NVARCHAR(10)  NULL
);

CREATE TABLE order_details (
  detail_id  INT IDENTITY(1,1) PRIMARY KEY,
  order_id   INT FOREIGN KEY REFERENCES orders(order_id),
  product_id INT FOREIGN KEY REFERENCES products(product_id),
  quantity   INT,
  unit_price DECIMAL(10,2)
);

CREATE TABLE rewards (
  reward_id INT IDENTITY(1,1) PRIMARY KEY,
  user_id   INT FOREIGN KEY REFERENCES users(user_id),
  order_id  INT FOREIGN KEY REFERENCES orders(order_id),
  prize     NVARCHAR(100),
  date_won  DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE inquiries (
  inquiry_id INT IDENTITY(1,1) PRIMARY KEY,
  user_id    INT FOREIGN KEY REFERENCES users(user_id),
  order_id   INT NULL,
  subject    NVARCHAR(100),
  message    NVARCHAR(MAX),
  response   NVARCHAR(MAX),
  status     NVARCHAR(20) NOT NULL DEFAULT 'Open'
             CHECK (status IN ('Open','Resolved')),
  created_at DATETIME NOT NULL DEFAULT GETDATE(),
  -- who replied and when (used by the Reports form)
  handled_by INT NULL FOREIGN KEY REFERENCES users(user_id),
  handled_at DATETIME NULL
);
GO

/* ---------------------------------------------------------------------
   PART 2: SAMPLE DATA
   --------------------------------------------------------------------- */

INSERT INTO categories (name) VALUES
('Action Figures'), ('Puzzles'), ('Board Games'), ('Plush Toys'), ('Building Blocks');

INSERT INTO products (name, description, price, stock, category_id) VALUES
('Hero Strike Figure',    'Poseable 6-inch action figure',    499.00, 25, 1),
('Robot Warrior',         'Light-up robot with moving arms',  699.00, 15, 1),
('Dino Rangers Set',      'Set of 3 dinosaur figures',        599.00, 20, 1),
('1000-Piece Puzzle',     'Scenic landscape jigsaw puzzle',   350.00, 30, 2),
('Kids 100-Piece Puzzle', 'Colorful animal puzzle',           199.00, 40, 2),
('Family Trivia Game',    'Fun trivia for 2 to 6 players',    450.00, 18, 3),
('Classic Strategy Game', 'Build and trade, ages 8+',         799.00, 12, 3),
('Teddy Bear Large',      'Soft 30 cm teddy bear',            399.00, 35, 4),
('Plush Bunny',           'Cuddly pastel bunny',              299.00, 28, 4),
('Mega Block Set 200pc',  'Colorful building blocks',         549.00, 22, 5),
('Castle Builder Kit',    '350-piece castle set',             899.00, 10, 5),
('Mini Block Bucket',     '100 pieces in a bucket',           249.00, 45, 5);
GO

/* ---------------------------------------------------------------------
   PART 3: CREATE STAFF ACCOUNTS
   Register the accounts in the app first (they start as 'customer'),
   then change their role here. Replace the usernames with yours.
   --------------------------------------------------------------------- */

-- UPDATE users SET role = 'admin'   WHERE username = 'admin1';
-- UPDATE users SET role = 'service' WHERE username = 'service1';
GO

/* ---------------------------------------------------------------------
   PART 4: ALTER STATEMENTS (ONLY if you built the database step by step
   and have NOT run them yet; a fresh database from Part 1 already has them)
   --------------------------------------------------------------------- */

/* 4a. Separate delivery fields on orders (replaces single address column)
ALTER TABLE orders DROP COLUMN delivery_address;
ALTER TABLE orders ADD
  recipient_name NVARCHAR(100) NULL,
  contact_no     NVARCHAR(20)  NULL,
  province       NVARCHAR(60)  NULL,
  city           NVARCHAR(60)  NULL,
  barangay       NVARCHAR(60)  NULL,
  street         NVARCHAR(150) NULL,
  postal_code    NVARCHAR(10)  NULL;
*/

/* 4b. Saved delivery details on users
ALTER TABLE users ADD
  recipient_name NVARCHAR(100) NULL,
  province       NVARCHAR(60)  NULL,
  city           NVARCHAR(60)  NULL,
  barangay       NVARCHAR(60)  NULL,
  street         NVARCHAR(150) NULL,
  postal_code    NVARCHAR(10)  NULL,
  payment_pref   NVARCHAR(30)  NULL;
*/

/* 4c. Track who handled each inquiry (for the Reports form)
ALTER TABLE inquiries ADD
  handled_by INT NULL FOREIGN KEY REFERENCES users(user_id),
  handled_at DATETIME NULL;
*/

/* ---------------------------------------------------------------------
   PART 5: HANDY TEST QUERIES
   --------------------------------------------------------------------- */

-- SELECT COUNT(*) FROM products;                                   -- should be 12
-- SELECT user_id, username, role FROM users;
-- SELECT order_id, user_id, total, status FROM orders;
-- SELECT inquiry_id, subject, status, handled_by FROM inquiries;
-- UPDATE products SET stock = 20 WHERE product_id = 1;             -- reset stock while testing
