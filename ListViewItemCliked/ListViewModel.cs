using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListViewItemCliked
{
  public  class ListViewModel: BaseViewModel
    {
		private ObservableCollection<string> _listSource;

		public ObservableCollection<string> ListSource
		{
			get { return _listSource; }
			set { _listSource = value;  OnPropertyChanged(); }
		}

		public ListViewModel()
		{
			_listSource = new ObservableCollection<string>
			{
				"First Entry",
				"Second Entry",
				"Third Entry",
			};
		}
		private string _alertMessage;

		public string AlertMessage
		{
			get { return _alertMessage; }
			set { _alertMessage = value; OnPropertyChanged(); }
		}


		public ICommand ItemClickCommand
		{
			get
			{
				return new Command((item) =>
				{
					AlertMessage = item as string;
				});
			}
		}

	}
}
