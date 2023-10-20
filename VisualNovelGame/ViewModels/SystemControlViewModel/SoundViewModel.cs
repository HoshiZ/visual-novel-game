using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VisualNovelGame.ViewModels.SystemControlViewModel.ItemViewModels;

namespace VisualNovelGame.ViewModels.SystemControlViewModel
{
    public class SoundViewModel
    {
        // 构造函数
        public SoundViewModel()
        {

            MasterVolumeSliderDisplayItem = new ItemForSliderDisplayViewModel { ItemTitle = "主音量" };
            MasterVolumeSliderDisplayItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = MasterVolumnSliderCommand });

            BGMItem = new ItemForSliderDisplayViewModel { ItemTitle = "BGM" };
            BGMItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = BGMCommand });

            SFXItem = new ItemForSliderDisplayViewModel { ItemTitle = "SE（游戏音效）" };
            SFXItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = SFXCommand });

            SystemSFXItem = new ItemForSliderDisplayViewModel { ItemTitle = "SE（系统音效）" };
            SystemSFXItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = SystemSFXCommand });

            BGMDuringVoicePlaybackItem = new ItemForSliderDisplayViewModel { ItemTitle = "BGM（播放语音时）" };
            BGMDuringVoicePlaybackItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = BGMDuringVoicePlaybackCommand });

            MovieItem = new ItemForSliderDisplayViewModel { ItemTitle = "动画" };
            MovieItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = MovieCommand });

            SystemVoiceItem = new ItemForSliderDisplayViewModel { ItemTitle = "系统语音" };
            SystemVoiceItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = SystemVoiceCommand });

            SystemItem = new ItemForToggleButtonViewModel { ItemTitle = "系统音效选择" };
            SystemItem.ToggleButtons.Add(new ToggleButtonViewModel { Content = "音效", DelegateCommand = SystemCommand, CommandParameter = "SystemItem", IsChecked = true });
            SystemItem.ToggleButtons.Add(new ToggleButtonViewModel { Content = "角色语音", DelegateCommand = SystemCommand, CommandParameter = "SystemItem", IsChecked = true });

            VoiceItem = new ItemForSliderDisplayViewModel { ItemTitle = "游戏语音" };
            VoiceItem.SliderDisplay.Add(new SliderDisplayViewModel { CurrentValue = 30, Maximum = 100, Minimum = 0, Interval = 1, SliderCommand = VoiceCommand });

            CharacterVolumesItem = new ItemForRadioButtonViewModel { ItemTitle = "单独设置每个角色的语音" };
            CharacterVolumesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "礼堂顶针", DelegateCommand = CharacterVolumesCommand, CommandParameter = "LiTangDingZhen", GroupName = "CharacterVolumesItem", IsChecked = true });
            CharacterVolumesItem.RadioButtons.Add(new RadioButtonViewModel { Content = "墨茶", DelegateCommand = CharacterVolumesCommand, CommandParameter = "MoCha", GroupName = "CharacterVolumesItem", IsChecked = false });

            CutVoicePlaybackOnTextAdvanceItem = new ItemForRadioButtonViewModel { ItemTitle = "语音中断" };
            CutVoicePlaybackOnTextAdvanceItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = CutVoicePlaybackOnTextAdvanceCommand, CommandParameter = "ON", GroupName = "CutVoicePlaybackOnTextAdvanceItem", IsChecked = true });
            CutVoicePlaybackOnTextAdvanceItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = CutVoicePlaybackOnTextAdvanceCommand, CommandParameter = "OFF", GroupName = "CutVoicePlaybackOnTextAdvanceItem", IsChecked = false });
        }

        public ItemForSliderDisplayViewModel MasterVolumeSliderDisplayItem { get; set; }
        public ItemForSliderDisplayViewModel BGMItem { get; set; }
        public ItemForSliderDisplayViewModel SFXItem { get; set; }
        public ItemForSliderDisplayViewModel SystemSFXItem { get; set; }
        public ItemForSliderDisplayViewModel BGMDuringVoicePlaybackItem { get; set; }
        public ItemForSliderDisplayViewModel MovieItem { get; set; }
        public ItemForSliderDisplayViewModel SystemVoiceItem { get; set; }
        public ItemForToggleButtonViewModel SystemItem { get; set; }
        public ItemForSliderDisplayViewModel VoiceItem { get; set; }
        public ItemForRadioButtonViewModel CharacterVolumesItem { get; set; }
        public ItemForRadioButtonViewModel CutVoicePlaybackOnTextAdvanceItem { get; set; }


        private DelegateCommand<object> _masterVolumnSliderCommand;
        public DelegateCommand<object> MasterVolumnSliderCommand =>
            _masterVolumnSliderCommand ?? (_masterVolumnSliderCommand = new DelegateCommand<object>(ExecuteMasterVolumnSliderCommand));

        private void ExecuteMasterVolumnSliderCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }


        private DelegateCommand<object> _bGMCommand;
        public DelegateCommand<object> BGMCommand =>
            _bGMCommand ?? (_bGMCommand = new DelegateCommand<object>(ExecuteBGMCommand));

        private void ExecuteBGMCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }


        private DelegateCommand<object> _sFXCommand;
        public DelegateCommand<object> SFXCommand =>
            _sFXCommand ?? (_sFXCommand = new DelegateCommand<object>(ExecuteSFXCommand));

        private void ExecuteSFXCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }


        private DelegateCommand<object> _systemSFXCommand;
        public DelegateCommand<object> SystemSFXCommand =>
            _systemSFXCommand ?? (_systemSFXCommand = new DelegateCommand<object>(ExecuteSystemSFXCommand));

        private void ExecuteSystemSFXCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }


        private DelegateCommand<object> _bGMDuringVoicePlaybackCommand;
        public DelegateCommand<object> BGMDuringVoicePlaybackCommand =>
            _bGMDuringVoicePlaybackCommand ?? (_bGMDuringVoicePlaybackCommand = new DelegateCommand<object>(ExecuteBGMDuringVoicePlaybackCommand));

        private void ExecuteBGMDuringVoicePlaybackCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }


        private DelegateCommand<object> _movieCommand;
        public DelegateCommand<object> MovieCommand =>
            _movieCommand ?? (_movieCommand = new DelegateCommand<object>(ExecuteMovieCommand));

        private void ExecuteMovieCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }


        private DelegateCommand<object> _systemVoiceCommand;
        public DelegateCommand<object> SystemVoiceCommand =>
            _systemVoiceCommand ?? (_systemVoiceCommand = new DelegateCommand<object>(ExecuteSystemVoiceCommand));

        private void ExecuteSystemVoiceCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }


        private DelegateCommand<Tuple<bool, object>> _systemCommand;
        public DelegateCommand<Tuple<bool, object>> SystemCommand =>
            _systemCommand ?? (_systemCommand = new DelegateCommand<Tuple<bool, object>>(ExecuteSystemCommand));

        private void ExecuteSystemCommand(Tuple<bool, object> parameters)
        {
            // 测试
            //string isChecked = parameters.Item1.ToString();   
            //string commandParameter = parameters.Item2.ToString();
            //MessageBox.Show(isChecked + " - " + commandParameter);
        }


        private DelegateCommand<object> _voiceCommand;
        public DelegateCommand<object> VoiceCommand =>
            _voiceCommand ?? (_voiceCommand = new DelegateCommand<object>(ExecuteVoiceCommand));

        private void ExecuteVoiceCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }


        private DelegateCommand<object> _characterVolumesCommand;
        public DelegateCommand<object> CharacterVolumesCommand =>
            _characterVolumesCommand ?? (_characterVolumesCommand = new DelegateCommand<object>(ExecuteCharacterVolumesCommand));

        private void ExecuteCharacterVolumesCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }


        private DelegateCommand<object> _cutVoicePlaybackOnTextAdvanceCommand;
        public DelegateCommand<object> CutVoicePlaybackOnTextAdvanceCommand =>
            _cutVoicePlaybackOnTextAdvanceCommand ?? (_cutVoicePlaybackOnTextAdvanceCommand = new DelegateCommand<object>(ExecuteCutVoicePlaybackOnTextAdvanceCommand));

        private void ExecuteCutVoicePlaybackOnTextAdvanceCommand(object obj)
        {
            MessageBox.Show("MasterVolumnSliderCommand");
        }

    }
}
