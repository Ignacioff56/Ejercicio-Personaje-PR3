public static class Turno
    {
    public static void Atacarse(IList<Personaje> personajes)
    {
        foreach (Personaje personaje in personajes)
        {
            personaje.Atacar();
        }
    }
    public static void MoverFichas(IMoverse ficha)
    {
        ficha.MoverseEjeX();
        ficha.MoverseEjeY();
    }
    }

