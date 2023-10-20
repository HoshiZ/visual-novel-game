using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGame.Events.EventArgs;

namespace VisualNovelGame.Services.Interfaces
{
    public interface IUserHabitService
    {
        WindowSizeArgs GetWindowSizeFromUserHabitSettings();
        bool SaveWindowSizeToUserHabitSettings(WindowSizeArgs args);
    }
}
