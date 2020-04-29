using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewItemCliked
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ListViewModel _listViewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = _listViewModel = new ListViewModel();
        }

        //private void ImageButton_Clicked(object sender, EventArgs e)
        //{
        //    string s = "";
        //}
    }
}
