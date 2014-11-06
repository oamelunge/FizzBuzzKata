namespace CalculadorBisiesto
{
    public class CalculadorBisiestos
    {
        private static int anio;

        public CalculadorBisiestos(int _anio)
        {
            anio = _anio;          
        }

        public bool value()
        {           
            return EsAnioBisiesto() && !EsAnioTipico();
        }

        private static bool EsAnioBisiesto()
        {
            return anio % 4 == 0;
        }

        private static bool EsAnioTipico()
        {
            return (anio % 100 == 0) && (anio % 400 != 0);
        }
    }
}