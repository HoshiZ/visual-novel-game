using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGame.ViewModels.SystemControlViewModel.ItemViewModels;

namespace VisualNovelGame.ViewModels.SystemControlViewModel
{
    public class TextViewModel
    {
        // 构造函数
        public TextViewModel()
        {

            // 测试
            TextSpeedItem = new ItemForSliderDisplayViewModel { ItemTitle = "文字显示速度" };
            TextSpeedItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = TextSpeedCommand });

            AutoModeSpeedItem = new ItemForSliderDisplayViewModel { ItemTitle = "自动模式速度" };
            AutoModeSpeedItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = AutoModeSpeedCommand });

            TimePerCharacterItem = new ItemForSliderDisplayViewModel { ItemTitle = "单个字符的等待时长" };
            TimePerCharacterItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = TimePerCharacterCommand });

            AutoModeTypeItem = new ItemForRadioButtonViewModel { ItemTitle = "自动模式类型" };
            AutoModeTypeItem.RadioButtons.Add(new RadioButtonViewModel { Content = "标准模式", DelegateCommand = AutoModeTypeCommand, CommandParameter = "Normal", GroupName = "AutoModeTypeItem", IsChecked = true });
            AutoModeTypeItem.RadioButtons.Add(new RadioButtonViewModel { Content = "语音模式", DelegateCommand = AutoModeTypeCommand, CommandParameter = "Voice", GroupName = "AutoModeTypeItem", IsChecked = false });
            AutoModeTypeItem.RadioButtons.Add(new RadioButtonViewModel { Content = "高速模式", DelegateCommand = AutoModeTypeCommand, CommandParameter = "Speed", GroupName = "AutoModeTypeItem", IsChecked = false });

            SkipUnreadTextItem = new ItemForRadioButtonViewModel { ItemTitle = "未读文本快进" };
            SkipUnreadTextItem.RadioButtons.Add(new RadioButtonViewModel { Content = "全部文本", DelegateCommand = SkipUnreadTextCommand, CommandParameter = "Everything", GroupName = "SkipUnreadTextItem", IsChecked = true });
            SkipUnreadTextItem.RadioButtons.Add(new RadioButtonViewModel { Content = "仅已读", DelegateCommand = SkipUnreadTextCommand, CommandParameter = "OnlyRead", GroupName = "SkipUnreadTextItem", IsChecked = false });

            CtrlSkipItem = new ItemForRadioButtonViewModel { ItemTitle = "Ctrl键快进方式" };
            CtrlSkipItem.RadioButtons.Add(new RadioButtonViewModel { Content = "全部文本", DelegateCommand = CtrlSkipCommand, CommandParameter = "Everything", GroupName = "CtrlSkipItem", IsChecked = true });
            CtrlSkipItem.RadioButtons.Add(new RadioButtonViewModel { Content = "仅已读", DelegateCommand = CtrlSkipCommand, CommandParameter = "OnlyRead", GroupName = "CtrlSkipItem", IsChecked = false });

            SkipModeAfterChoiceItem = new ItemForRadioButtonViewModel { ItemTitle = "选项过后是否接触快进" };
            SkipModeAfterChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = "不解除", DelegateCommand = SkipModeAfterChoiceCommand, CommandParameter = "Continue", GroupName = "SkipModeAfterChoiceItem", IsChecked = true });
            SkipModeAfterChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = "解除", DelegateCommand = SkipModeAfterChoiceCommand, CommandParameter = "Stop", GroupName = "SkipModeAfterChoiceItem", IsChecked = false });

            AutoModeAfterChoiceItem = new ItemForRadioButtonViewModel { ItemTitle = "选项过后是否解除自动模式" };
            AutoModeAfterChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = "不解除", DelegateCommand = AutoModeAfterChoiceCommand, CommandParameter = "Continue", GroupName = "AutoModeAfterChoiceItem", IsChecked = true });
            AutoModeAfterChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = "解除", DelegateCommand = AutoModeAfterChoiceCommand, CommandParameter = "Stop", GroupName = "AutoModeAfterChoiceItem", IsChecked = false });

            TextSettingsItem = new ItemForRadioButtonViewModel { ItemTitle = "窗口，文字设置" };
            TextSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = "通常时窗口", DelegateCommand = TextSettingsCommand, CommandParameter = "TextBox", GroupName = "TextSettingsItem", IsChecked = true });
            TextSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = "更改视点时窗口", DelegateCommand = TextSettingsCommand, CommandParameter = "OtherPOV", GroupName = "TextSettingsItem", IsChecked = false });
            TextSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = "未读文本", DelegateCommand = TextSettingsCommand, CommandParameter = "UnreadText", GroupName = "TextSettingsItem", IsChecked = false });
            TextSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = "已读文本", DelegateCommand = TextSettingsCommand, CommandParameter = "ReadText", GroupName = "TextSettingsItem", IsChecked = false });

            TextBoxOpacity = new ItemForSliderDisplayViewModel { ItemTitle = "对话框透明度" };
            TextBoxOpacity.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = TextBoxOpacityCommand });
        }

        public ItemForSliderDisplayViewModel TextSpeedItem { get; set; }
        public ItemForSliderDisplayViewModel AutoModeSpeedItem { get; set; }
        public ItemForSliderDisplayViewModel TimePerCharacterItem { get; set; }
        public ItemForRadioButtonViewModel AutoModeTypeItem { get; set; }
        public ItemForRadioButtonViewModel SkipUnreadTextItem { get; set; }
        public ItemForRadioButtonViewModel CtrlSkipItem { get; set; }
        public ItemForRadioButtonViewModel SkipModeAfterChoiceItem { get; set; }
        public ItemForRadioButtonViewModel AutoModeAfterChoiceItem { get; set; }
        public ItemForRadioButtonViewModel TextSettingsItem { get; set; }
        public ItemForSliderDisplayViewModel TextBoxOpacity { get; set; }


        private DelegateCommand<object> _textSpeedCommand;
        public DelegateCommand<object> TextSpeedCommand =>
            _textSpeedCommand ?? (_textSpeedCommand = new DelegateCommand<object>(ExecuteTextSpeedCommand));

        private void ExecuteTextSpeedCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _autoModeSpeedCommand;
        public DelegateCommand<object> AutoModeSpeedCommand =>
            _autoModeSpeedCommand ?? (_autoModeSpeedCommand = new DelegateCommand<object>(ExecuteAutoModeSpeedCommand));

        private void ExecuteAutoModeSpeedCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _timePerCharacterCommand;
        public DelegateCommand<object> TimePerCharacterCommand =>
            _timePerCharacterCommand ?? (_timePerCharacterCommand = new DelegateCommand<object>(ExecuteTimePerCharacterCommand));

        private void ExecuteTimePerCharacterCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _autoModeTypeCommand;
        public DelegateCommand<object> AutoModeTypeCommand =>
            _autoModeTypeCommand ?? (_autoModeTypeCommand = new DelegateCommand<object>(ExecuteAutoModeTypeCommand));

        private void ExecuteAutoModeTypeCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _skipUnreadTextCommand;
        public DelegateCommand<object> SkipUnreadTextCommand =>
            _skipUnreadTextCommand ?? (_skipUnreadTextCommand = new DelegateCommand<object>(ExecuteSkipUnreadTextCommand));

        private void ExecuteSkipUnreadTextCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _ctrlSkipCommand;
        public DelegateCommand<object> CtrlSkipCommand =>
            _ctrlSkipCommand ?? (_ctrlSkipCommand = new DelegateCommand<object>(ExecuteCtrlSkipCommand));

        private void ExecuteCtrlSkipCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _skipModeAfterChoiceCommand;
        public DelegateCommand<object> SkipModeAfterChoiceCommand =>
            _skipModeAfterChoiceCommand ?? (_skipModeAfterChoiceCommand = new DelegateCommand<object>(ExecuteSkipModeAfterChoiceCommand));

        private void ExecuteSkipModeAfterChoiceCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _autoModeAfterChoiceCommand;
        public DelegateCommand<object> AutoModeAfterChoiceCommand =>
            _autoModeAfterChoiceCommand ?? (_autoModeAfterChoiceCommand = new DelegateCommand<object>(ExecuteAutoModeAfterChoiceCommand));

        private void ExecuteAutoModeAfterChoiceCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private DelegateCommand<object> _textSettingsCommand;
        public DelegateCommand<object> TextSettingsCommand =>
            _textSettingsCommand ?? (_textSettingsCommand = new DelegateCommand<object>(ExecuteTextSettingsCommand));

        private void ExecuteTextSettingsCommand(object obj)
        {
            throw new NotImplementedException();
        }


        private DelegateCommand<object> _textBoxOpacityCommand;
        public DelegateCommand<object> TextBoxOpacityCommand =>
            _textBoxOpacityCommand ?? (_textBoxOpacityCommand = new DelegateCommand<object>(ExecuteTextBoxOpacityCommand));

        private void ExecuteTextBoxOpacityCommand(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
