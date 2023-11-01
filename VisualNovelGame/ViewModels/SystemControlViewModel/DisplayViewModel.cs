using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGame.Services.Interfaces;
using VisualNovelGame.Services;
using System.Windows;
using VisualNovelGame.ViewModels.SystemControlViewModel.ItemViewModels;
using VisualNovelGame.Events;
using System.ComponentModel;
using Prism.Mvvm;

namespace VisualNovelGame.ViewModels.SystemControlViewModel
{
    public class DisplayViewModel : BindableBase
    {
        // 构造函数
        public DisplayViewModel(IEventAggregator eventAggregator, IWindowSizeService windowSizeService, ISystemSettingsService systemSettingsService, IUIStringsService uIStringsService)
        {
            // 依赖注入服务
            eventAggregator.GetEvent<LanguageChangedEvent>().Subscribe(UpdateStrings);
            _windowSizeService = windowSizeService;
            _systemSettingsService = systemSettingsService;
            _UIStringsService = uIStringsService; 

            InitialPageItems();
        }

        public void InitialPageItems()
        {
            WindowTypeButtons = new ItemForRadioButtonViewModel { ItemTitle = WindowType };
            WindowTypeButtons.RadioButtons.Add(new RadioButtonViewModel { Content = WindowType_A, DelegateCommand = WindowTypeCommand, CommandParameter = "Windowed", GroupName = "WindowType", IsChecked = false });
            WindowTypeButtons.RadioButtons.Add(new RadioButtonViewModel { Content = WindowType_B, DelegateCommand = WindowTypeCommand, CommandParameter = "FullScreen", GroupName = "WindowType", IsChecked = false });

            //AspectRatioButtons = new ItemForRadioButtonViewModel { ItemTitle = "画面比例" };
            //AspectRatioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "16 : 9", DelegateCommand = AspectRatioCommand, CommandParameter = "16_9", GroupName = "AspectRatio", IsChecked = false });
            //AspectRatioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "4 : 3", DelegateCommand = AspectRatioCommand, CommandParameter = "4_3", GroupName = "AspectRatio", IsChecked = false });

            VisualEffectsButtons = new ItemForRadioButtonViewModel { ItemTitle = VisualEffects };
            VisualEffectsButtons.RadioButtons.Add(new RadioButtonViewModel { Content = Button_ON, DelegateCommand = VisualEffectsCommand, CommandParameter = "ON", GroupName = "VisualEffects", IsChecked = false });
            VisualEffectsButtons.RadioButtons.Add(new RadioButtonViewModel { Content = Button_OFF, DelegateCommand = VisualEffectsCommand, CommandParameter = "OFF", GroupName = "VisualEffects", IsChecked = false });

            AnimationButtons = new ItemForRadioButtonViewModel { ItemTitle = Animation };
            AnimationButtons.RadioButtons.Add(new RadioButtonViewModel { Content = Button_ON, DelegateCommand = AnimationCommand, CommandParameter = "ON", GroupName = "Animation", IsChecked = false });
            AnimationButtons.RadioButtons.Add(new RadioButtonViewModel { Content = Button_OFF, DelegateCommand = AnimationCommand, CommandParameter = "OFF", GroupName = "Animation", IsChecked = false });

            ESCKeyFunctionButtons = new ItemForRadioButtonViewModel { ItemTitle = ESCKeyFunction };
            ESCKeyFunctionButtons.RadioButtons.Add(new RadioButtonViewModel { Content = ESCKeyFunction_A, DelegateCommand = ESCKeyFunctionCommand, CommandParameter = "RightClick", GroupName = "ESCKeyFunction", IsChecked = false });
            ESCKeyFunctionButtons.RadioButtons.Add(new RadioButtonViewModel { Content = ESCKeyFunction_B, DelegateCommand = ESCKeyFunctionCommand, CommandParameter = "PanicButton", GroupName = "ESCKeyFunction", IsChecked = false });

            PanicButtonButtons = new ItemForRadioButtonViewModel { ItemTitle = PanicButton };
            PanicButtonButtons.RadioButtons.Add(new RadioButtonViewModel { Content = PanicButton_A, DelegateCommand = PanicButtonCommand, CommandParameter = "Minimize", GroupName = "PanicButton", IsChecked = false });
            PanicButtonButtons.RadioButtons.Add(new RadioButtonViewModel { Content = PanicButton_B, DelegateCommand = PanicButtonCommand, CommandParameter = "Image1", GroupName = "PanicButton", IsChecked = false });
            //PanicButtonButtons.RadioButtons.Add(new RadioButtonViewModel { Content = PanicButton_C, DelegateCommand = PanicButtonCommand, CommandParameter = "Image2", GroupName = "PanicButton", IsChecked = false });
            //PanicButtonButtons.RadioButtons.Add(new RadioButtonViewModel { Content = PanicButton_D, DelegateCommand = PanicButtonCommand, CommandParameter = "CustomImage", GroupName = "PanicButton", IsChecked = false });

            AlwaysOnTopButtons = new ItemForRadioButtonViewModel { ItemTitle = AlwaysOnTop };
            AlwaysOnTopButtons.RadioButtons.Add(new RadioButtonViewModel { Content = Button_ON, DelegateCommand = AlwaysOnTopCommand, CommandParameter = "ON", GroupName = "AlwaysOnTop", IsChecked = false });
            AlwaysOnTopButtons.RadioButtons.Add(new RadioButtonViewModel { Content = Button_OFF, DelegateCommand = AlwaysOnTopCommand, CommandParameter = "OFF", GroupName = "AlwaysOnTop", IsChecked = false });

            //UIDisplayButton = new ItemForToggleButtonViewModel { ItemTitle = UIDisplay };
            //UIDisplayButton.ToggleButtons.Add(new ToggleButtonViewModel { Content = UIDisplay_A, DelegateCommand = UIDisplayCommand, CommandParameter = "ProgressIcon", IsChecked = false });
            //UIDisplayButton.ToggleButtons.Add(new ToggleButtonViewModel { Content = UIDisplay_B, DelegateCommand = UIDisplayCommand, CommandParameter = "ProgressMeter", IsChecked = false });
            //UIDisplayButton.ToggleButtons.Add(new ToggleButtonViewModel { Content = UIDisplay_C, DelegateCommand = UIDisplayCommand, CommandParameter = "WindowMenu", IsChecked = false });
            //UIDisplayButton.ToggleButtons.Add(new ToggleButtonViewModel { Content = UIDisplay_D, DelegateCommand = UIDisplayCommand, CommandParameter = "TouchUI", IsChecked = false });

            //ChapterDisplaySliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = ChapterDisplay };
            //ChapterDisplaySliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = ChapterDisplayCommand, ButtonCommand = null });

            //MusicTitleDisplaySliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = "背景音乐曲名显示时间" };
            //MusicTitleDisplaySliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = MusicTitleDisplayCommand, ButtonCommand = null });

            //CharacterPortraitsButtons = new ItemForRadioButtonViewModel { ItemTitle = "显示说话人表情" };
            //CharacterPortraitsButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = CharacterPortraitsCommand, CommandParameter = "ON", GroupName = "ShowPopUpWindow", IsChecked = false });
            //CharacterPortraitsButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = CharacterPortraitsCommand, CommandParameter = "OFF", GroupName = "ShowPopUpWindow", IsChecked = false });

            //ShowPopUpWindowButtons = new ItemForRadioButtonViewModel { ItemTitle = "显示弹窗" };
            //ShowPopUpWindowButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "鼠标悬停", DelegateCommand = ShowPopUpWindowCommand, CommandParameter = "ON", GroupName = "ShowPopUpWindow", IsChecked = false });
            //ShowPopUpWindowButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "右击", DelegateCommand = ShowPopUpWindowCommand, CommandParameter = "OFF", GroupName = "ShowPopUpWindow", IsChecked = false });
        }

