namespace ScycareApp;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
        ShowPopup();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RequestLabTest());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        popup.IsOpen = false;
        popup2.IsOpen = true;

    }

    private void ClosePopup(object sender, EventArgs e)
    {
        popup.IsOpen = false;
    }
    void ShowPopup()
    {
        popup.IsOpen = true;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        popup2.IsOpen = false;
        popup3.IsOpen = true;
    }
    private void Button_Clicked_2(object sender, EventArgs e)
    {
        popup3.IsOpen = false;
        popup4.IsOpen = true;
    }
}