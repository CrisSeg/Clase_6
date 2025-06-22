using System;

namespace Clase_6
{
	public interface Observado
	{
		void agregraObservador(Observador o);
		void quitarObsevador(Observador o);
		void notificar();
	}
}
