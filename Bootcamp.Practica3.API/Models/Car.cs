using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Practica3.API.Models
{
    [Table("Car")]
    public class Car
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Placa")]
        public string Placa { get; set; }
        [Column("Modelo")]
        public string Modelo { get; set; }
        [Column("Marca")]
        public string Marca { get; set; }
        [Column("Año")]
        public int Año { get; set; }
        [Column("Dueño_Nombre")]
        public string Dueño_Nombre { get; set; }
        [Column("Dueño_Apellido")]
        public string Dueño_Apellido { get; set; }
        [Column("Dueño_Edad")]
        public int Dueño_Edad { get; set; }
    }
}
