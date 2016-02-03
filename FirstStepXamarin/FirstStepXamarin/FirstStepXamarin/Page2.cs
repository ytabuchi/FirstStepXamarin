using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FirstStepXamarin
{
    public class Page2 : ContentPage
    {
        public Page2(string name)
        {
            Title = "Welcome";
            Content = new StackLayout
            {
                Padding = 15,
                Children = {
                    new Label {
                        Text = "Hello " + name,
                        HorizontalOptions = LayoutOptions.Center,
                    }
                }
            };
        }
    }
}
