using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGameDB.Entities
{
    [Table("CHOICEOPTION")]
    public class ChoiceOption
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("option_collection_id")]
        public int? OptionCollectionId { get; set; }

        [Column("current_mainline_dialogue_id")]
        public int? CurrentMainlineDialogueId { get; set; }

        [Column("choice_cn_text")]
        public string? ChoiceCNText { get; set; }

        [Column("choice_en_text")]
        public string? ChoiceENText { get; set; }

        [Column("choice_jp_text")]
        public string? ChoiceJPText { get; set; }

        [Column("next_mainline_dialogue_id")]
        public int? NextMainlineDialogueId { get; set;}



        [ForeignKey("CurrentMainlineDialogueId")]
        public virtual MainlineDialogue? CurrentMainlineDialogue { get; set; }

        [ForeignKey("NextMainlineDialogueId")]
        public virtual MainlineDialogue? NextMainlineDialogue { get; set; }
    }
}
