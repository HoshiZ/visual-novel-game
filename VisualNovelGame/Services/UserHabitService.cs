using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserHabitSettingsModel;
using VisualNovelGame.Events.EventArgs;
using VisualNovelGame.Services.Interfaces;

namespace VisualNovelGame.Services
{
    class UserHabitService : IUserHabitService
    {
        private readonly string _filePath = "Settings/UserHabitSettings.json";
        private RootEntity _userHabit;

        public UserHabitService()
        {
            string userHabbitJson = File.ReadAllText(_filePath);
            var root = JsonConvert.DeserializeObject<RootEntity>(userHabbitJson);
            _userHabit = root;
        }

        public WindowSizeArgs GetWindowSizeFromUserHabitSettings()
        {
            bool isFullWindow = _userHabit.UserPreferences.WindowSize.IsFullWindow;
            double width = _userHabit.UserPreferences.WindowSize.Width;
            double height = _userHabit.UserPreferences.WindowSize.Height;
            WindowSizeArgs windowSizeArgs = new WindowSizeArgs { IsFullWindow = isFullWindow, Width = width, Height = height};
            return windowSizeArgs;

            //dynamic json = GetUserHabbitSettings();
            //int width = json.UserPreferences.WindowSize.Width;
            //int height = json.UserPreferences.WindowSize.Height;
            //bool isFullWindow = json.UserPreferences.WindowSize.IsFullWindow;
            //return new WindowSizeArgs { IsMaxSize = isFullWindow, Width = width, Height = height };
        }

        public bool SaveWindowSizeToUserHabitSettings(WindowSizeArgs args)
        {
            _userHabit.UserPreferences.WindowSize.IsFullWindow = args.IsFullWindow;
            _userHabit.UserPreferences.WindowSize.Height = args.Height;
            _userHabit.UserPreferences.WindowSize.IsFullWindow = args.IsFullWindow;
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(_userHabit, Formatting.Indented));
            return true;

            //dynamic json = GetUserHabbitSettings();
            //json.UserPreferences.WindowSize.Height = args.Height;
            //json.UserPreferences.WindowSize.Width = args.Width;
            //json.UserPreferences.WindowSize.IsFullWindow = args.IsFullWindow;
            //SaveUserHabbitSettings(json);
            //return true;
        }

        public dynamic GetUserHabbitSettings()
        {
            string userHabbitJson = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<dynamic>(userHabbitJson);
        }

        public bool SaveUserHabbitSettings(dynamic json)
        {
            string jsonData = JsonConvert.SerializeObject(json);
            File.WriteAllText(_filePath, jsonData);
            return true;
        }
    }
}
