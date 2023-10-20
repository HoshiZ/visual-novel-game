using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGameDB.Entities
{
    [Table("BGM")]
    public class Bgm
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("bgm_path")]
        public string? BgmPath { get; set;}
    }
}
