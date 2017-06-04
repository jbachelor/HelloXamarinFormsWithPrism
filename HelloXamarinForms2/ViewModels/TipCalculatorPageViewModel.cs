using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloXamarinForms2.ViewModels
{
	public class TipCalculatorPageViewModel : BindableBase
	{
		private double _tipPercentage;
		public double TipPercentage
		{
			get { return _tipPercentage; }
			set { SetProperty(ref _tipPercentage, value); }
		}

		private double _billAmount;
		public double BillAmount
		{
			get { return _billAmount; }
			set { SetProperty(ref _billAmount, value); }
		}

		public TipCalculatorPageViewModel()
		{
			TipPercentage = 0.18;
		}
	}
}
