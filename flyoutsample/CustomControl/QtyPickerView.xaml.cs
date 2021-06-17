using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace flyoutsample.CustomControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QtyPickerView : ContentView
    {
        public static readonly BindableProperty QtyListProperty =
               BindableProperty.Create(
                   nameof(QtyList),
                   typeof(List<int>),
                   typeof(QtyPickerView),
                   default(List<int>));
        public List<int> QtyList
        {
            get { return (List<int>)GetValue(QtyListProperty); }
            set => SetValue(QtyListProperty, value);
        }
        public static readonly BindableProperty SelectedQtyBindableProperty =
            BindableProperty.Create(
                nameof(SelectedQty),
                typeof(UInt16),
                typeof(QtyPickerView),
                default(UInt16));
        public UInt16 SelectedQty
        {
            get { return (UInt16)GetValue(SelectedQtyBindableProperty); }
            set => SetValue(SelectedQtyBindableProperty, value);
        }

        public static readonly BindableProperty ShowQtyListBindableProperty =
            BindableProperty.Create(
                nameof(ShowQtyList),
                typeof(Boolean),
                typeof(QtyPickerView),
                default(Boolean));
        public Boolean ShowQtyList
        {
            get { return (Boolean)GetValue(ShowQtyListBindableProperty); }
            set => SetValue(ShowQtyListBindableProperty, value);
        }

        public static readonly BindableProperty ShowQtyEntryDialogBindableProperty =
            BindableProperty.Create(
                nameof(ShowQtyEntryDialog),
                typeof(Boolean),
                typeof(QtyPickerView),
                default(Boolean));
        public Boolean ShowQtyEntryDialog
        {
            get { return (Boolean)GetValue(ShowQtyEntryDialogBindableProperty); }
            set => SetValue(ShowQtyEntryDialogBindableProperty, value);
        }

        public QtyPickerView()
        {
            InitializeComponent();
        }
    }
}