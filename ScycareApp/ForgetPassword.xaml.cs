using ScycareApp.ViewModel;

namespace ScycareApp;

public partial class ForgetPassword : ContentPage
{
	public ForgetPassword(RegisterViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}