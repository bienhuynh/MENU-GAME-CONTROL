using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Service
{
    public static class DirectorySize
    {
        public static long GetDirectorySize(string p)
        {
            // 1.
            // Get array of all file names.
            string[] a = Directory.GetFiles(p, "*.*");

            // 2.
            // Calculate total bytes of all files in a loop.
            long b = 0;
            foreach (string name in a)
            {
                // 3.
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            // 4.
            // Return total size
            return b;
        }

        public static Icon IconMaxSize(Icon[] icons)
        {
            Icon icon = null;
            icon = icons[0];
            foreach (var item in icons)
            {
                if (icon == item) break;
                if (icon.Width < item.Width)
                {
                    icon = item;
                    item.Dispose();
                }
            }
            return icon;
        }

        public static int GetIndexIconMaxSize(Icon[] icons)
        {
            Icon icon = null;
            int i = 0;
            icon = icons[0];
            foreach (var item in icons)
            {
                if (icon == item) break;
                if (icon.Width < item.Width)
                {
                    icon = item;
                    item.Dispose();
                }
                i++;
            }
            return i;
        }
    }
}
