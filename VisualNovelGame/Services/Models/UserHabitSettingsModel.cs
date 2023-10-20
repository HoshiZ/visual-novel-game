using System;
using System.Text;
using Newtonsoft.Json;

namespace UserHabitSettingsModel
{
    public class RootEntity
    {
        [JsonProperty("UserPreferences")]
        public UserPreferencesEntity UserPreferences { get; set; }
        [JsonProperty("Another")]
        public AnotherEntity Another { get; set; }

    }

    public class UserPreferencesEntity
    {
        [JsonProperty("WindowSize")]
        public WindowSizeEntity WindowSize { get; set; }

    }

    public class WindowSizeEntity
    {
        [JsonProperty("Height")]
        public double Height { get; set; }
        [JsonProperty("Width")]
        public double Width { get; set; }
        [JsonProperty("IsFullWindow")]
        public bool IsFullWindow { get; set; }

    }

    public class AnotherEntity
    {

    }

}