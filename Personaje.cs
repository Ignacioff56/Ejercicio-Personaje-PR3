public abstract class Personaje : IMoverse
    {
     public string? Nombre;
     public int Fuerza;
     public int Agilidad;
     public int Magia;

    public abstract int CalcularDanio();

    public virtual void Atacar()

     {
         Console.WriteLine(Nombre + " hizo " + CalcularDanio() + " de daño");
     }

    public void MoverseEjeX()
    {
        Console.WriteLine(Nombre + " se mueve en el eje X");
    }

    public void MoverseEjeY()
    {
        Console.WriteLine(Nombre + " se mueve en el eje Y");
    }



}


