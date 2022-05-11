class PersonajeDeAgilidad : Personaje
{
  public PersonajeDeAgilidad(string Nombre, int Fuerza, int Agilidad, int Magia)
    {
        this.Nombre = Nombre;
        this.Fuerza = Fuerza;
        this.Agilidad = Agilidad;
        this.Magia = Magia;
    }

    public override int CalcularDanio()
    {
        return Fuerza / 2 * Agilidad * Magia / 2;
    }

}



 