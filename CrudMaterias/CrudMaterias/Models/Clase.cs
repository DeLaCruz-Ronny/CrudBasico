using System;
using System.Collections.Generic;

#nullable disable

namespace CrudMaterias.Models
{
    public partial class Clase
    {
        public int IdMateria { get; set; }
        public string Descripcion { get; set; }
        public int Creditos { get; set; }
        public string Mestro { get; set; }
    }
}
