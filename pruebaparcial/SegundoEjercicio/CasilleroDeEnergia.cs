public class CasilleroDeEnergia : Casillero
{
    private int EnergiaExtra;

    public override void DefinirValor(int valor)
    {
        EnergiaExtra = valor;
    }
    public CasilleroDeEnergia()
    {
    }

    public override void RealizarEfecto(Jugador jugador)
    {
        jugador.Energia += EnergiaExtra;
    }
}