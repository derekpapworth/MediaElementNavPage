namespace MediaElementNavPage;

public partial class MediaPage : ContentPage
{
	public MediaPage()
	{
		InitializeComponent();
	}

    private void ContentPage_Unloaded(object sender, EventArgs e)
    {
		me1.Handler?.DisconnectHandler();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
        //await Navigation.PopModalAsync();
    }
}

