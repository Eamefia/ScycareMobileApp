using ScycareApp.ViewModel;

namespace ScycareApp;

public partial class VerifyCode : ContentPage
{
	public VerifyCode(VerifyCodeViewModel vcm)
	{
		InitializeComponent();
        BindingContext = vcm;   
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

}