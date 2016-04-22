

using Xamarin.Forms;

namespace XamTrainBang
{
    public class CarasoulExCode : CarouselPage
    {
        public CarasoulExCode()
        {
            Children.Add(new RelativeEx());
            Children.Add(new GridExample());
            Children.Add(new CodeUIEx());
           
        }
    }
}
