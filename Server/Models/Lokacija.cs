using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Server.Models
{
    [Table("Lokacija")]
    public class Lokacija
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Tip")]
        [MaxLength(255)]
        public string Tip { get; set; }

        [Column("Kapacitet")]
        public int Kapacitet { get; set; }

        [Column("MaxKapacitet")]
        public int MaxKapacitet { get; set; }

        [Column("Boja")]
        [MaxLength(255)]
        public string Boja { get; set; }

        [Column("N")]
        public int N { get; set; }

        [Column("M")]
        public int M { get; set; }

        [JsonIgnore]
        public Avion Avion {get; set;}
    }
}