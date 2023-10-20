using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGameDB.Entities
{
    [Table("CHARACTER")]
    public class Character
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("cn_name")]
        public string? CNName { get; set; }

        [Column("en_name")]
        public string? ENName { get; set; }

        [Column("jp_name")]
        public string? JPName { get; set; }
    }
}
