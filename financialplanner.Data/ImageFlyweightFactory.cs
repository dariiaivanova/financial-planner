using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace financialplanner.Data
{
    public class ImageFlyweightFactory
    {
        public static Dictionary<string, ImageSource> Images = new Dictionary<string, ImageSource>();

        public static ImageSource CreateImage(string key)
        {
            if (!Images.ContainsKey(key))
            {
                Images.Add(key, GetImageFromResourceString(key));
            }

            return Images[key];
        }

        private static BitmapImage GetImageFromResourceString(string imageName)
        {
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("Resources\\" + imageName + ".png", UriKind.Relative);
            image.EndInit();
            return image;
        }
    }
}
