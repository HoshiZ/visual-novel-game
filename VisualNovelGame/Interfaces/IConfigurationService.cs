using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGame.Events.EventArgs;

namespace VisualNovelGame.Interfaces
{
    public interface IConfigurationService
    {
        WindowSizeArgs LoadSettings(string filePath);
        void SaveSettings(string filePath);
    }
}
