using System;
using System.Collections;

namespace FINAL_OCTUBRE
{
	public class CAlumno
	{
		private string nombre;
		private int dni, cantHerm;
		
		public CAlumno(string n, int doc, int h)
		{
			this.nombre = n;
			this.dni = doc;
			this.cantHerm = h;
		}
		public string Nombre {
			set {
				nombre = value;
			}
			get {
				return nombre;
			}
		}
		public int Dni {
			set {
				dni = value;
			}
			get {
				return dni;
			}
		}
		public int CantHerm {
			set {
				cantHerm = value;
			}
			get {
				return cantHerm;
			}
		}
	}
}
