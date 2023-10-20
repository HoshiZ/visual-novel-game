using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGameDB.Entities;

namespace VisualNovelGameDB.Repositories.IRepositories
{
    public interface IVNGRepository
    {
        IEnumerable<MainlineDialogue> GetMainlineDialogues();

        IEnumerable<string?> GetAudioPathFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues);

        IEnumerable<int?> GetBGMPathFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues);

        IEnumerable<string?> GetChapterFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues);

        IEnumerable<IEnumerable<string?>> GetCharacterImagePathFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues);

        IEnumerable<string?> GetCharacterNameFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues, string language);

        IEnumerable<string?> GetTextFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues, string language);

        IEnumerable<string?> GetSceneFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues);

        IEnumerable<bool?> GetHaveReadFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues); 
    }
}
