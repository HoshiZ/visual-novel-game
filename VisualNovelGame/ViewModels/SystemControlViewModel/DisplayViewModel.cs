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

namespace VisualNovelGame.ViewModels.SystemControlViewModel
{
    public class DisplayViewModel
    {
        // 构造函数
        public DisplayViewModel(IEventAggregator eventAggregator, IWindowSizeService windowSizeService, ISystemSettingsService systemSettingsService)
        {
            // 依赖注入服务
            _eventAggregator = eventAggregator;
            _windowSizeService = windowSizeService;
            _systemSettingsService = systemSettingsService;


            WindowTypeButtons = new ItemForRadioButtonViewModel { ItemTitle = "显示模式" };
            WindowTypeButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "窗口", DelegateCommand = WindowTypeCommand, CommandParameter = "Windowed", GroupName = "WindowType", IsChecked = false });
            WindowTypeButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "全屏", DelegateCommand = WindowTypeCommand, CommandParameter = "FullScreen", GroupName = "WindowType", IsChecked = false });

            AspectRatioButtons = new ItemForRadioButtonViewModel { ItemTitle = "画面比例" };
            AspectRatioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "16 : 9", DelegateCommand = AspectRatioCommand, CommandParameter = "16_9", GroupName = "AspectRatio", IsChecked = false });
            AspectRatioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "4 : 3", DelegateCommand = AspectRatioCommand, CommandParameter = "4_3", GroupName = "AspectRatio", IsChecked = false });

            VisualEffectsButtons = new ItemForRadioButtonViewModel { ItemTitle = "画面效果" };
            VisualEffectsButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = VisualEffectsCommand, CommandParameter = "ON", GroupName = "VisualEffects", IsChecked = false });
            VisualEffectsButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = VisualEffectsCommand, CommandParameter = "OFF", GroupName = "VisualEffects", IsChecked = false });

            AnimationButtons = new ItemForRadioButtonViewModel { ItemTitle = "动画效果" };
            AnimationButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = AnimationCommand, CommandParameter = "ON", GroupName = "Animation", IsChecked = false });
            AnimationButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = AnimationCommand, CommandParameter = "OFF", GroupName = "Animation", IsChecked = false });

            ESCKeyFunctionButtons = new ItemForRadioButtonViewModel { ItemTitle = "ESC键位" };
            ESCKeyFunctionButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "右击", DelegateCommand = ESCKeyFunctionCommand, CommandParameter = "RightClick", GroupName = "ESCKeyFunction", IsChecked = false });
            ESCKeyFunctionButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "老板键功能", DelegateCommand = ESCKeyFunctionCommand, CommandParameter = "PanicButton", GroupName = "ESCKeyFunction", IsChecked = false });

            PanicButtonButtons = new ItemForRadioButtonViewModel { ItemTitle = "老板键功能" };
            PanicButtonButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "最小化", DelegateCommand = PanicButtonCommand, CommandParameter = "Minimize", GroupName = "PanicButton", IsChecked = false });
            PanicButtonButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "图像1", DelegateCommand = PanicButtonCommand, CommandParameter = "Image1", GroupName = "PanicButton", IsChecked = false });
            PanicButtonButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "图像2", DelegateCommand = PanicButtonCommand, CommandParameter = "Image2", GroupName = "PanicButton", IsChecked = false });
            PanicButtonButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "用户指定", DelegateCommand = PanicButtonCommand, CommandParameter = "CustomImage", GroupName = "PanicButton", IsChecked = false });

            AlwaysOnTopButtons = new ItemForRadioButtonViewModel { ItemTitle = "游戏窗口始终在前" };
            AlwaysOnTopButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = AlwaysOnTopCommand, CommandParameter = "ON", GroupName = "AlwaysOnTop", IsChecked = false });
            AlwaysOnTopButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = AlwaysOnTopCommand, CommandParameter = "OFF", GroupName = "AlwaysOnTop", IsChecked = false });

            UIDisplayButton = new ItemForToggleButtonViewModel { ItemTitle = "功能区域开关" };
            UIDisplayButton.ToggleButtons.Add(new ToggleButtonViewModel { Content = "状态图标", DelegateCommand = UIDisplayCommand, CommandParameter = "ProgressIcon", IsChecked = false});
            UIDisplayButton.ToggleButtons.Add(new ToggleButtonViewModel { Content = "进度条", DelegateCommand = UIDisplayCommand, CommandParameter = "ProgressMeter", IsChecked = false});
            UIDisplayButton.ToggleButtons.Add(new ToggleButtonViewModel { Content = "窗口菜单", DelegateCommand = UIDisplayCommand, CommandParameter = "WindowMenu", IsChecked = false});
            UIDisplayButton.ToggleButtons.Add(new ToggleButtonViewModel { Content = "触控按钮", DelegateCommand = UIDisplayCommand, CommandParameter = "TouchUI", IsChecked = false});

            ChapterDisplaySliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = "章节编号显示时间" };
            ChapterDisplaySliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = ChapterDisplayCommand, ButtonCommand = null });

            MusicTitleDisplaySliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = "背景音乐曲名显示时间" };
            MusicTitleDisplaySliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = MusicTitleDisplayCommand, ButtonCommand = null });

            CharacterPortraitsButtons = new ItemForRadioButtonViewModel { ItemTitle = "显示说话人表情" };
            CharacterPortraitsButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = CharacterPortraitsCommand, CommandParameter = "ON", GroupName = "ShowPopUpWindow", IsChecked = false });
            CharacterPortraitsButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = CharacterPortraitsCommand, CommandParameter = "OFF", GroupName = "ShowPopUpWindow", IsChecked = false });

            ShowPopUpWindowButtons = new ItemForRadioButtonViewModel { ItemTitle = "显示弹窗" };
            ShowPopUpWindowButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "鼠标悬停", DelegateCommand = ShowPopUpWindowCommand, CommandParameter = "ON", GroupName = "ShowPopUpWindow", IsChecked = false });
            ShowPopUpWindowButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "右击", DelegateCommand = ShowPopUpWindowCommand, CommandParameter = "OFF", GroupName = "ShowPopUpWindow", IsChecked = false });
        }

        // 服务
        private readonly IEventAggregator _eventAggregator;
        private readonly IWindowSizeService _windowSizeService;
        private readonly ISystemSettingsService _systemSettingsService;

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

    }
}
