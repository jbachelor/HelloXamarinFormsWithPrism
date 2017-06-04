using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using HelloXamarinForms2.Views;

namespace HelloXamarinForms2.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{

		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		public DelegateCommand NavToTipCalculatorCommand { get; set; }

		INavigationService _navigationService;

		public MainPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			NavToTipCalculatorCommand = new DelegateCommand(NavToTipCalculator);
		}

		void NavToTipCalculator()
		{
			_navigationService.NavigateAsync(nameof(TipCalculatorPage));
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
		}
	}
}

