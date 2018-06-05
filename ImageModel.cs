using System;
using System.Collections.Generic;
using System.Text;

namespace CarouselViewApp
{
    public class ImageModel
    {
        public string Name { get; set; }
        public string FullPath { get; set; }

        public List<ImageModel> GetData()
        {
            return new List<ImageModel>() {
           new ImageModel() { Name = "one", FullPath = "one.jpg" },
           new ImageModel() { Name = "two", FullPath = "two.jpeg" },
           new ImageModel() { Name = "three", FullPath = "three.jpeg" },
           new ImageModel() { Name = "four", FullPath = "four.jpg" },
           new ImageModel() { Name = "five", FullPath = "five.jpg" },
           new ImageModel() { Name = "six", FullPath = "six.jpg" },
           new ImageModel() { Name = "seven", FullPath = "seven.jpg" }
            };
        }

    }
}
