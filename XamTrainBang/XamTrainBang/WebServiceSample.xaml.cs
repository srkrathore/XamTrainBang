using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamTrainBang
{
    public partial class WebServiceSample : ContentPage
    {
        public WebServiceSample()
        {
           InitializeComponent();        
   
        }
        protected async override void OnAppearing() {
            var vServiceClient = new NyServiceClient();
            var vServiceResult = await vServiceClient.GetStoryList();
            lstUsers.ItemsSource = vServiceResult.results;
            BindingContext = vServiceResult;
        }


    }
}
