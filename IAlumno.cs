/*
 * Creado por SharpDevelop.
 * Usuario: nico_
 * Fecha: 7/5/2025
 * Hora: 23:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase_6
{
	public interface IAlumno : Comparable
	{
		string getNombre();
		void setNombre(string n);
		int getDni();
		void setDni(int d);
        int getLegajo();
		void setLegajo(int l);
        int getPromedio();
		void setPromedio(int p);
        void setCalificacion(int c);
		int getCalificacion();
		void setNvaEstrategia(EstrategiaDeComparacion nvaEstrategia);
		
		void prestandoAtencion();
		void distraerse();
		void actualizar(Observado o);
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
	}
}
