using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGameDB.Models
{
    public class GameDataModels
    {
        public IEnumerable<string?> Scene { get; set; }
        public IEnumerable<string?> Audio { get; set; }
        public IEnumerable<bool?> IsChoicePoint { get; set; }
        public IEnumerable<IEnumerable<string?>> ChoiceOption { get; set; }
        public IEnumerable<bool?> IsBGMChange { get; set; }
        public IEnumerable<int?> BGM { get; set; }
        public IEnumerable<string?> CharacterName { get; set; }
        public IEnumerable<IEnumerable<string?>> CharacterImages { get; set; }
        public IEnumerable<string?> Text { get; set; }
        public IEnumerable<bool?> HaveRead { get; set; }
        public IEnumerable<string?> Chapter { get; set; }
        public IEnumerable<string?> CharacterAvatar { get; set; }
    }

    public class GameDataModel
    {
        public string? Scene { get; set; }
        public string? Audio { get; set; }
        public bool IsChoicePoint { get; set; }
        public IEnumerable<string?> ChoiceOption { get; set; }
        public bool? IsBGMChange { get; set; }
        public int? BGM { get; set; }
        public string? CharacterName { get; set; }
        public IEnumerable<string?> CharacterImages { get; set; }
        public string? CharacterAvatar { get; set; }
        public string? Text { get; set; }
        public bool? HaveRead { get; set; }
        public string? Chapter { get; set; }
    }
}
