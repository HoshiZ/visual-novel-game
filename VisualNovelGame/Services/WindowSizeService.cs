using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using VisualNovelGame.Events.EventArgs;
using VisualNovelGame.Interfaces;
using VisualNovelGame.Services.Interfaces;

namespace VisualNovelGame.Services
{
    public class WindowSizeService : IWindowSizeService
    {
        private readonly ISystemSettingsService _systemSettings;
        private readonly IUserHabitService _userHabitService;
        // 构造函数
        public WindowSizeService(ISystemSettingsService systemsettings, IUserHabitService userHabbitService)
        {
            _systemSettings = systemsettings;
            _userHabitService = userHabbitService;
        }

        public WindowSizeArgs GetWindowSizeFromSystemSettings()
        {
            return _userHabitService.GetWindowSizeFromUserHabitSettings();
        }

        public bool SaveWindowSizeToSystemSettings(WindowSizeArgs args)
        {
            bool isTrue = _userHabitService.SaveWindowSizeToUserHabitSettings(args);
            if (isTrue)
            {
                return true;
            }
            return false;
        }

        public void SetWindowSize(WindowSizeArgs args)
        {
            Application.Current.MainWindow.Width = args.Width;
            Application.Current.MainWindow.Height = args.Height;
            Application.Current.MainWindow.WindowState = WindowState.Normal;
        }
        public void SetWindowSizeMax()
        {
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }

    }
}
