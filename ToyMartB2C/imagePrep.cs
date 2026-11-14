using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
namespace ToyMartB2C
{
    public static class imagePrep
    {
        public static readonly string Folder = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "ToyMart", "ProductImages");
        public static string Save(string sourcePath)
        {
            Directory.CreateDirectory(Folder);
            string name = Guid.NewGuid().ToString("N") + Path.GetExtension(sourcePath).ToLower();
            File.Copy(sourcePath, Path.Combine(Folder, name));
            return name;
        }
        public static Image? Load(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return null;
            string full = Path.Combine(Folder, fileName);
            if (!File.Exists(full)) return null;
            using var fs = new FileStream(full, FileMode.Open, FileAccess.Read);
            using var img = Image.FromStream(fs);
            return new Bitmap(img);
        }
    }

}
