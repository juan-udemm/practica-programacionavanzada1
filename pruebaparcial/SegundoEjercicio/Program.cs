using System;

partial class Program
{
    const int MAXCASILLEROS = 34; // MAXCASILLEROS debe ser par

    static void Main()
    {
        // Creamos el tablero
        Tablero tablero = new(MAXCASILLEROS);

        // Generamos los casilleros
        Random aleatorio = new();
        for (var i = 0; i < MAXCASILLEROS; i += 2)
        {
            tablero.casilleros[i] = new CasilleroDeDinero();
            tablero.casilleros[i + 1] = new CasilleroDeEnergia();
            tablero.casilleros[i].DefinirValor(aleatorio.Next(1, 3));
            tablero.casilleros[i + 1].DefinirValor(aleatorio.Next(1, 3));
        }

        // Creamos el jugador
        Jugador jugador = new("Jugador 1");
        int posicion = -1;

        // Mientras tengamos energía, dinero, y no hayamos pasado el último casillero
        while (jugador.Dinero > 0 && jugador.Energia > 0 && posicion < MAXCASILLEROS)
        {
            posicion += aleatorio.Next(1, 7);
            if (posicion < MAXCASILLEROS)
            {
                tablero.casilleros[posicion].RealizarEfecto(jugador);
            }
        }

        // Mostrar en pantalla si el jugador ganó o perdió
        if (jugador.Dinero > 0 && jugador.Energia > 0)
        {
            Console.WriteLine("Jugador ganó");
            Console.WriteLine($"Energía: {jugador.Energia}");
            Console.WriteLine($"Dinero: {jugador.Dinero}");
        }
        else
        {
            Console.WriteLine("Jugador perdió");
            Console.WriteLine($"Energía: {jugador.Energia}");
            Console.WriteLine($"Dinero: {jugador.Dinero}");
        }
    }
}