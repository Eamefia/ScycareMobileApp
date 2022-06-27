using Android.App;
using Android.Runtime;

namespace ScycareApp;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("RemoveBorder", (handler, view) =>
        {
            handler.PlatformView.Background = null;

        });

    }

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
