using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace S5_CodeFirstEFCore.Models
{
    [Table("SoccerPosition")]
    public class SoccerPosition
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Position")]

        public string Description { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Descripcion")]

        public string Code { get; set; }

        public virtual List<Player> Player { get; set; }
        




    }
}
