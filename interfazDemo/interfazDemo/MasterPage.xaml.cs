using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace interfazDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class masterPage : ContentPage
	{
        public ListView ListView { get { return ListView; } }
        public masterPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}