using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWhatsAppStatusSaver
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatusSaverMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public StatusSaverMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new StatusSaverMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class StatusSaverMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<StatusSaverMasterDetailPageMasterMenuItem> MenuItems { get; set; }

            public StatusSaverMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<StatusSaverMasterDetailPageMasterMenuItem>(new[]
                {
                    new StatusSaverMasterDetailPageMasterMenuItem { Id = 0, Title = "Remove Ads" },
                    new StatusSaverMasterDetailPageMasterMenuItem { Id = 1, Title = "Send feedback" },
                    new StatusSaverMasterDetailPageMasterMenuItem { Id = 2, Title = "Rate us" },
                    new StatusSaverMasterDetailPageMasterMenuItem { Id = 3, Title = "Share app" },
                    new StatusSaverMasterDetailPageMasterMenuItem { Id = 4, Title = "About us" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}