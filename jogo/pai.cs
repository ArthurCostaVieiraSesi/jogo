namespace jogo;

public class Pai
{
    protected int fome;
    protected int sede;
    protected int alegria;
    public int arquivo;

    public Pai()
    {
        fome = 0;
        sede = 0;
        alegria = 0;
    }

    public void SetFome(int f)
    {
        if (f <= 1 || f >= 0)
         fome = f;
        else if (f > 1)
         fome = 1;
        else
         fome = 0;
    }

    public int GetFome()
    {
        return fome;
    }

        public void SetSede(int s)
    {
        if (s <= 1 || s >= 0)
         sede = s;
        else if (s > 1)
         sede = 1;
        else
         sede = 0;
    }

    public int GetSede()
    {
        return sede;
    }

        public void SetAlegria(int a)
    {
        if (a <= 1 || a >= 0)
         alegria = a;
        else if (a > 1)
         alegria = 1;
        else
         alegria = 0;
    }

    public int GetAlegria()
    {
        return alegria;
    }

}