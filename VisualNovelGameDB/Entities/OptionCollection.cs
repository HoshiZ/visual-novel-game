using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGameDB.Entities
{
    [Table("OPTIONCOLLECTION")]
    public class OptionCollection
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }



        public virtual ICollection<ChoiceOption>? ChoiceOptions { get; set; }
    }
}
