
using Xamarin.Forms;

namespace XamTrainBang
{
    public partial class ViewUser : ContentPage
    {
        public ViewUser(AppUser aUser)
        {
            InitializeComponent();
            BindingContext = aUser;
        }
    }
}
