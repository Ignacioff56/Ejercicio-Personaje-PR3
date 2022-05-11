public class Enemigo : IMoverse
    {
    public int Vida;
    public int Nivel;

    public Enemigo(int vida, int nivel)
    {
        Vida = vida;
        Nivel = nivel;
    }

    public void MoverseEjeX()
    {
        Console.WriteLine("Enemigo se mueve en el eje X");
    }

    public void MoverseEjeY()
    {
        Console.WriteLine("Enemigo se mueve en el eje Y");
    }
}
