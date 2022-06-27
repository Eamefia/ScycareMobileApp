using CommunityToolkit.Maui.Views;

namespace ScycareApp;

public partial class IndividualTest : ContentPage
{
	public IndividualTest()
	{
		InitializeComponent();
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
    private void ShowPopup(object sender, EventArgs e)
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