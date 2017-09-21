using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shared.Pages
{
    public class BasicPage :ContentPage
    {
        int clickCount = 0;

        readonly Label buttonClickedInformation;
        Button myButton;

        public BasicPage()
        {
            myButton = new Button
            {
                Text = "This is a button"
            };

            myButton.Clicked += MyButton_Clicked;
            buttonClickedInformation = new Label { };

            Content = new StackLayout
            {
                Children = {
                    myButton,
                    buttonClickedInformation
                }
            };
        }

        void MyButton_Clicked(object sender, EventArgs e)
        {
            clickCount++;
            buttonClickedInformation.Text = string.Format("Clicked {0} times", clickCount);
        }
    }
}
