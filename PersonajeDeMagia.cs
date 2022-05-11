using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class PersonajeDeMagia : Personaje
{
  public PersonajeDeMagia(string Nombre, int Fuerza, int Agilidad, int Magia)
    {
        this.Nombre = Nombre;
        this.Fuerza = Fuerza;
        this.Agilidad = Agilidad;
        this.Magia = Magia;
    }
  public PersonajeDeMagia(string Nombre, int Fuerza, int Agilidad)
    {
        this.Nombre = Nombre;
        this.Fuerza = Fuerza;
        this.Agilidad = Agilidad;
        Magia = 60;
    }

    public override int CalcularDanio()
    {
        return Fuerza + Agilidad + Magia * 4;
    }
    public override void Atacar()
    {
        Console.WriteLine(Nombre + " hizo " + CalcularDanio() + " de daño gracias a su magia.");
    }
}



 