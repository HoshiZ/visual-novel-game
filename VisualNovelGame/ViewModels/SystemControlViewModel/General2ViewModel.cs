using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGame.ViewModels.SystemControlViewModel.ItemViewModels;

namespace VisualNovelGame.ViewModels.SystemControlViewModel
{
    public class General2ViewModel
    {
        // 构造函数
        public General2ViewModel() 
        {

            GameSpeedItem = new ItemForSliderDisplayViewModel { ItemTitle = "游戏进行速度"};
            GameSpeedItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = GameSpeedCommand });

            VoicePlaybackItem = new ItemForSliderDisplayViewModel { ItemTitle = "语音播放速度" };
            VoicePlaybackItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = VoicePlaybackCommand });

            SkipSpeedItem = new ItemForSliderDisplayViewModel { ItemTitle = "快进速度调整" };
            SkipSpeedItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = SkipSpeedCommand });

            SkipStyleItem = new ItemForRadioButtonViewModel { ItemTitle = "快进方式" };
            SkipStyleItem.RadioButtons.Add(new RadioButtonViewModel { Content = "普通", DelegateCommand = SkipStyleCommand, CommandParameter = "Normal", GroupName = "SkipStyleItem", IsChecked = true });
            SkipStyleItem.RadioButtons.Add(new RadioButtonViewModel { Content = "快速", DelegateCommand = SkipStyleCommand, CommandParameter = "Fast", GroupName = "SkipStyleItem", IsChecked = false });
            SkipStyleItem.RadioButtons.Add(new RadioButtonViewModel { Content = "纯文字", DelegateCommand = SkipStyleCommand, CommandParameter = "Text", GroupName = "SkipStyleItem", IsChecked = false });

            RightClickSkipsMoviesItem = new ItemForRadioButtonViewModel { ItemTitle = "右键跳过动画" };
            RightClickSkipsMoviesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SkipStyleCommand, CommandParameter = "ON", GroupName = "RightClickSkipsMoviesItem", IsChecked = true });
            RightClickSkipsMoviesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SkipStyleCommand, CommandParameter = "OFF", GroupName = "RightClickSkipsMoviesItem", IsChecked = false });

            SkipMoviesDuringSkipModeItem = new ItemForRadioButtonViewModel { ItemTitle = "快进时跳过动画" };
            SkipMoviesDuringSkipModeItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N ", DelegateCommand = SkipStyleCommand, CommandParameter = "ON", GroupName = "SkipMoviesDuringSkipModeItem", IsChecked = true });
            SkipMoviesDuringSkipModeItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SkipStyleCommand, CommandParameter = "OFF", GroupName = "SkipMoviesDuringSkipModeItem", IsChecked = false });

            VoicedLinesItem = new ItemForRadioButtonViewModel { ItemTitle = "有语音台词（主人公以外）" };
            VoicedLinesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "显示", DelegateCommand = SkipStyleCommand, CommandParameter = "AlwaysShow", GroupName = "VoicedLinesItem", IsChecked = true });
            VoicedLinesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "自动模式时不显示", DelegateCommand = SkipStyleCommand, CommandParameter = "HideInAuto_mode", GroupName = "VoicedLinesItem", IsChecked = false });
            VoicedLinesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "不显示", DelegateCommand = SkipStyleCommand, CommandParameter = "AlwaysHide", GroupName = "VoicedLinesItem", IsChecked = false });

            ProtagonistsLinesItem = new ItemForRadioButtonViewModel { ItemTitle = "无语音台词（主人公以外）" };
            ProtagonistsLinesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "显示", DelegateCommand = SkipStyleCommand, CommandParameter = "AlwaysShow", GroupName = "ProtagonistsLinesItem", IsChecked = true });
            ProtagonistsLinesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "自动模式时不显示", DelegateCommand = SkipStyleCommand, CommandParameter = "HideInAuto_mode", GroupName = "ProtagonistsLinesItem", IsChecked = false });
            ProtagonistsLinesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "不显示", DelegateCommand = SkipStyleCommand, CommandParameter = "AlwaysHide", GroupName = "ProtagonistsLinesItem", IsChecked = false });

            OtherLinesItem = new ItemForRadioButtonViewModel { ItemTitle = "其他文本" };
            OtherLinesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "显示", DelegateCommand = SkipStyleCommand, CommandParameter = "AlwaysShow", GroupName = "OtherLinesItem", IsChecked = true });
            OtherLinesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "自动模式时不显示", DelegateCommand = SkipStyleCommand, CommandParameter = "HideInAuto_mode", GroupName = "OtherLinesItem", IsChecked = false });
            OtherLinesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "不显示", DelegateCommand = SkipStyleCommand, CommandParameter = "AlwaysHide", GroupName = "OtherLinesItem", IsChecked = false });

            ScreenshotSettingsItem = new ItemForRadioButtonViewModel { ItemTitle = "截图保存设置" };
            ScreenshotSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = "以日期命名保存", DelegateCommand = SkipStyleCommand, CommandParameter = "DateOrTime", GroupName = "ScreenshotSettingsItem", IsChecked = true });
            ScreenshotSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = "每次保存时自定义命名", DelegateCommand = SkipStyleCommand, CommandParameter = "InputFileName", GroupName = "ScreenshotSettingsItem", IsChecked = false });
            // 详细设定
        }


        // 测试
        public ItemForSliderDisplayViewModel GameSpeedItem { get; set; }
        public ItemForSliderDisplayViewModel VoicePlaybackItem { get; set; }
        public ItemForSliderDisplayViewModel SkipSpeedItem { get; set; }
        public ItemForRadioButtonViewModel SkipStyleItem { get; set; }
        public ItemForRadioButtonViewModel RightClickSkipsMoviesItem { get; set; }
        public ItemForRadioButtonViewModel SkipMoviesDuringSkipModeItem { get; set; }
        public ItemForRadioButtonViewModel VoicedLinesItem { get; set; }
        public ItemForRadioButtonViewModel ProtagonistsLinesItem { get; set; }
        public ItemForRadioButtonViewModel OtherLinesItem { get; set; }
        public ItemForRadioButtonViewModel ScreenshotSettingsItem { get; set; }


        private DelegateCommand<object> _gameSpeedCommand;
        public DelegateCommand<object> GameSpeedCommand =>
            _gameSpeedCommand ?? (_gameSpeedCommand = new DelegateCommand<object>(ExecuteGameSpeedCommand));

        private void ExecuteGameSpeedCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _voicePlaybackCommand;
        public DelegateCommand<object> VoicePlaybackCommand =>
            _voicePlaybackCommand ?? (_voicePlaybackCommand = new DelegateCommand<object>(ExecuteVoicePlaybackCommand));

        private void ExecuteVoicePlaybackCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _skipSpeedCommand;
        public DelegateCommand<object> SkipSpeedCommand =>
            _skipSpeedCommand ?? (_skipSpeedCommand = new DelegateCommand<object>(ExecuteSkipSpeedCommand));

        private void ExecuteSkipSpeedCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _skipStyleCommand;
        public DelegateCommand<object> SkipStyleCommand =>
            _skipStyleCommand ?? (_skipStyleCommand = new DelegateCommand<object>(ExecuteSkipStyleCommand));

        private void ExecuteSkipStyleCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _rightClickSkipsMoviesCommand;
        public DelegateCommand<object> RightClickSkipsMoviesCommand =>
            _rightClickSkipsMoviesCommand ?? (_rightClickSkipsMoviesCommand = new DelegateCommand<object>(ExecuteRightClickSkipsMoviesCommand));

        private void ExecuteRightClickSkipsMoviesCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _skipMoviesDuringSkipModeCommand;
        public DelegateCommand<object> SkipMoviesDuringSkipModeCommand =>
            _skipMoviesDuringSkipModeCommand ?? (_skipMoviesDuringSkipModeCommand = new DelegateCommand<object>(ExecuteSkipMoviesDuringSkipModeCommand));

        private void ExecuteSkipMoviesDuringSkipModeCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _voicedLinesCommand;
        public DelegateCommand<object> VoicedLinesCommand =>
            _voicedLinesCommand ?? (_voicedLinesCommand = new DelegateCommand<object>(ExecuteVoicedLinesCommand));

        private void ExecuteVoicedLinesCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _protagonistsLinesCommand;
        public DelegateCommand<object> ProtagonistsLinesCommand =>
            _protagonistsLinesCommand ?? (_protagonistsLinesCommand = new DelegateCommand<object>(ExecuteProtagonistsLinesCommand));

        private void ExecuteProtagonistsLinesCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private DelegateCommand<object> _otherLinesCommand;
        public DelegateCommand<object> OtherLinesCommand =>
            _otherLinesCommand ?? (_otherLinesCommand = new DelegateCommand<object>(ExecuteOtherLinesCommand));

        private void ExecuteOtherLinesCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _screenshotSettingsCommand;
        public DelegateCommand<object> ScreenshotSettingsCommand =>
            _screenshotSettingsCommand ?? (_screenshotSettingsCommand = new DelegateCommand<object>(ExecuteScreenshotSettingsCommand));

        private void ExecuteScreenshotSettingsCommand(object obj)
        {
            throw new NotImplementedException();
        }

    }
}
