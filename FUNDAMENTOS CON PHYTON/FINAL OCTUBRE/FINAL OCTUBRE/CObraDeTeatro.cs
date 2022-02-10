using System;
using System.Collections;

namespace FINAL_OCTUBRE
{
	public class CObraDeTeatro : CEspectaculo
	{
		private string titulo;
		private double precio;
		private int butacasLibres;
		private ArrayList listaEspectadores;
		
		//*********************************************************************************************************
		public CObraDeTeatro(string titulo, double precio, int capacidad) : base (capacidad)
		{
			this.titulo = titulo;
			this.precio = precio;
			this.butacasLibres = this.Capacidad;
			this.listaEspectadores = new ArrayList ();
		}
		//********************************************************************************************************
		public string Titulo {
			set {
				this.titulo = value;
			}
			get {
				return this.titulo;
			}
		}
		public double Precio {
			set {
				this.precio = value;
			}
			get {
				return this.precio;
			}
		}
		public int ButacasLibres {
			set {
				this.butacasLibres = value;
			}
			get {
				return this.butacasLibres;
			}
		}
		public void venderEntrada (CEspectador unEsp) {
			int cont = 0;
			foreach (CButaca x in this.CapacidadButacas) {
				cont++;
				if (x.Libre == true) {
					x.Libre = false;
					unEsp.NumeroButaca = cont;
					butacasLibres = butacasLibres - 1;
					listaEspectadores.Add (unEsp);
				}
			}
		}
		public void imprimiresp () {
			foreach (CEspectador x in listaEspectadores) {
				Console.WriteLine (x.Apellido);
			}
		}
	}
}