        // 服务
        private readonly IWindowSizeService _windowSizeService;
        private readonly ISystemSettingsService _systemSettingsService;
        private readonly IUIStringsService _UIStringsService;

        public ItemForRadioButtonViewModel WindowTypeButtons { get; set; }
        public ItemForRadioButtonViewModel AspectRatioButtons { get; set; }
        public ItemForRadioButtonViewModel VisualEffectsButtons { get; set; }
        public ItemForRadioButtonViewModel AnimationButtons { get; set; }
        public ItemForRadioButtonViewModel ESCKeyFunctionButtons { get; set; }
        public ItemForRadioButtonViewModel PanicButtonButtons { get; set; }
        public ItemForRadioButtonViewModel AlwaysOnTopButtons { get; set; }
        public ItemForToggleButtonViewModel UIDisplayButton { get; set; }
        public ItemForSliderDisplayWithButtonViewModel ChapterDisplaySliderDisplayWithButton { get; set; }
        public ItemForSliderDisplayWithButtonViewModel MusicTitleDisplaySliderDisplayWithButton { get; set; }
        public ItemForRadioButtonViewModel CharacterPortraitsButtons { get; set; }
        public ItemForRadioButtonViewModel ShowPopUpWindowButtons { get; set; }


        // 界面项的命令的委托
        private DelegateCommand<object> _WindowTypeCommand;
        public DelegateCommand<object> WindowTypeCommand =>
            _WindowTypeCommand ?? (_WindowTypeCommand = new DelegateCommand<object>(ExecuteWindowTypeCommand));

