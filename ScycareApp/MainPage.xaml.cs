using ScycareApp.ViewModel;
using Twilio;
using Twilio.Rest.Verify.V2.Service;
namespace ScycareApp;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel mvm)
	{
		InitializeComponent();
		BindingContext = mvm;	
	}
}

