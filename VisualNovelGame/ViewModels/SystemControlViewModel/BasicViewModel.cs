    using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Windows;
using System.Windows.Media.Converters;
using VisualNovelGame.Events;
using VisualNovelGame.Services.Interfaces;
using VisualNovelGame.ViewModels.SystemControlViewModel.ItemViewModels;

namespace VisualNovelGame.ViewModels.SystemControlViewModel
{
    public class BasicViewModel : BindableBase
    {
        private readonly IUIStringsService _UIStringsService;


        // 构造函数
        public BasicViewModel(IUIStringsService uIStringsService, IEventAggregator eventAggregator)
        {
            _UIStringsService = uIStringsService;
            eventAggregator.GetEvent<LanguageChangedEvent>().Subscribe(UpdateStrings);

            InitialPageItem();
        }

        private void InitialPageItem()
        {
            TextSpeedSliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = TextSpeed };
            TextSpeedSliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = TextSpeedSliderCommand, ButtonCommand = null });

            AutoModeSpeedSliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = AutoModeSpeed };
            AutoModeSpeedSliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = AutoModeSpeedSliderCommand, ButtonCommand = null });

            MasterVolumeSliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = MasterVolumn };
            MasterVolumeSliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = MasterVolumnSliderCommand, ButtonCommand = MasterVolumnButtonCommand });

            BGMSliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = BGM };
            BGMSliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = BGMSliderCommand, ButtonCommand = BGMButtonCommand });

            SoundEffectsSliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = SoundEffects };
            SoundEffectsSliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = SoundEffectsSliderCommand, ButtonCommand = SoundEffectsButtonCommand });

            VoiceSliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = Voice };
            VoiceSliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = VoiceSliderCommand, ButtonCommand = VoiceButtonCommand });

            //MovieSliderDisplayWithButton = new ItemForSliderDisplayWithButtonViewModel { ItemTitle = "动画" };
            //MovieSliderDisplayWithButton.SliderDisplayWithButtons.Add(new SliderDisplayWithButtonViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = MovieSliderCommand, ButtonCommand = MovieButtonCommand });

            WindowSizeRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = WindowSize };
            WindowSizeRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = WindowSize_A, DelegateCommand = WindowSizeCommand, CommandParameter = "Windowed", GroupName = "WindowSize", IsChecked = false });
            WindowSizeRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = WindowSize_B, DelegateCommand = WindowSizeCommand, CommandParameter = "Fullscreen", GroupName = "WindowSize", IsChecked = false });

            //AspectRatioRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "画面比例" };
            //AspectRatioRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = AspectRatioCommand, CommandParameter = "ON", GroupName = "AspectRatio", IsChecked = false });
            //AspectRatioRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = AspectRatioCommand, CommandParameter = "OFF", GroupName = "AspectRatio", IsChecked = false });

            CtrlSkipRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = CtrlSkip };
            CtrlSkipRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = CtrlSkip_A, DelegateCommand = CtrlSkipCommand, CommandParameter = "OnlyRead", GroupName = "CtrlSkip", IsChecked = false });
            CtrlSkipRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = CtrlSkip_B, DelegateCommand = CtrlSkipCommand, CommandParameter = "Everything", GroupName = "CtrlSkip", IsChecked = false });
        }

        // 测试

        // 界面类  
        /// <summary>
        /// 界面滑动条带按钮项类
        /// </summary>
        public class ItemForSliderDisplayWithButtonViewModel
        {
            public string ItemTitle { get; set; }
            public ObservableCollection<SliderDisplayWithButtonViewModel> SliderDisplayWithButtons { get; set; } = new ObservableCollection<SliderDisplayWithButtonViewModel>();
        }

        public class ItemForRadioButtonViewModel
        {
            public string ItemTitle { get; set; }
            public ObservableCollection<RadioButtonViewModel> RadioButtons { get; set; } = new ObservableCollection<RadioButtonViewModel>();
        }

        // 界面项的实例
        public ItemForSliderDisplayWithButtonViewModel TextSpeedSliderDisplayWithButton { get; set; }
        public ItemForSliderDisplayWithButtonViewModel AutoModeSpeedSliderDisplayWithButton { get; set; }
        public ItemForSliderDisplayWithButtonViewModel MasterVolumeSliderDisplayWithButton { get; set; }
        public ItemForSliderDisplayWithButtonViewModel BGMSliderDisplayWithButton { get; set; }
        public ItemForSliderDisplayWithButtonViewModel SoundEffectsSliderDisplayWithButton { get; set; }
        public ItemForSliderDisplayWithButtonViewModel VoiceSliderDisplayWithButton { get; set; }
        public ItemForSliderDisplayWithButtonViewModel MovieSliderDisplayWithButton { get; set; }
        public ItemForRadioButtonViewModel WindowSizeRadioButtons { get; set; }
        public ItemForRadioButtonViewModel AspectRatioRadioButtons { get; set; }
        public ItemForRadioButtonViewModel CtrlSkipRadioButtons { get; set; }


        // 界面项的命令的委托
        private DelegateCommand<object> _textSpeedSliderCommand;
        public DelegateCommand<object> TextSpeedSliderCommand =>
            _textSpeedSliderCommand ?? (_textSpeedSliderCommand = new DelegateCommand<object>(ExecuteTextSpeedSliderCommand));

        private void ExecuteTextSpeedSliderCommand(object obj)
        {
            MessageBox.Show("ExecuteTextSpeedSliderCommand");
        }


        private DelegateCommand<object> _autoModeSpeedSliderCommand;
        public DelegateCommand<object> AutoModeSpeedSliderCommand =>
            _autoModeSpeedSliderCommand ?? (_autoModeSpeedSliderCommand = new DelegateCommand<object>(ExecuteAutoModeSpeedSliderCommand));

        private void ExecuteAutoModeSpeedSliderCommand(object obj)
        {
            MessageBox.Show("ExecuteAutoModeSpeedSliderCommand");
        }


        private DelegateCommand<object> _masterVolumnSliderCommand;
        public DelegateCommand<object> MasterVolumnSliderCommand =>
            _masterVolumnSliderCommand ?? (_masterVolumnSliderCommand = new DelegateCommand<object>(ExecuteMasterVolumnSliderCommand));

        private void ExecuteMasterVolumnSliderCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }

        private DelegateCommand<object> _masterVolumnButtonCommand;

        public DelegateCommand<object> MasterVolumnButtonCommand =>
            _masterVolumnButtonCommand ?? (_masterVolumnButtonCommand = new DelegateCommand<object>(ExecuteMasterVolumnButtonCommand));

        private void ExecuteMasterVolumnButtonCommand(object obj)
        {
            MessageBox.Show("MasterVolumnButtonCommand");
        }


        private DelegateCommand<object> _BGMSliderCommand;
        public DelegateCommand<object> BGMSliderCommand =>
            _BGMSliderCommand ?? (_BGMSliderCommand = new DelegateCommand<object>(ExecuteBGMSliderCommand));

        private void ExecuteBGMSliderCommand(object obj)
        {
            MessageBox.Show("BGMSliderCommand");
        }

        private DelegateCommand<object> _bGMButtonCommand;

        public DelegateCommand<object> BGMButtonCommand =>
            _bGMButtonCommand ?? (_bGMButtonCommand = new DelegateCommand<object>(ExecuteBGMButtonCommand));

        private void ExecuteBGMButtonCommand(object obj)
        {
            MessageBox.Show("ExecuteBGMButtonCommand");
        }


        private DelegateCommand<object> _soundEffectsSliderCommand;
        public DelegateCommand<object> SoundEffectsSliderCommand =>
            _soundEffectsSliderCommand ?? (_soundEffectsSliderCommand = new DelegateCommand<object>(ExecuteSoundEffectsSliderCommand));

        private void ExecuteSoundEffectsSliderCommand(object obj)
        {
            MessageBox.Show("ExecuteSoundEffectsSliderCommand");
        }

        private DelegateCommand<object> _soundEffectsButtonCommand;

        public DelegateCommand<object> SoundEffectsButtonCommand =>
            _soundEffectsButtonCommand ?? (_soundEffectsButtonCommand = new DelegateCommand<object>(ExecuteSoundEffectsButtonCommand));

        private void ExecuteSoundEffectsButtonCommand(object obj)
        {
            MessageBox.Show("ExecuteSoundEffectsButtonCommand");
        }


        private DelegateCommand<object> _voiceSliderCommand;
        public DelegateCommand<object> VoiceSliderCommand =>
            _voiceSliderCommand ?? (_voiceSliderCommand = new DelegateCommand<object>(ExecuteVoiceSliderCommand));

        private void ExecuteVoiceSliderCommand(object obj)
        {
            MessageBox.Show("ExecuteVoiceSliderCommand");
        }

        private DelegateCommand<object> _voiceButtonCommand;

        public DelegateCommand<object> VoiceButtonCommand =>
            _voiceButtonCommand ?? (_voiceButtonCommand = new DelegateCommand<object>(ExecuteVoiceButtonCommand));

        private void ExecuteVoiceButtonCommand(object obj)
        {
            MessageBox.Show("ExecuteVoiceButtonCommand");
        }


        private DelegateCommand<object> _movieSliderCommand;
        public DelegateCommand<object> MovieSliderCommand =>
            _movieSliderCommand ?? (_movieSliderCommand = new DelegateCommand<object>(ExecuteMovieSliderCommand));

        private void ExecuteMovieSliderCommand(object obj)
        {
            MessageBox.Show("ExecuteMovieSliderCommand");
        }

        private DelegateCommand<object> _movieButtonCommand;

        public DelegateCommand<object> MovieButtonCommand =>
            _movieButtonCommand ?? (_movieButtonCommand = new DelegateCommand<object>(ExecuteMovieButtonCommand));

        private void ExecuteMovieButtonCommand(object obj)
        {
            MessageBox.Show("ExecuteMovieButtonCommand");
        }


        private DelegateCommand<object> _windowSizeCommand;
        public DelegateCommand<object> WindowSizeCommand =>
            _windowSizeCommand ?? (_windowSizeCommand = new DelegateCommand<object>(ExecuteWindowSizeCommand));

        private void ExecuteWindowSizeCommand(object obj)
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


        private DelegateCommand<object> _ctrlSkipCommand;
        public DelegateCommand<object> CtrlSkipCommand =>
            _ctrlSkipCommand ?? (_ctrlSkipCommand = new DelegateCommand<object>(ExecuteCtrlSkipCommand));

        private void ExecuteCtrlSkipCommand(object obj)
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

        public string WindowSize => _UIStringsService.WindowSize;
        public string TextSpeed => _UIStringsService.TextSpeed;
        public string AutoModeSpeed => _UIStringsService.AutoModeSpeed;
        public string CtrlSkip => _UIStringsService.CtrlSkip;
        public string MasterVolumn => _UIStringsService.MasterVolumn;
        public string BGM => _UIStringsService.BGM;
        public string SoundEffects => _UIStringsService.SoundEffects;
        public string Voice => _UIStringsService.Voice;
        public string WindowSize_A => _UIStringsService.WindowSize_A;
        public string WindowSize_B => _UIStringsService.WindowSize_B;
        public string CtrlSkip_A => _UIStringsService.CtrlSkip_A;
        public string CtrlSkip_B => _UIStringsService.CtrlSkip_B;

        public void UpdateStrings()
        {
            RaisePropertyChanged(nameof(WindowSize));
            RaisePropertyChanged(nameof(TextSpeed));
            RaisePropertyChanged(nameof(AutoModeSpeed));
            RaisePropertyChanged(nameof(CtrlSkip));
            RaisePropertyChanged(nameof(MasterVolumn));
            RaisePropertyChanged(nameof(BGM));
            RaisePropertyChanged(nameof(SoundEffects));
            RaisePropertyChanged(nameof(Voice));
            RaisePropertyChanged(nameof(WindowSize_A));
            RaisePropertyChanged(nameof(WindowSize_B));
            RaisePropertyChanged(nameof(CtrlSkip_A));
            RaisePropertyChanged(nameof(CtrlSkip_B));
        }
    }
}