        private void ExecuteWindowTypeCommand(object obj)
        {
            if (obj is string value)
            {
                if (value == "ON")
                {
                    MessageBox.Show("ON");
                }
                else if (value == "OFF")
                {
                    MessageBox.Show("OFF");
                }
            }
        }


        private DelegateCommand<object> _aspectRatioCommand;
        public DelegateCommand<object> AspectRatioCommand =>
            _aspectRatioCommand ?? (_aspectRatioCommand = new DelegateCommand<object>(ExecuteAspectRatioCommand));

        private void ExecuteAspectRatioCommand(object obj)
        {
            if (obj is string value)
            {
                if (value == "ON")
                {
                    MessageBox.Show("ON");
                }
                else if (value == "OFF")
                {
                    MessageBox.Show("OFF");
                }
            }
        }


        private DelegateCommand<object> _visualEffectsCommand;
        public DelegateCommand<object> VisualEffectsCommand =>
            _visualEffectsCommand ?? (_visualEffectsCommand = new DelegateCommand<object>(ExecuteVisualEffectsCommand));

        private void ExecuteVisualEffectsCommand(object obj)
        {
            if (obj is string value)
            {
                if (value == "ON")
                {
                    MessageBox.Show("ON");
                }
                else if (value == "OFF")
                {
                    MessageBox.Show("OFF");
                }
            }
        }

        private DelegateCommand<object> _animationCommand;

        public DelegateCommand<object> AnimationCommand =>
            _animationCommand ?? (_animationCommand = new DelegateCommand<object>(ExecuteAnimationCommand));

        private void ExecuteAnimationCommand(object obj)
        {
            if (obj is string value)
            {
                if (value == "ON")
                {
                    MessageBox.Show("ON");
                }
                else if (value == "OFF")
                {
                    MessageBox.Show("OFF");
                }
            }
        }


        private DelegateCommand<object> _eSCKeyFunctionCommand;
        public DelegateCommand<object> ESCKeyFunctionCommand =>
            _eSCKeyFunctionCommand ?? (_eSCKeyFunctionCommand = new DelegateCommand<object>(ExecuteESCKeyFunctionCommand));

        private void ExecuteESCKeyFunctionCommand(object obj)
        {
            if (obj is string value)
            {
                if (value == "ON")
                {
                    MessageBox.Show("ON");
                }
                else if (value == "OFF")
                {
                    MessageBox.Show("OFF");
                }
            }
        }

        private DelegateCommand<object> _panicButtonCommand;

        public DelegateCommand<object> PanicButtonCommand =>
            _panicButtonCommand ?? (_panicButtonCommand = new DelegateCommand<object>(ExecutePanicButtonCommand));

        private void ExecutePanicButtonCommand(object obj)
        {
            if (obj is string value)
            {
                if (value == "ON")
                {
                    MessageBox.Show("ON");
                }
                else if (value == "OFF")
                {
                    MessageBox.Show("OFF");
                }
            }
        }
        

        private DelegateCommand<object> _alwaysOnTopCommand;
        public DelegateCommand<object> AlwaysOnTopCommand =>
            _alwaysOnTopCommand ?? (_alwaysOnTopCommand = new DelegateCommand<object>(ExecuteAlwaysOnTopCommand));


        // UI
        private DelegateCommand<Tuple<bool, object>> _uIDisplayCommand;
        public DelegateCommand<Tuple<bool, object>> UIDisplayCommand =>
            _uIDisplayCommand ?? (_uIDisplayCommand = new DelegateCommand<Tuple<bool, object>>(ExecuteUIDisplayCommand));

        private void ExecuteUIDisplayCommand(Tuple<bool, object> parameters)
        {
            // 测试
            //string isChecked = parameters.Item1.ToString();   
            //string commandParameter = parameters.Item2.ToString();
            //MessageBox.Show(isChecked + " - " + commandParameter);
        }


