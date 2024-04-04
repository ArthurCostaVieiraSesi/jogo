namespace jogo;

public partial class GameOver : ContentPage
{

    public GameOver()
	{
		InitializeComponent();
    }

    void tenta(object sender,EventArgs args)
	{
        Application.Current.MainPage=new MainPage();
    }

}
