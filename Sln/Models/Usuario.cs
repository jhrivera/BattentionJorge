//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sln.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Usuario1 { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
