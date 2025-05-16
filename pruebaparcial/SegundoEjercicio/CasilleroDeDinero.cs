
    // Suponiendo que la clase abstracta se llama Casillero
    public class CasilleroDeDinero : Casillero
    {
        public int Monto { get; set; }


        public override void DefinirValor(int valor)
        {
            Monto = valor;
        }
        public CasilleroDeDinero()
        {
        }

        // Sobrescribe el método abstracto de la clase base
        public override void RealizarEfecto(Jugador jugador)
        {
            // El jugador pierde dinero al pasar por este casillero
            jugador.Dinero -= Monto;
            if (jugador.Dinero < 0)
                jugador.Dinero = 0;
        }
    }