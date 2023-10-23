using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGame.Events;
using VisualNovelGame.Services.Interfaces;
using VisualNovelGame.ViewModels.SystemControlViewModel.ItemViewModels;

namespace VisualNovelGame.ViewModels.SystemControlViewModel
{
    public class TextViewModel : BindableBase
    {
        // 构造函数
        public TextViewModel(IUIStringsService uIStringsService, IEventAggregator eventAggregator)
        {
            _UIStringsService = uIStringsService;
            eventAggregator.GetEvent<LanguageChangedEvent>().Subscribe(UpdateStrings);

            InitialPageItems();
        }

        private readonly IUIStringsService _UIStringsService;

        private void InitialPageItems()
        {
            TextSpeedItem = new ItemForSliderDisplayViewModel { ItemTitle = TextSpeed };
            TextSpeedItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = TextSpeedCommand });

            AutoModeSpeedItem = new ItemForSliderDisplayViewModel { ItemTitle = "自动模式速度" };
            AutoModeSpeedItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = AutoModeSpeedCommand });

            TimePerCharacterItem = new ItemForSliderDisplayViewModel { ItemTitle = "单个字符的等待时长" };
            TimePerCharacterItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = TimePerCharacterCommand });

            AutoModeTypeItem = new ItemForRadioButtonViewModel { ItemTitle = "自动模式类型" };
            AutoModeTypeItem.RadioButtons.Add(new RadioButtonViewModel { Content = "标准模式", DelegateCommand = AutoModeTypeCommand, CommandParameter = "Normal", GroupName = "AutoModeTypeItem", IsChecked = true });
            AutoModeTypeItem.RadioButtons.Add(new RadioButtonViewModel { Content = "语音模式", DelegateCommand = AutoModeTypeCommand, CommandParameter = "Voice", GroupName = "AutoModeTypeItem", IsChecked = false });
            AutoModeTypeItem.RadioButtons.Add(new RadioButtonViewModel { Content = "高速模式", DelegateCommand = AutoModeTypeCommand, CommandParameter = "Speed", GroupName = "AutoModeTypeItem", IsChecked = false });

            SkipUnreadTextItem = new ItemForRadioButtonViewModel { ItemTitle = SkipUnreadText };
            SkipUnreadTextItem.RadioButtons.Add(new RadioButtonViewModel { Content = SkipUnreadText_A, DelegateCommand = SkipUnreadTextCommand, CommandParameter = "Everything", GroupName = "SkipUnreadTextItem", IsChecked = true });
            SkipUnreadTextItem.RadioButtons.Add(new RadioButtonViewModel { Content = SkipUnreadText_B, DelegateCommand = SkipUnreadTextCommand, CommandParameter = "OnlyRead", GroupName = "SkipUnreadTextItem", IsChecked = false });

            CtrlSkipItem = new ItemForRadioButtonViewModel { ItemTitle = CtrlSkip };
            CtrlSkipItem.RadioButtons.Add(new RadioButtonViewModel { Content = CtrlSKip_A, DelegateCommand = CtrlSkipCommand, CommandParameter = "Everything", GroupName = "CtrlSkipItem", IsChecked = true });
            CtrlSkipItem.RadioButtons.Add(new RadioButtonViewModel { Content = CtrlSKip_B, DelegateCommand = CtrlSkipCommand, CommandParameter = "OnlyRead", GroupName = "CtrlSkipItem", IsChecked = false });

            SkipModeAfterChoiceItem = new ItemForRadioButtonViewModel { ItemTitle = SkipModeAfterChoice };
            SkipModeAfterChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = SkipModeAfterChoice_A, DelegateCommand = SkipModeAfterChoiceCommand, CommandParameter = "Continue", GroupName = "SkipModeAfterChoiceItem", IsChecked = true });
            SkipModeAfterChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = SkipModeAfterChoice_B, DelegateCommand = SkipModeAfterChoiceCommand, CommandParameter = "Stop", GroupName = "SkipModeAfterChoiceItem", IsChecked = false });

            AutoModeAfterChoiceItem = new ItemForRadioButtonViewModel { ItemTitle = AutoModeAfterChoice };
            AutoModeAfterChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = AutoModeAfterChoice_A, DelegateCommand = AutoModeAfterChoiceCommand, CommandParameter = "Continue", GroupName = "AutoModeAfterChoiceItem", IsChecked = true });
            AutoModeAfterChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = AutoModeAfterChoice_B, DelegateCommand = AutoModeAfterChoiceCommand, CommandParameter = "Stop", GroupName = "AutoModeAfterChoiceItem", IsChecked = false });

            TextSettingsItem = new ItemForRadioButtonViewModel { ItemTitle = TextSettings };
            TextSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = TextSettings_A, DelegateCommand = TextSettingsCommand, CommandParameter = "TextBox", GroupName = "TextSettingsItem", IsChecked = true });
            TextSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = TextSettings_B, DelegateCommand = TextSettingsCommand, CommandParameter = "OtherPOV", GroupName = "TextSettingsItem", IsChecked = false });
            TextSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = TextSettings_C, DelegateCommand = TextSettingsCommand, CommandParameter = "UnreadText", GroupName = "TextSettingsItem", IsChecked = false });
            TextSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = TextSettings_D, DelegateCommand = TextSettingsCommand, CommandParameter = "ReadText", GroupName = "TextSettingsItem", IsChecked = false });

            TextBoxOpacity = new ItemForSliderDisplayViewModel { ItemTitle = TextBoxOpacityMiaoMiaoMiao };
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


        public string TextSpeed => _UIStringsService.TextSpeed;
        public string SkipUnreadText => _UIStringsService.SkipUnreadText;
        public string CtrlSkip => _UIStringsService.CtrlSkip;
        public string SkipModeAfterChoice => _UIStringsService.SkipModeAfterChoice;
        public string AutoModeAfterChoice => _UIStringsService.AutoModeAfterChoice;
        public string TextSettings => _UIStringsService.TextSettings;
        public string Color => _UIStringsService.Color;
        public string TextBoxOpacityMiaoMiaoMiao => _UIStringsService.TextBoxOpacity;
        public string SkipUnreadText_A => _UIStringsService.SkipUnreadText_A;
        public string SkipUnreadText_B => _UIStringsService.SkipUnreadText_B;
        public string CtrlSKip_A => _UIStringsService.CtrlSkip_A;
        public string CtrlSKip_B => _UIStringsService.CtrlSkip_B;
        public string SkipModeAfterChoice_A => _UIStringsService.SkipModeAfterChoice_A;
        public string SkipModeAfterChoice_B => _UIStringsService.SkipModeAfterChoice_B;
        public string AutoModeAfterChoice_A => _UIStringsService.AutoModeAfterChoice_A;
        public string AutoModeAfterChoice_B => _UIStringsService.AutoModeAfterChoice_B;
        public string TextSettings_A => _UIStringsService.TextSettings_A;
        public string TextSettings_B => _UIStringsService.TextSettings_B;
        public string TextSettings_C => _UIStringsService.TextSettings_C;
        public string TextSettings_D => _UIStringsService.TextSettings_D;

        public void UpdateStrings()
        {
            RaisePropertyChanged(nameof(TextSpeed));
            RaisePropertyChanged(nameof(SkipUnreadText));
            RaisePropertyChanged(nameof(CtrlSkip));
            RaisePropertyChanged(nameof(SkipModeAfterChoice));
            RaisePropertyChanged(nameof(AutoModeAfterChoice));
            RaisePropertyChanged(nameof(TextSettings));
            RaisePropertyChanged(nameof(Color));
            RaisePropertyChanged(nameof(TextBoxOpacityMiaoMiaoMiao));
            RaisePropertyChanged(nameof(SkipUnreadText_A));
            RaisePropertyChanged(nameof(SkipUnreadText_B));
            RaisePropertyChanged(nameof(CtrlSKip_A));
            RaisePropertyChanged(nameof(CtrlSKip_B));
            RaisePropertyChanged(nameof(SkipModeAfterChoice_A));
            RaisePropertyChanged(nameof(SkipModeAfterChoice_B));
            RaisePropertyChanged(nameof(TextSettings_A));
            RaisePropertyChanged(nameof(TextSettings_B));
            RaisePropertyChanged(nameof(TextSettings_C));
            RaisePropertyChanged(nameof(TextSettings_D));
        }
    }
}
