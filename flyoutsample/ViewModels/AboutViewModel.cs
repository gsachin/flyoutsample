using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace flyoutsample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private List<UInt16> qtyList;
        private UInt16 _selectedQty;
        private Boolean _showQtyListDialog;
        private Boolean _showQtyEntryDialog;
        public ICommand OpenQtyDialog { get; set; }
        public Boolean ShowQtyList { 
            get {
                return _showQtyListDialog;
            } set {
                _showQtyListDialog = value;
                //_showQtyEntryDialog = false;
                OnPropertyChanged();
            }
        }

        public List<UInt16> QtyList
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

        public UInt16 SelectedQty {
            get {
                return _selectedQty;
            }
            set {

                _selectedQty = value;
                if (value >= 10)
                {
                    ShowQtyList = false;
                    ShowQtyEntryDialog = true;

                }
                OnPropertyChanged();
            } 
        }

        public bool ShowQtyEntryDialog { 
            get 
                {
                return _showQtyEntryDialog;
                }
            set {
                _showQtyEntryDialog = value;
                ShowQtyList = false;
                OnPropertyChanged();
            }
        }

        public AboutViewModel()
        {
            Title = "About";

            List<UInt16> list = new List<UInt16>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add((UInt16)i);
            }
            QtyList = list;
            OpenQtyDialog = new Command(OnSelectQtyClicked);
        }

        private void OnSelectQtyClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            //await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            ShowQtyList = true;
        }

        // public ICommand OpenWebCommand { get; }

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
