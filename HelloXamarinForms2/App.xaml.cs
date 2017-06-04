using Prism.Unity;
using HelloXamarinForms2.Views;
using Xamarin.Forms;

namespace HelloXamarinForms2
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync($"NavigationPage/{nameof(MainPage)}");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<TipCalculatorPage>();
		}
	}
}

