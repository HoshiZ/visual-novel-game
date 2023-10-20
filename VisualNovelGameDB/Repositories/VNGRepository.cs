using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGameDB.Data;
using VisualNovelGameDB.Entities;
using VisualNovelGameDB.Repositories.IRepositories;

namespace VisualNovelGameDB.Repositories
{
    public class VNGRepository : IVNGRepository
    {
        private readonly VNGDBContext _context;
        public VNGRepository()
        {
            this._context = new VNGDBContext();
        }


        public IEnumerable<string?> GetAudioPathFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues)
        {
            //List<string> audioPaths = new List<string>();
            //foreach (var dialogue in mainlineDialogues)
            //{
            //    audioPaths.Add(dialogue.AudioPath);
            //}
            //return audioPaths;
            return mainlineDialogues.Select(dialogue => dialogue.AudioPath);
        }

        public IEnumerable<int?> GetBGMPathFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues)
        {
            return mainlineDialogues.Select(dialogue => dialogue.BgmId);
        }

        public IEnumerable<string?> GetChapterFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues)
        {
            return mainlineDialogues.Select(dialogue => dialogue.Chapter);
        }

        public IEnumerable<IEnumerable<string?>> GetCharacterImagePathFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues)
        {
            var dialogueIds = mainlineDialogues.Select(md => md.Id).ToList();

            var query = from md in _context.MainlineDialogues
                        join mc in _context.MainlineDialogues_CharacterImages
                        on md.Id equals mc.MainlineDialogueId into mcGroup
                        from submc in mcGroup.DefaultIfEmpty()
                        where dialogueIds.Contains(md.Id)
                        select new
                        {
                            md.Id,
                            CharacterPath = submc!.CharacterPath
                        };

            return query
                .GroupBy(x => x.Id)
                .Select(g => g.Select(item => item.CharacterPath).ToList() as IEnumerable<string>)
                .ToList();
        }

        public IEnumerable<string?> GetCharacterNameFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues, string language)
        {
            if (language == "cn")
            {
                var result = mainlineDialogues
                    .Join(_context.Characters,
                        md => md.CharacterId,
                        ch => ch.Id,
                        (md, ch) => new { md.Id, ch.CNName })
                    .OrderBy(item => item.Id)
                    .Select(item => item.CNName)
                    .ToList();
                return result!;
            }
            else if (language == "en")
            {
                var result = mainlineDialogues
                    .Join(_context.Characters,
                        md => md.CharacterId,
                        ch => ch.Id,
                        (md, ch) => new { md.Id, ch.ENName })
                    .OrderBy(item => item.Id)
                    .Select(item => item.ENName)
                    .ToList();
                return result!;
            }
            else if (language == "jp")
            {
                var result =  mainlineDialogues
                    .Join(_context.Characters,
                        md => md.CharacterId,
                        ch => ch.Id,
                        (md, ch) => new { md.Id, ch.JPName })
                    .OrderBy(item => item.Id)
                    .Select(item => item.JPName)
                    .ToList();
                return result!;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<bool?> GetHaveReadFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues)
        {
            return mainlineDialogues.Select(md => md.HaveRead).ToList();
        }

        public IEnumerable<MainlineDialogue> GetMainlineDialogues()
        {
            return _context.MainlineDialogues.ToList();
        }

        public IEnumerable<string?> GetSceneFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues)
        {
            var result = mainlineDialogues
                .Join(_context.Scenes,
                md => md.SceneId,
                s => s.Id,
                (md, s) => new { md.Id, s.ScenePath })
                .OrderBy(item => item.Id)
                .Select(item => item.ScenePath)
                .ToList();
            return result!;
        }

        public IEnumerable<string?> GetTextFromDialog(IEnumerable<MainlineDialogue> mainlineDialogues, string language)
        {
            if (language == "cn")
            {
                var result = mainlineDialogues
                    .Join(_context.MainlineTexts,
                    md => md.MainlineTextId,
                    mt => mt.Id,
                    (md, mt) => new {md.Id, mt.CNText})
                    .OrderBy(item => item.Id)
                    .Select(item => item.CNText)
                    .ToList();
                return result!;
            }
            else if (language == "en")
            {
                var result = mainlineDialogues
                    .Join(_context.MainlineTexts,
                    md => md.MainlineTextId,
                    mt => mt.Id,
                    (md, mt) => new { md.Id, mt.ENText })
                    .OrderBy(item => item.Id)
                    .Select(item => item.ENText)
                    .ToList();
                return result!;
            }
            else if (language == "jp")
            {
                var result = mainlineDialogues
                    .Join(_context.MainlineTexts,
                    md => md.MainlineTextId,
                    mt => mt.Id,
                    (md, mt) => new { md.Id, mt.JPText })
                    .OrderBy(item => item.Id)
                    .Select(item => item.JPText)
                    .ToList();
                return result!;
            }
            else
            {
                return null;
            }
        }
    }
}
