namespace jogo;

public partial class MainPage : ContentPage
{

	Leafeon leafeon; Squirtle squirtle; Gastly gastly; Pai atual;

	public MainPage()
	{
		InitializeComponent();
		leafeon = new Leafeon();
		squirtle = new Squirtle();
		gastly = new Gastly();
		atual = leafeon;
		imgPersonagem.Source = atual.GetArquivo();
	}

	void Proximo(object sender,EventArgs args)
	{
		if (atual == leafeon)
			atual = squirtle;
		else if (atual == squirtle)
			atual = gastly;
		else if (atual == gastly)
			atual = leafeon;
		imgPersonagem.Source=atual.GetArquivo();
	}

	void Feliz(object sender,EventArgs args)
	{
		atual.SetAlegria(atual.GetAlegria()+0.1);
		Felicidade.Progress = atual.GetAlegria();
	}

	void Comida(object sender,EventArgs args)
	{
		atual.SetFome(atual.GetFome()+0.1);
		Fome.Progress = atual.GetFome();
	}

	void Agua(object sender,EventArgs args)
	{
		atual.SetSede(atual.GetFome()+0.1);
		Sede.Progress = atual.GetSede();
	}

}

