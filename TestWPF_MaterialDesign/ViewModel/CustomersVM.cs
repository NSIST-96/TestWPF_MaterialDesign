using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWPF_MaterialDesign.Model;

namespace TestWPF_MaterialDesign.ViewModel
{
    class CustomersVM : Utilites.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public int CustomerID
        {
            get { return _pageModel.CustomerCount; }
            set { _pageModel.CustomerCount = value; OnPropertyChanged(); }

        }

        public CustomersVM()
        {
            _pageModel = new PageModel();
            CustomerID = 100528;
        }
    }
}
