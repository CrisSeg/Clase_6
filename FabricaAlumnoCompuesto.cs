using Clase_6;

namespace clase_6
{
    public class FabricaAlumnoCompuesto : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                AlumnoProxy al = new AlumnoProxy(gen.stringAleatorio(5), gen.numeroAleatorio(1000000), gen.numeroAleatorio(1000), gen.numeroAleatorio(10), 5);
                compuesto.agregarHijos(al);
            }
            return compuesto;
        }
        public override Comparable crearPorTeclado()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                AlumnoProxy al = new AlumnoProxy(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), 5);
                compuesto.agregarHijos(al);
            }
            return compuesto;
        }
    }
}
