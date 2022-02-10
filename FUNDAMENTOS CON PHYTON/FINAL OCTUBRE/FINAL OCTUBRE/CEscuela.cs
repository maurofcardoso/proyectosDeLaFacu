using System;
using System.Collections;

namespace FINAL_OCTUBRE
{
	public class CEscuela
	{
		protected ArrayList alumnos;
		private string nombre;
		
		public CEscuela(string nom)
		{
			alumnos = new ArrayList ();
			this.nombre = nom;
		}
		public ArrayList getAlumnos {
			get {
				return alumnos;
			}
		}
		public void inscribirAlu (CAlumno a) {
			alumnos.Add (a);
		}
		public double matriculaAnual (CEscuelaPrivada esc) {
			double matriculaAnual = 0;
			foreach (CAlumno x in alumnos) {
				if (x.CantHerm > 2) {
					matriculaAnual += esc.Matricula * 0.8;
				}
				else {
					matriculaAnual += esc.Matricula;
				}
			}
			return matriculaAnual;
		}
		public double cuotaAnual (CEscuelaPrivada esc) {
			double cuotaAnual = 0;
			foreach (CAlumno x in alumnos) {
				if (x.CantHerm > 2) {
					cuotaAnual += (esc.CuotaMensual * 0.8) * 11;
				}
				else {
					cuotaAnual += esc.CuotaMensual * 11;
				}
			}
			return cuotaAnual;
		}
		public double recaudacionAnual (CEscuelaPrivada esc) {
			return (matriculaAnual (esc) + cuotaAnual (esc) );
		}
		
		
	}
}
