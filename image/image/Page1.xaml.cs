using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace image
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public int imageID =1;
        public Page1()
        {
            InitializeComponent();
            imageID = 1;
            loadimage();
        }
        void loadimage()
        {
           active.IsVisible = true;
            if(imageID == 1)
                image.Source = "a.png";
            else if (imageID == 2)
                image.Source = "b";
            else
                image.Source = "c";
            active.IsVisible = false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            imageID--;
            if (imageID == 0)
                imageID = 3;
            loadimage();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            imageID++;
            if (imageID == 4)
                imageID = 1;
            loadimage();
        }
    }
}