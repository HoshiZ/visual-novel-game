using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VisualNovelGame.ViewModels.IndexControlViewModel;

namespace VisualNovelGame.Resources.Languages
{
    public static class LanguageExtensions
    {
        private static readonly Dictionary<LanguageState, string> LanguageCodes = new Dictionary<LanguageState, string>
            {
                { LanguageState.Chinese, "zh-CN" },
                { LanguageState.English, "en-US" },
                { LanguageState.Japanese, "ja-JP" }
            };

        public static string ToCode(this LanguageState languageState)
        {
            return LanguageCodes.TryGetValue(languageState, out string code) ? code : "Unknown";
        }
    }
}
