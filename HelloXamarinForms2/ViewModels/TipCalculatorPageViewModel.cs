using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace HelloXamarinForms2.ViewModels
{
	public class TipCalculatorPageViewModel : BindableBase
	{
		private int _tipPercentage;
		public int TipPercentage
		{
			get { return _tipPercentage; }
			set
			{
				Debug.WriteLine($"**** {this.GetType().Name}.{nameof(TipPercentage)}:  Setting tip percent to {value}");
				SetProperty(ref _tipPercentage, value);
				CalculateTip();
			}
		}

		private double _billAmount;
		public double BillAmount
		{
			get { return _billAmount; }
			set
			{
				SetProperty(ref _billAmount, value);
				CalculateTip();
			}
		}

		private double _tipAmount;
		public double TipAmount
		{
			get { return _tipAmount; }
			set { SetProperty(ref _tipAmount, value); }
		}

		public TipCalculatorPageViewModel()
		{
			TipPercentage = 18;
		}

		private void CalculateTip()
		{
			TipAmount = (BillAmount * TipPercentage) / 100.0;
			Debug.WriteLine($"**** {this.GetType().Name}.{nameof(CalculateTip)}:  TipPercentage={TipPercentage}, BillAmount={BillAmount}, TipAmount={TipAmount}");
		}
	}
}
