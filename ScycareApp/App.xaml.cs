using Microsoft.Maui.Platform;

namespace ScycareApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
        {
            handler.PlatformView.SetBackgroundColor(Colors.Red.ToPlatform());
        });

        MainPage = new AppShell();
	}
}
