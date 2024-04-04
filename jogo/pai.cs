namespace jogo;

public class Pai
{
    protected double fome;
    protected double sede;
    protected double alegria;
    protected string arquivo;

    public string GetArquivo()
    {
        return arquivo;
    }

    public Pai()
    {
        fome = 0.1;
        sede = 0.1;
        alegria = 0.1;
    }

    public void SetFome(double f)
    {
        if (f <= 1 && f >= 0)
         fome = f;
        else if (f > 1)
         fome = 1;
        else
        {
            fome = 0;
            Application.Current.MainPage=new GameOver();
        }
    }

    public double GetFome()
    {
        return fome;
    }

        public void SetSede(double s)
    {
        if (s <= 1 && s >= 0)
         sede = s;
        else if (s > 1)
         sede = 1;
        else
        {
            sede = 0;
            Application.Current.MainPage=new GameOver();
        }
    }

    public double GetSede()
    {
        return sede;
    }

        public void SetAlegria(double a)
    {
        if (a <= 1 && a >= 0)
         alegria = a;
        else if (a > 1)
         alegria = 1;
        else
        {
            alegria = 0;
            Application.Current.MainPage=new GameOver();
        }
    }

    public double GetAlegria()
    {
        return alegria;
    }

}