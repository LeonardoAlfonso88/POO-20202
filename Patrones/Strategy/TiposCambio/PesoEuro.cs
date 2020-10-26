namespace Patrones.Strategy.TiposCambio
{
    public class PesoEuro : ICambioMoneda
    {
        public double realizarCambio(double valor)
        {
            double tranformacion = valor / 4500;
            return tranformacion;
        }
    }
}