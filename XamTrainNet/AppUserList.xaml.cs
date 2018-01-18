using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamTrainBang
{
    public partial class AppUserList : ContentPage
    {
        public AppUserList()
        {
            InitializeComponent();
            var vUserList = App.DAUtil.GetAllUser();
            lstUsers.ItemsSource = vUserList;
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            var vSelUser = (AppUser)e.SelectedItem;
            Navigation.PushAsync(new ViewUser(vSelUser));
            //DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
        }
        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CreateSampleData());
        }
    }
}
