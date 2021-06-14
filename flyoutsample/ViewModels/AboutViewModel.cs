using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace flyoutsample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private List<Quantity> qtyList;
        public List<Quantity> QtyList
        {
            get { return qtyList; }
            set
            {
                if (qtyList != value)
                {
                    qtyList = value;
                    OnPropertyChanged();
                }
            }
        }

        public Quantity SelectedQty { get; set; }
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => {
               
            });
            List<Quantity> list = new List<Quantity>();
            for(int i = 0; i <= 10; i++){
                list.Add(new Quantity(i.ToString(), i));
            }
            QtyList = list;
        }

        public ICommand OpenWebCommand { get; }
    }

    public class Quantity {

        public Quantity(string displayLable, int qtyValue)
        {
            DisplayLable = displayLable;
            QtyValue = qtyValue;
        }

        public String DisplayLable { get; set; }
        public int QtyValue { get; set; }
    }
}
