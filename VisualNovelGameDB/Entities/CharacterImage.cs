using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGameDB.Entities
{
    [Table("CHARACTERIMAGE")]
    public class CharacterImage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("character_id")]
        public int? CharacterId { get; set; }

        [Column("vertical_painting")]
        public string? VerticalPainting { get; set; }

        [Column("path")]
        public string? Path { get; set; }
    }
}
