using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamTrainBang
{
    public class MasterDetailByCode : MasterDetailPage
    {
        public MasterDetailByCode()
        {
            Master = new RelativeEx() { Title = "Relative Ex" };
            Detail = new GridExample();
        }
    }
}
