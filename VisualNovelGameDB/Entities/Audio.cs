using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGameDB.Entities
{
    [Table("AUDIO")]
    public class Audio
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("character_id")]
        public int? CharacterId { get; set; }

        [Column("audio_path")]
        public string? AudioPath { get; set; }
    }
}
