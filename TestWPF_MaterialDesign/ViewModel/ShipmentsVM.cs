using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWPF_MaterialDesign.Model;

namespace TestWPF_MaterialDesign.ViewModel
{
    internal class ShipmentsVM : Utilites.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public TimeOnly ShipmentTracking
        {
            get { return _pageModel.ShirmentDelivery; }
            set { _pageModel.ShirmentDelivery = value; OnPropertyChanged(); }
        }

        public ShipmentsVM()
        {
            _pageModel = new PageModel();
            TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
            ShipmentTracking = time;
        }
    }
}
