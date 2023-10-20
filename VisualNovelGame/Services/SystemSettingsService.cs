using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SystemSettingsModel;
using VisualNovelGame.Events.EventArgs;
using VisualNovelGame.Services.Interfaces;

namespace VisualNovelGame.Services
{
    public class SystemSettingsService : ISystemSettingsService
    {
        private readonly string _filePath = "Settings/SystemSettings.json";
        private RootEntity _systemSettings;

        public SystemSettingsService() 
        {
            string systemJson = File.ReadAllText(_filePath);
            var root = JsonConvert.DeserializeObject<RootEntity>(systemJson);
            _systemSettings = root;
        }

        public bool GetAspectRatio()
        {
            throw new NotImplementedException();
        }

        public RootEntity GetSystemSettings()
        {
            return _systemSettings;

            //string systemJson = File.ReadAllText(_filePath);
            //_systemSettings = JsonConvert.DeserializeObject<dynamic>(systemJson);
            //return JsonConvert.DeserializeObject<dynamic>(systemJson);
        }

        public bool GetWindowType()
        {
            return _systemSettings.SystemSetting.Display.WindowType;
        }

        public bool SaveAspectRatio()
        {
            throw new NotImplementedException();
        }

        public void SaveAspectRatio(bool flag)
        {
            _systemSettings.SystemSetting.Display.AspectRatio = flag;
            SaveSystemSettings();
        }

        public void SaveSystemSettings()
        {
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(_systemSettings, Formatting.Indented));
        }

        //public WindowSizeArgs GetWindowSizeFromSystemSettings()
        //{
        //    WindowSizeArgs windowSizeArgs = new WindowSizeArgs();
        //    string json = File.ReadAllText(_filePath);
        //    dynamic jsonObj = JsonConvert.DeserializeObject(json);
        //    windowSizeArgs.IsMaxSize = jsonObj["System"]["ScreenSize"]["IsFullScreen"];
        //    windowSizeArgs.Width = jsonObj["System"]["ScreenSize"]["Width"];
        //    windowSizeArgs.Height = jsonObj["System"]["ScreenSize"]["Height"];
        //    return windowSizeArgs;
        //}

        //public bool SetWindowSizeToSystemSettings(WindowSizeArgs windowSizeArgs)
        //{
        //    string json = File.ReadAllText(_filePath);
        //    dynamic jsonObj = JsonConvert.DeserializeObject(json);
        //    jsonObj["System"]["ScreenSize"]["IsFullScreen"] = windowSizeArgs.IsMaxSize;
        //    jsonObj["System"]["ScreenSize"]["Width"] = windowSizeArgs.Width;
        //    jsonObj["System"]["ScreenSize"]["Height"] = windowSizeArgs.Height;
        //    string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
        //    File.WriteAllText(_filePath, output);
        //    return true;
        //}
    }
}