        private DelegateCommand<object> _chapterDisplayCommand;
        public DelegateCommand<object> ChapterDisplayCommand =>
            _chapterDisplayCommand ?? (_chapterDisplayCommand = new DelegateCommand<object>(ExecuteChapterDisplayCommand));

        private void ExecuteChapterDisplayCommand(object obj)
        {

        }


        private DelegateCommand<object> _musicTitleDisplayCommand;
        public DelegateCommand<object> MusicTitleDisplayCommand =>
            _musicTitleDisplayCommand ?? (_musicTitleDisplayCommand = new DelegateCommand<object>(ExecuteMusicTitleDisplayCommand));

        private void ExecuteMusicTitleDisplayCommand(object obj)
        {

        }

        private void ExecuteAlwaysOnTopCommand(object obj)
        {
            if (obj is string value)
            {
                if (value == "ON")
                {
                    MessageBox.Show("ON");
                }
                else if (value == "OFF")
                {
                    MessageBox.Show("OFF");
                }
            }
        }


        private DelegateCommand<object> _characterPortraitsCommand;

        public DelegateCommand<object> CharacterPortraitsCommand =>
            _characterPortraitsCommand ?? (_characterPortraitsCommand = new DelegateCommand<object>(ExecuteCharacterPortraitsCommand));

        private void ExecuteCharacterPortraitsCommand(object obj)
        {
            if (obj is string value)
            {
                if (value == "ON")
                {
                    MessageBox.Show("ON");
                }
                else if (value == "OFF")
                {
                    MessageBox.Show("OFF");
                }
            }
        }


        private DelegateCommand<object> _showPopUpWindowCommand;
        public DelegateCommand<object> ShowPopUpWindowCommand =>
            _showPopUpWindowCommand ?? (_showPopUpWindowCommand = new DelegateCommand<object>(ExecuteShowPopUpWindowCommand));

        private void ExecuteShowPopUpWindowCommand(object obj)
        {
            if (obj is string value)
            {
                if (value == "ON")
                {
                    MessageBox.Show("ON");
                }
                else if (value == "OFF")
                {
                    MessageBox.Show("OFF");
                }
            }
        }


        public string WindowType => _UIStringsService.WindowType;
        public string WindowType_A => _UIStringsService.WindowSize_A;
        public string WindowType_B => _UIStringsService.WindowSize_B;
        public string VisualEffects => _UIStringsService.VisualEffects;
        public string Animation => _UIStringsService.Animation;
        public string ESCKeyFunction => _UIStringsService.ESCKeyFunction;
        public string PanicButton => _UIStringsService.PanicButton;
        public string AlwaysOnTop => _UIStringsService.AlwaysOnTop;
        public string UIDisplay => _UIStringsService.UIDisplay;
        public string ChapterDisplay => _UIStringsService.ChapterDisplay;
        public string Button_ON => _UIStringsService.Button_ON;
        public string Button_OFF => _UIStringsService.Button_OFF;
        public string ESCKeyFunction_A => _UIStringsService.ESCKeyFunction_A;
        public string ESCKeyFunction_B => _UIStringsService.ESCKeyFunction_B;
        public string PanicButton_A => _UIStringsService.PanicButton_A;
        public string PanicButton_B => _UIStringsService.PanicButton_B;
        public string PanicButton_C => _UIStringsService.PanicButton_C;
        public string PanicButton_D => _UIStringsService.PanicButton_D;
        public string UIDisplay_A => _UIStringsService.UIDisplay_A;
        public string UIDisplay_B => _UIStringsService.UIDisplay_B;
        public string UIDisplay_C => _UIStringsService.UIDisplay_C;
        public string UIDisplay_D => _UIStringsService.UIDisplay_D;

        public void UpdateStrings()
        {
            RaisePropertyChanged(WindowType);
            RaisePropertyChanged(VisualEffects);
            RaisePropertyChanged(Animation);
            RaisePropertyChanged(ESCKeyFunction);
            RaisePropertyChanged(PanicButton_A);
            RaisePropertyChanged(PanicButton_B);
            RaisePropertyChanged(PanicButton_C);
            RaisePropertyChanged(PanicButton_D);
            RaisePropertyChanged(PanicButton);
            RaisePropertyChanged(AlwaysOnTop);
            RaisePropertyChanged(UIDisplay);
            RaisePropertyChanged(ChapterDisplay);
            RaisePropertyChanged(Button_ON);
            RaisePropertyChanged(Button_OFF);
            RaisePropertyChanged(ESCKeyFunction_A);
            RaisePropertyChanged(ESCKeyFunction_B);
        }
    }
}
