using System;
using System.Collections;

namespace FINAL_OCTUBRE
{
	public class CEspectador
	{
		private string nombre, apellido;
		private int dni, numeroButaca;
		//***************************************************************************************************
		public CEspectador(string nombre, string apellido, int dni)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.numeroButaca = -1;
		}
		//**************************************************************************************************
		public string Nombre {
			set {
				this.nombre = value;
			}
			get {
				return this.nombre;
			}
		}
		public string Apellido {
			set {
				this.apellido = value;
			}
			get {
				return this.apellido;
			}
		}
		public int Dni {
			set {
				this.dni = value;
			}
			get {
				return this.dni;
			}
		}
		public int NumeroButaca {
			set {
				this.numeroButaca = value;
			}
			get {
				return this.numeroButaca;
			}
		}
	}
}
