using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Server.Models
{
    [Table("Avion")]

    public class Avion
    {
        [Key]
        [Column("ID")]

        public int ID{get; set;}

        [Column("Naziv")]
        [MaxLength(255)]

        public string Naziv {get; set;}

        [Column("Kapacitet")]

        public int Kapacitet { get; set; }

        [Column("X")]

        public int X { get; set; }

        [Column("Y")]

        public int Y { get; set; }

        public virtual List<Lokacija> Lokacije { get; set; }
    }
}