using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ToyMartB2C
{
    internal class Theme
    {
        // Change these colors and the whole app changes
        public static readonly Color Primary = ColorTranslator.FromHtml("#F48FB1");  // main pink (buttons, headers)
        public static readonly Color Secondary = ColorTranslator.FromHtml("#B8A9C9");  // soft lavender (Back, Logout)
        public static readonly Color Danger = ColorTranslator.FromHtml("#E57373");  // soft coral red (Delete)
        public static readonly Color Background = ColorTranslator.FromHtml("#FFF5F8");  // blush white
        public static readonly Color TextColor = ColorTranslator.FromHtml("#873757");  // dusty plum (softer than black)

        // ---------- Rounded window corners (Windows 11) ----------
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int value, int size);

        private static void RoundWindow(Form f)
        {
            void Do()
            {
                int round = 2;   // DWMWCP_ROUND
                DwmSetWindowAttribute(f.Handle, 33, ref round, sizeof(int));
            }
            if (f.IsHandleCreated) Do(); else f.HandleCreated += (s, e) => Do();
        }

        // ---------- Apply everything to one form ----------
        public static void Apply(Form f)
        {
            f.BackColor = Background;
            f.Font = new Font("Segoe UI", 10F);
            f.ForeColor = TextColor;
            RoundWindow(f);
            StyleChildren(f);
        }

        private static void StyleChildren(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button b)
                {
                    string n = b.Name.ToLower();
                    if (n.Contains("delete") || n.Contains("remove")) StyleButton(b, Danger);
                    else if (n.Contains("back") || n.Contains("cancel") || n.Contains("logout")) StyleButton(b, Secondary);
                    else StyleButton(b, Primary);
                }
                else if (c is DataGridView g) StyleGrid(g);

                if (c.HasChildren) StyleChildren(c);   // go inside panels and tabs too
            }
        }

        // ---------- Soft rounded buttons ----------
        public static void StyleButton(Button b, Color? color = null, int radius = 10)
        {
            Color baseColor = color ?? Primary;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = baseColor;
            b.FlatAppearance.MouseDownBackColor = baseColor;
            b.BackColor = baseColor;
            b.ForeColor = Color.White;
            b.Font = new Font("Segoe UI Semibold", 10F);
            b.Cursor = Cursors.Hand;

            bool hover = false, down = false;
            b.MouseEnter += (s, e) => { hover = true; b.Invalidate(); };
            b.MouseLeave += (s, e) => { hover = false; down = false; b.Invalidate(); };
            b.MouseDown += (s, e) => { down = true; b.Invalidate(); };
            b.MouseUp += (s, e) => { down = false; b.Invalidate(); };

            b.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(BehindColor(b));
                Color fill = !b.Enabled ? Color.Silver
                           : down ? ControlPaint.Dark(baseColor, 0.1f)
                           : hover ? ControlPaint.Light(baseColor, 0.2f)
                           : baseColor;

                var rect = new Rectangle(0, 0, b.Width - 1, b.Height - 1);
                using var path = RoundPath(rect, radius);
                using var brush = new SolidBrush(fill);
                g.FillPath(brush, path);

                TextRenderer.DrawText(g, b.Text, b.Font, rect, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                    TextFormatFlags.EndEllipsis);
            };
            b.Invalidate();
        }

        private static Color BehindColor(Control c)
        {
            Control? p = c.Parent;
            while (p != null)
            {
                if (p.BackColor.A == 255 && p.BackColor != Color.Transparent)
                    return p.BackColor;
                p = p.Parent;
            }
            return Background;
        }
        // ---------- Clean tables ----------
        public static void StyleGrid(DataGridView g)
        {
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = Color.White;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersDefaultCellStyle.BackColor = Primary;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            g.ColumnHeadersHeight = 34;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.GridColor = ColorTranslator.FromHtml("#F8E1E9");
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.RowTemplate.Height = 30;
            g.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFF0F5");
            g.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F8BBD0");
            g.DefaultCellStyle.SelectionForeColor = TextColor;
            g.RowHeadersVisible = false;
        }

        // ---------- Rounded panels (for product cards) ----------
        public static void RoundPanel(Control c, int radius = 14)
        {
            void Make() { using var p = RoundPath(new Rectangle(0, 0, c.Width, c.Height), radius); c.Region = new Region(p); }
            Make();
            c.Resize += (s, e) => Make();
        }

        private static GraphicsPath RoundPath(Rectangle r, int radius)
        {
            int d = radius * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }

}
