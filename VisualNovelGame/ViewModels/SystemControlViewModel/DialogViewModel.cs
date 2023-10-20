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
    public class DialogViewModel
    {

        // 构造函数
        public DialogViewModel()
        {
            SavingItem = new ItemForRadioButtonViewModel { ItemTitle = "存档时是否显示" };
            SavingItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "Saving", IsChecked = true });
            SavingItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "Saving", IsChecked = false });

            OverwritingItem = new ItemForRadioButtonViewModel { ItemTitle = "覆盖存档时是否显示" };
            OverwritingItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "Overwriting", IsChecked = true });
            OverwritingItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "Overwriting", IsChecked = false });

            DirectSaveItem = new ItemForRadioButtonViewModel { ItemTitle = "直接存档功能是否显示" };
            DirectSaveItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "DirectSave", IsChecked = true });
            DirectSaveItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "DirectSave", IsChecked = false });

            LoadingItem = new ItemForRadioButtonViewModel { ItemTitle = "读档时是否显示" };
            LoadingItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "Loading", IsChecked = true });
            LoadingItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "Loading", IsChecked = false });

            QuicksavingItem = new ItemForRadioButtonViewModel { ItemTitle = "快速存档时是否显示" };
            QuicksavingItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "Quicksaving", IsChecked = true });
            QuicksavingItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "Quicksaving", IsChecked = false });

            QuickloadingItem = new ItemForRadioButtonViewModel { ItemTitle = "快速读档时是否确认" };
            QuickloadingItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "Quickloading", IsChecked = true });
            QuickloadingItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "Quickloading", IsChecked = false });

            ReturningToTitleItem = new ItemForRadioButtonViewModel { ItemTitle = "回到标题界面/中断回想时是否确认" };
            ReturningToTitleItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "ReturningToTitle", IsChecked = true });
            ReturningToTitleItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "ReturningToTitle", IsChecked = false });

            JumpingFromBacklogItem = new ItemForRadioButtonViewModel { ItemTitle = "在历史记录窗口跳转/进行语音回想时是否确认" };
            JumpingFromBacklogItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "JumpingFromBacklog", IsChecked = true });
            JumpingFromBacklogItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "JumpingFromBacklog", IsChecked = false });

            JumpingFromFlowchartItem = new ItemForRadioButtonViewModel { ItemTitle = "在流程图中跳转是否确认" };
            JumpingFromFlowchartItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "JumpingFromFlowchart", IsChecked = true });
            JumpingFromFlowchartItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "JumpingFromFlowchart", IsChecked = false });

            JumpingToTheNextChoiceItem = new ItemForRadioButtonViewModel { ItemTitle = "跳到下一个选项是否确认" };
            JumpingToTheNextChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "JumpingToTheNextChoice", IsChecked = true });
            JumpingToTheNextChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "JumpingToTheNextChoice", IsChecked = false });

            JumpingToThePreviousChoiceItem = new ItemForRadioButtonViewModel { ItemTitle = "跳到上一个选项时是否确认" };
            JumpingToThePreviousChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "JumpingToThePreviousChoice", IsChecked = true });
            JumpingToThePreviousChoiceItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "JumpingToThePreviousChoice", IsChecked = false });

            JumpingToTheNextSceneItem = new ItemForRadioButtonViewModel { ItemTitle = "跳到下一个场景时是否确认" };
            JumpingToTheNextSceneItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "JumpingToTheNextScene", IsChecked = true });
            JumpingToTheNextSceneItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "JumpingToTheNextScene", IsChecked = false });

            JumpingToThePreviousSceneItem = new ItemForRadioButtonViewModel { ItemTitle = "跳到上一个场景时是否确认" };
            JumpingToThePreviousSceneItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "JumpingToThePreviousScene", IsChecked = true });
            JumpingToThePreviousSceneItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "JumpingToThePreviousScene", IsChecked = false });

            FavoritingAVoiceLineItem = new ItemForRadioButtonViewModel { ItemTitle = "进行语音收藏时是否确认" };
            FavoritingAVoiceLineItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "FavoritingAVoiceLine", IsChecked = true });
            FavoritingAVoiceLineItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "FavoritingAVoiceLine", IsChecked = false });

            ResettingToDefaultSettingsItem = new ItemForRadioButtonViewModel { ItemTitle = "恢复系统默认设置时是否确认" };
            ResettingToDefaultSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "ResettingToDefaultSettings", IsChecked = true });
            ResettingToDefaultSettingsItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "ResettingToDefaultSettings", IsChecked = false });

            ResettingInSpriteModeItem = new ItemForRadioButtonViewModel { ItemTitle = "初始化立绘鉴赏模式时是否确认" };
            ResettingInSpriteModeItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "ResettingInSpriteMode", IsChecked = true });
            ResettingInSpriteModeItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "ResettingInSpriteMode", IsChecked = false });

            DeletingASaveItem = new ItemForRadioButtonViewModel { ItemTitle = "删除存档时是否确认" };
            DeletingASaveItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "DeletingASave", IsChecked = true });
            DeletingASaveItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "DeletingASave", IsChecked = false });

            MovingASaveItem = new ItemForRadioButtonViewModel { ItemTitle = "替换存档时是否确认" };
            MovingASaveItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "MovingASave", IsChecked = true });
            MovingASaveItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "MovingASave", IsChecked = false });

            CopyingASaveItem = new ItemForRadioButtonViewModel { ItemTitle = "复制存档时是否确认" };
            CopyingASaveItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "CopyingASave", IsChecked = true });
            CopyingASaveItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "CopyingASave", IsChecked = false });

            ClosingTheGameItem = new ItemForRadioButtonViewModel { ItemTitle = "结束游戏时是否确认" };
            ClosingTheGameItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "ClosingTheGame", IsChecked = true });
            ClosingTheGameItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "ClosingTheGame", IsChecked = false });

            SuspendingTheGameItem = new ItemForRadioButtonViewModel { ItemTitle = "自动继续游戏时是否确认" };
            SuspendingTheGameItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SavingCommand, CommandParameter = "ON", GroupName = "SuspendingTheGame", IsChecked = true });
            SuspendingTheGameItem.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SavingCommand, CommandParameter = "OFF", GroupName = "SuspendingTheGame", IsChecked = false });
        }

        // 测试
        public ItemForRadioButtonViewModel SavingItem { get; set; }
        public ItemForRadioButtonViewModel OverwritingItem { get; set; }
        public ItemForRadioButtonViewModel DirectSaveItem { get; set; }
        public ItemForRadioButtonViewModel LoadingItem { get; set; }
        public ItemForRadioButtonViewModel QuicksavingItem { get; set; }
        public ItemForRadioButtonViewModel QuickloadingItem { get; set; }
        public ItemForRadioButtonViewModel ReturningToTitleItem { get; set; }
        public ItemForRadioButtonViewModel JumpingFromBacklogItem { get; set; }
        public ItemForRadioButtonViewModel JumpingFromFlowchartItem { get; set; }
        public ItemForRadioButtonViewModel JumpingToTheNextChoiceItem { get; set; }
        public ItemForRadioButtonViewModel JumpingToThePreviousChoiceItem { get; set; }
        public ItemForRadioButtonViewModel JumpingToTheNextSceneItem { get; set; }
        public ItemForRadioButtonViewModel JumpingToThePreviousSceneItem { get; set; }
        public ItemForRadioButtonViewModel FavoritingAVoiceLineItem { get; set; }
        public ItemForRadioButtonViewModel ResettingToDefaultSettingsItem { get; set; }
        public ItemForRadioButtonViewModel ResettingInSpriteModeItem { get; set; }
        public ItemForRadioButtonViewModel DeletingASaveItem { get; set; }
        public ItemForRadioButtonViewModel MovingASaveItem { get; set; }
        public ItemForRadioButtonViewModel CopyingASaveItem { get; set; }
        public ItemForRadioButtonViewModel ClosingTheGameItem { get; set; }
        public ItemForRadioButtonViewModel SuspendingTheGameItem { get; set; }


        // 委托
        private DelegateCommand<object> _aLLCommand;
        public DelegateCommand<object> ALLCommand =>
            _aLLCommand ?? (_aLLCommand = new DelegateCommand<object>(ExecuteALLCommand));

        private void ExecuteALLCommand(object obj)
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

        private DelegateCommand<object> _savingCommand;
        public DelegateCommand<object> SavingCommand =>
            _savingCommand ?? (_savingCommand = new DelegateCommand<object>(ExecuteSavingCommand));

        private void ExecuteSavingCommand(object obj)
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


        private DelegateCommand<object> _overwritingCommand;
        public DelegateCommand<object> OverwritingCommand =>
            _overwritingCommand ?? (_overwritingCommand = new DelegateCommand<object>(ExecuteOverwritingCommand));

        private void ExecuteOverwritingCommand(object obj)
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


        private DelegateCommand<object> _directSaveCommand;
        public DelegateCommand<object> DirectSaveCommand =>
            _directSaveCommand ?? (_directSaveCommand = new DelegateCommand<object>(ExecuteDirectSaveCommand));

        private void ExecuteDirectSaveCommand(object obj)
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


        private DelegateCommand<object> _loadingCommand;
        public DelegateCommand<object> LoadingCommand =>
            _loadingCommand ?? (_loadingCommand = new DelegateCommand<object>(ExecuteLoadingCommand));

        private void ExecuteLoadingCommand(object obj)
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


        private DelegateCommand<object> _quicksavingCommand;
        public DelegateCommand<object> QuicksavingCommand =>
            _quicksavingCommand ?? (_quicksavingCommand = new DelegateCommand<object>(ExecuteQuicksavingCommand));

        private void ExecuteQuicksavingCommand(object obj)
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


        private DelegateCommand<object> _quickloadingCommand;
        public DelegateCommand<object> QuickloadingCommand =>
            _quickloadingCommand ?? (_quickloadingCommand = new DelegateCommand<object>(ExecuteQuickloadingCommand));

        private void ExecuteQuickloadingCommand(object obj)
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


        private DelegateCommand<object> _returningToTitleCommand;
        public DelegateCommand<object> ReturningToTitleCommand =>
            _returningToTitleCommand ?? (_returningToTitleCommand = new DelegateCommand<object>(ExecuteReturningToTitleCommand));

        private void ExecuteReturningToTitleCommand(object obj)
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


        private DelegateCommand<object> _jumpingFromBacklogCommand;
        public DelegateCommand<object> JumpingFromBacklogCommand =>
            _jumpingFromBacklogCommand ?? (_jumpingFromBacklogCommand = new DelegateCommand<object>(ExecuteJumpingFromBacklogCommand));

        private void ExecuteJumpingFromBacklogCommand(object obj)
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


        private DelegateCommand<object> _jumpingFromFlowchartCommand;
        public DelegateCommand<object> JumpingFromFlowchartCommand =>
            _jumpingFromFlowchartCommand ?? (_jumpingFromFlowchartCommand = new DelegateCommand<object>(ExecuteJumpingFromFlowchartCommand));

        private void ExecuteJumpingFromFlowchartCommand(object obj)
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


        private DelegateCommand<object> _jumpingToTheNextChoiceCommand;
        public DelegateCommand<object> JumpingToTheNextChoiceCommand =>
            _jumpingToTheNextChoiceCommand ?? (_jumpingToTheNextChoiceCommand = new DelegateCommand<object>(ExecuteJumpingToTheNextChoiceCommand));

        private void ExecuteJumpingToTheNextChoiceCommand(object obj)
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


        private DelegateCommand<object> _jumpingToThePreviousChoiceCommand;
        public DelegateCommand<object> JumpingToThePreviousChoiceCommand =>
            _jumpingToThePreviousChoiceCommand ?? (_jumpingToThePreviousChoiceCommand = new DelegateCommand<object>(ExecuteJumpingToThePreviousChoiceCommand));

        private void ExecuteJumpingToThePreviousChoiceCommand(object obj)
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


        private DelegateCommand<object> _jumpingToTheNextSceneCommand;
        public DelegateCommand<object> JumpingToTheNextSceneCommand =>
            _jumpingToTheNextSceneCommand ?? (_jumpingToTheNextSceneCommand = new DelegateCommand<object>(ExecuteJumpingToTheNextSceneCommand));

        private void ExecuteJumpingToTheNextSceneCommand(object obj)
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


        private DelegateCommand<object> _jumpingToThePreviousSceneCommand;
        public DelegateCommand<object> JumpingToThePreviousSceneCommand =>
            _jumpingToThePreviousSceneCommand ?? (_jumpingToThePreviousSceneCommand = new DelegateCommand<object>(ExecuteJumpingToThePreviousSceneCommand));

        private void ExecuteJumpingToThePreviousSceneCommand(object obj)
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


        private DelegateCommand<object> _favoritingAVoiceLineCommand;
        public DelegateCommand<object> FavoritingAVoiceLineCommand =>
            _favoritingAVoiceLineCommand ?? (_favoritingAVoiceLineCommand = new DelegateCommand<object>(ExecuteFavoritingAVoiceLineCommand));

        private void ExecuteFavoritingAVoiceLineCommand(object obj)
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


        private DelegateCommand<object> _resettingToDefaultSettingsCommand;
        public DelegateCommand<object> ResettingToDefaultSettingsCommand =>
            _resettingToDefaultSettingsCommand ?? (_resettingToDefaultSettingsCommand = new DelegateCommand<object>(ExecuteResettingToDefaultSettingsCommand));

        private void ExecuteResettingToDefaultSettingsCommand(object obj)
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


        private DelegateCommand<object> _resettingInSpriteModeCommand;
        public DelegateCommand<object> ResettingInSpriteModeCommand =>
            _resettingInSpriteModeCommand ?? (_resettingInSpriteModeCommand = new DelegateCommand<object>(ExecuteResettingInSpriteModeCommand));

        private void ExecuteResettingInSpriteModeCommand(object obj)
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


        private DelegateCommand<object> _deletingASaveCommand;
        public DelegateCommand<object> DeletingASaveCommand =>
            _deletingASaveCommand ?? (_deletingASaveCommand = new DelegateCommand<object>(ExecuteDeletingASaveCommand));

        private void ExecuteDeletingASaveCommand(object obj)
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


        private DelegateCommand<object> _movingASaveCommand;
        public DelegateCommand<object> MovingASaveCommand =>
            _movingASaveCommand ?? (_movingASaveCommand = new DelegateCommand<object>(ExecuteMovingASaveCommand));

        private void ExecuteMovingASaveCommand(object obj)
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


        private DelegateCommand<object> _copyingASaveCommand;
        public DelegateCommand<object> CopyingASaveCommand =>
            _copyingASaveCommand ?? (_copyingASaveCommand = new DelegateCommand<object>(ExecuteCopyingASaveCommand));

        private void ExecuteCopyingASaveCommand(object obj)
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


        private DelegateCommand<object> _closingTheGameCommand;
        public DelegateCommand<object> ClosingTheGameCommand =>
            _closingTheGameCommand ?? (_closingTheGameCommand = new DelegateCommand<object>(ExecuteClosingTheGameCommand));

        private void ExecuteClosingTheGameCommand(object obj)
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


        private DelegateCommand<object> _suspendingTheGameCommand;
        public DelegateCommand<object> SuspendingTheGameCommand =>
            _suspendingTheGameCommand ?? (_suspendingTheGameCommand = new DelegateCommand<object>(ExecuteSuspendingTheGameCommand));

        private void ExecuteSuspendingTheGameCommand(object obj)
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
