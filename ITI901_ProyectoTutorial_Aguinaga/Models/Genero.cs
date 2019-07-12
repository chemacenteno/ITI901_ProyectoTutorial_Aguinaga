using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITI901_ProyectoTutorial_Aguinaga.Models
{
	public class Genero
	{
		public int Id { get; set; }

		public string Nombre { get; set; }

		public string Descripcion { get; set; }

		public virtual IEnumerable<Videojuego> Videojuegos { get; set; }
	}
}