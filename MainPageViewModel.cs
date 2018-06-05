using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarouselViewApp
{
   public class MainPageViewModel:INotifyPropertyChanged
    {
        private List<ImageModel> _lstImage;
        int _position;

        //binding models
        public List<ImageModel> lstImage { get => _lstImage; set { _lstImage = value;onPropertyChanged(); } }
        public int position { get => _position; set { _position = value; onPropertyChanged(); } }


        public event PropertyChangedEventHandler PropertyChanged;

        void onPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public MainPageViewModel() {
            position = 0;
            img_clicked = new Command(ImageClicked);
            lstImage = new ImageModel().GetData();
        }


        public ICommand img_clicked { get; }

        public void ImageClicked(object image)
        {
            var path = (image as Xamarin.Forms.Image).Source.ToString().Split(':')[1].Trim();
            position = lstImage.IndexOf(lstImage.Find(x => x.FullPath == path));
        }
    }
}
