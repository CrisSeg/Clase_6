﻿using System;

namespace Clase_6
{
	public class AlumnoDecoradoLegajoDec: AlumnoDecorado
	{
		public AlumnoDecoradoLegajoDec(IAlumno d): base(d){
		}
		
		public override string mostrarCalificacion(){
			string res = base.mostrarCalificacion();
			res += "      " + "(" + this.getLegajo() + ")";
			return res;
		}
	}
}
