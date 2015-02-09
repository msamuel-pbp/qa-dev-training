using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Chapter19 {
    public class ImageURL {
        public string Path { get; private set; }
        public Uri ImageURI { get; set; }

        public BitmapFrame Image { get; private set; }
        public string Name { get; set; }
        public void ImageUrl() {}
        public void ImageUrl(string path, string name) {
            Path = path;
            ImageURI = new Uri(Path);
            Image = BitmapFrame.Create(ImageURI);
            Name = name;
        }
        public override string ToString() {
            return Path;
        }
    }

    public class Images : List<ImageURL> {};
}