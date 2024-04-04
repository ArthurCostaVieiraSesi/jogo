namespace jogo;

public partial class MainPage : ContentPage
{

	Leafeon leafeon; Squirtle squirtle; Gastly gastly; Pai atual;
IDispatcherTimer timer;

	public MainPage()
	{
		InitializeComponent();
		leafeon = new Leafeon();
		squirtle = new Squirtle();
		gastly = new Gastly();
		atual = leafeon;
		imgPersonagem.Source = atual.GetArquivo();
		timer = Application.Current.Dispatcher.CreateTimer();
    timer.Interval = TimeSpan.FromSeconds(3);
    timer.Tick += (s,e) => PassouTempo();
    timer.Start();
	}

	void Proximo(object sender,EventArgs args)
	{
		if (atual == leafeon)
			atual = squirtle;
		else if (atual == squirtle)
			atual = gastly;
		else if (atual == gastly)
			atual = leafeon;
		imgPersonagem.Source = atual.GetArquivo();
		Felicidade.Progress = atual.GetAlegria();
		Fome.Progress = atual.GetFome();
		Sede.Progress = atual.GetSede();
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
		atual.SetSede(atual.GetSede()+0.1);
		Sede.Progress = atual.GetSede();
	}

	void PassouTempo()
	{
		atual.SetFome(atual.GetFome()-0.1);
		if(atual.GetFome()<=0)
			timer.Stop();
		Fome.Progress = atual.GetFome();
		atual.SetSede(atual.GetSede()-0.1);
		if(atual.GetSede()<=0)
			timer.Stop();
		Sede.Progress = atual.GetSede();
		atual.SetAlegria(atual.GetAlegria()-0.1);
		if(atual.GetAlegria()<=0)
			timer.Stop();
		Felicidade.Progress = atual.GetAlegria();
	}

}

