using System;
using Xamarin.Forms;

namespace XamTrainBang
{
    public partial class UiXamEx : ContentPage
    {
        public UiXamEx()
        {
            InitializeComponent();
        }

        int iClickCount = 0;
        public void OnButtonClick(object sender, EventArgs args)
        {
            iClickCount++;
            lblMessage.Text = " You Clicked the button " + iClickCount.ToString() + " times";
        }
    }
}
