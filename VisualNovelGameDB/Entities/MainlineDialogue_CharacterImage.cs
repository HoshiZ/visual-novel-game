using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGameDB.Entities
{
    [Table("MAINLINEDIALOGUE_CHARACTERIMAGE")]
    public class MainlineDialogue_CharacterImage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("mainline_dialogue_id")]
        public int MainlineDialogueId { get; set; }

        [Column("character_id")]
        public int? CharacterId { get; set; }

        [Column("character_path")]
        public string? CharacterPath { get; set; }



        [ForeignKey("MainlineDialogueId")]
        public virtual MainlineDialogue? MainlineDialogue { get; set; }
    }
}
