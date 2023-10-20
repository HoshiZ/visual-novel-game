using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGameDB.Entities
{
    [Table("MAINLINETEXT")]
    public class MainlineText
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("cn_text")]
        public string? CNText { get; set; }

        [Column("en_text")]
        public string? ENText { get; set; }

        [Column("jp_text")]
        public string? JPText { get; set; }
    }
}
