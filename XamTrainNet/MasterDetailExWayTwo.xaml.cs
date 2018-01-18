using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamTrainBang
{
    public partial class MasterDetailExWayTwo : MasterDetailPage
    {
        public MasterDetailExWayTwo()
        {
            InitializeComponent();
            Master = new RelativeEx() { Title="Relative Ex"} ;
            Detail = new GridExample();
        }
    }
}
