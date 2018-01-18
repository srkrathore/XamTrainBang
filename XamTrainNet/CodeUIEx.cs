
using System;
using Xamarin.Forms;

namespace XamTrainBang
{
    public class CodeUIEx : ContentPage
    {
        Label lblMessage;
        int iClickCount = 0;
        public CodeUIEx()
        {
            lblMessage = new Label();
            Button btnExample = new Button { Text = "Click Me" };
            btnExample.Clicked += OnButtonClick;
            var vMainStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Label { Text = "UI Interaction Code example", HorizontalTextAlignment=TextAlignment.Center },
                    lblMessage, btnExample

                }
            };
            Content = vMainStack;
        }

        public void OnButtonClick(object sender, EventArgs args)
        {
            Navigation.PushAsync (new UiXamEx());
        }

    }
}
