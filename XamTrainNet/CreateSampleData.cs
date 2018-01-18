using System;
using Xamarin.Forms;

namespace XamTrainBang
{
    public class CreateSampleData : ContentPage
    {
        public CreateSampleData()
        {
            var vButton = new Button { Text = "Create Sample Data" };
            vButton.Clicked += VButton_Clicked;
            Content = new StackLayout
            { VerticalOptions = LayoutOptions.Center,
              HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new Label { Text = "This Page is for creating Sample Data" },vButton

                }
            };

      
        }

   

        private void VButton_Clicked(object sender, EventArgs e)
        {
            var vUser = new AppUser()
            {
                UserName = "S Ravi",
                DateOfBirth = DateTime.Now,
                TimeOfBirth = DateTime.Now,
                Gender = "Male",
                State = "Bihar",
                Qualification = "MTech",
                LoginPass = "Password"
            };
            var vUserOne = new AppUser()
            {
                UserName = "Mansi",
                DateOfBirth = DateTime.Now,
                TimeOfBirth = DateTime.Now,
                Gender = "FeMale",
                State = "Punjab",
                Qualification = "MTech",
                LoginPass = "Password"
            };
            var vUserTwo = new AppUser()
            {
                UserName = "Gagandeep",
                DateOfBirth = DateTime.Now,
                TimeOfBirth = DateTime.Now,
                Gender = "Male",
                State = "Punjab",
                Qualification = "MTech",
                LoginPass = "Password"
            };
            var vUserThree = new AppUser()
            {
                UserName = "Heena",
                DateOfBirth = DateTime.Now,
                TimeOfBirth = DateTime.Now,
                Gender = "FeMale",
                State = "Bihar",
                Qualification = "MTech",
                LoginPass = "Password"
            };
            var vUserFour = new AppUser()
            {
                UserName = "Guninder",
                DateOfBirth = DateTime.Now,
                TimeOfBirth = DateTime.Now,
                Gender = "FeMale",
                State = "Punjab",
                Qualification = "MTech",
                LoginPass = "Password"
            };

            App.DAUtil.SaveUser(vUser);
            App.DAUtil.SaveUser(vUserOne);
            App.DAUtil.SaveUser(vUserTwo);
            App.DAUtil.SaveUser(vUserThree);
            App.DAUtil.SaveUser(vUserFour);
            Navigation.PushAsync(new AppUserList());
        }
    }
}
