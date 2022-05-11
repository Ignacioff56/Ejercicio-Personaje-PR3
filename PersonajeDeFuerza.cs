class PersonajeDeFuerza : Personaje
{
 public PersonajeDeFuerza(string Nombre, int Agilidad, int Magia)
     {
     this.Nombre = Nombre;
     Fuerza = 100;
     this.Agilidad = Agilidad;
     this.Magia = Magia;
     }

     public override int CalcularDanio()
     {
      return 10*Fuerza + Agilidad + Magia;
     }
} 