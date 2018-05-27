using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace interfazDemo
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            masterPage.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                var navigationPage = new NavigationPage((Page)Activator.CreateInstance(item.TipoPagina));
                navigationPage.BarBackgroundColor = Color.MidnightBlue;
                Detail = navigationPage;
                //Detail = new NavigationPage((Page)Activator.CreateInstance(item.TipoPagina));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
