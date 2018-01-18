
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamTrainBang
{
    public partial class MyListPage : ContentPage
    {
        public MyListPage()
        {
            InitializeComponent();
            CreateNBindElements();
        }

        private void CreateNBindElements()
        {
            var vListItems = new List<MyListItem>();
            vListItems.Add(new MyListItem
            {
                Name = "S Ravi Kumar",
                Age = 36,
                Gender="Male"
            });
            vListItems.Add(new MyListItem
            {
                Name = "Jyoti Swami",
                Age = 38,
                Gender = "Male"
            });
            vListItems.Add(new MyListItem
            {
                Name = "Some One",
                Age = 34,
                Gender = "Female"
            });
            vListItems.Add(new MyListItem
            {
                Name = "Another One",
                Age = 36,
                Gender = "Male"
            });
            lstMyList.ItemsSource = vListItems;
        }
    }

    public class MyListItem
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
    }
}
