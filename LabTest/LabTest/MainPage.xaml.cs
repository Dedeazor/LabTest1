using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Frame circleImageFrame = new Frame
            {
                Margin = 10,
                BorderColor = Color.Orange,
                CornerRadius = 50,
                HeightRequest = 60,
                WidthRequest = 60,
                IsClippedToBounds = true,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Image
                {
                    Source = ImageSource.FromFile("image5.jpg"),
                    Aspect = Aspect.AspectFill,
                    Margin = 10,
                    HeightRequest = 100,
                    WidthRequest = 100
                }
            };
        }
    }
            
}
