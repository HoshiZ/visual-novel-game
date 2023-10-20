using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisualNovelGameDB.Entities
{
    [Table("SCENE")]
    public class Scene
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("path")]
        public string? ScenePath { get; set; }
    }
}
