namespace ScycareApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(ForgetPassword), typeof(ForgetPassword));
        Routing.RegisterRoute(nameof(VerifyCode), typeof(VerifyCode));
        Routing.RegisterRoute(nameof(Register), typeof(Register));
        Routing.RegisterRoute(nameof(RequestLabTest), typeof(RequestLabTest));
        Routing.RegisterRoute(nameof(Home), typeof(Home));
    }
}
