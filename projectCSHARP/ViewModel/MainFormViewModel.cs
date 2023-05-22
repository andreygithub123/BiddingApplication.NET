using projectCSHARP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace projectCSHARP.ViewModel
{
    internal class MainFormViewModel : INotifyPropertyChanged
    {
		#region Properties
		#region newName
		private string bindingName;
		public string newName
		{
			get { return bindingName; }
			set
			{
				if (bindingName == value)
					return;
				bindingName = value;

				//If we use [CallerMemberName] in the OnPropertyChanged method
				//OnPropertyChanged();
				//If we don't use the [CallerMemberName] in the OnPropertyChanged method
				OnPropertyChanged("Name");
			}
		}
		#endregion

		#region newId
		private int bindingId;
		public int newId
		{
			get { return bindingId; }
			set
			{
				if (bindingId == value)
					return;
				bindingId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region bindingPrice
		private float bindingPrice;

		public float newPrice
		{
			get { return bindingPrice; }
			set
			{
				if (bindingPrice == value)
					return;
				bindingPrice = value;
				OnPropertyChanged();
			}
		}
		#endregion

		public BindingList<Offer> BindingOffers { get; set; }
		#endregion

		public MainFormViewModel()
		{
			BindingOffers = new BindingList<Offer>();
			
		}

		#region Methods
		public void AddOffer()
		{
			BindingOffers.Add(new Offer(newName, newId, newPrice));
			newName = string.Empty;
			newId = 0;
			newPrice = 0;
		}
		#endregion

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		// [CallerMemberName] - Allows you to obtain the method or property name of the caller to the method. https://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callermembernameattribute%28v=vs.110%29.aspx
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}
	

}
