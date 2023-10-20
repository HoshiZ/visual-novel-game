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
    [Table("MAINLINEDIALOGUE")]
    public class MainlineDialogue
    {
        [Key]
        [Column("id")]
        public int Id { get; set; } // 主键

        [Column("scene_id")]
        public int? SceneId { get; set; } // 外键，场景

        [Column("audio_path")]
        public string? AudioPath { get; set; } // 外键，语音

        [Column("is_choice_point", TypeName = "NUMBER(1)")] 
        public bool? IsChoicePoint { get; set; } // 是否是选择点

        [Column("choice_option_collection_id")]
        public int? ChoiceOptionCollectionId { get; set; } // 选择项id

        [Column("is_bgm_change", TypeName = "NUMBER(1)")]
        public bool? IsBgmChange { get; set; } // 是否改变背景音乐

        [Column("bgm_id")]
        public int? BgmId { get; set; } // 外键，改变的音乐

        [Column("character_id")]
        public int? CharacterId { get; set; } // 外键，文本说话角色

        [Column("mainline_text_id")]
        public int? MainlineTextId { get; set; } // 外键，对应的文本

        [Column("have_read", TypeName = "NUMBER(1)")]
        public bool? HaveRead { get; set; } // 是否已读

        [Column("chapter")]
        public string? Chapter { get; set; } // 章节



        [ForeignKey("SceneId")]
        public virtual Scene? Scene { get; set; }

        [ForeignKey("BgmId")]
        public virtual Bgm? Bgm { get; set; }

        [ForeignKey("ChoiceOptionCollectionId")]
        public virtual OptionCollection? OptionCollection { get; set; }

        [ForeignKey("AudioId")]
        public virtual Audio? Audio { get; set; }

        [ForeignKey("CharacterId")]
        public virtual Character? Character { get; set; }

        [ForeignKey("MainlineTextId")]
        public virtual MainlineText? MainlineText { get; set; }

        public virtual ICollection<MainlineDialogue_CharacterImage>? MainlineDialogue_CharacterImages { get; set; }
    }
}
