using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Automotriz.Models.Modelos_Usuario
{
    public class Cliente_Modelo
    {
        public int IdCliente { get; set; }
        //[Required(ErrorMessage ="Este campo es obligatorio")]

        //este signo indica q ? el valor puede ser nulo
        public int? Numero { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Nullable<System.DateTime> FechaNac { get; set; }
        public string Sexo { get; set; }
        public string TelCasa { get; set; }
        public string TelCel { get; set; }
        public string Correo { get; set; }
        public string RFC { get; set; }
        public Nullable<int> IdMunicipio { get; set; }
        public Nullable<int> IdEstado_Cliente { get; set; }
    }
}