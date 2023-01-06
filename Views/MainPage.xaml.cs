namespace projectpractice;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	//skickar vidare till sida för att starta ny aktivitet
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new NewActivityPage());
    }
}


