using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SystemSettingsModel;
using VisualNovelGame.ViewModels.SystemControlViewModel.ItemViewModels;

namespace VisualNovelGame.ViewModels.SystemControlViewModel
{
    public class General1ViewModel
    {

        // 构造函数
        public General1ViewModel() 
        {
            AutoSkipOrjumpOverReadTextRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "自动跳过已读文本" };
            AutoSkipOrjumpOverReadTextRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = AutoSkipOrjumpOverReadTextCommand, CommandParameter = "ON", GroupName = "AutoSkipOrjumpOverReadText", IsChecked = false });
            AutoSkipOrjumpOverReadTextRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = AutoSkipOrjumpOverReadTextCommand, CommandParameter = "OFF", GroupName = "AutoSkipOrjumpOverReadText", IsChecked = false });

            AutoSkipOrjumpSettingRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "已读文本自动跳过方式"};
            AutoSkipOrjumpSettingRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "快进", DelegateCommand = AutoSkipOrjumpSettingCommand, CommandParameter = "ON", GroupName = "AutoSkipOrjumpSetting", IsChecked = false });
            AutoSkipOrjumpSettingRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "跳转", DelegateCommand = AutoSkipOrjumpSettingCommand, CommandParameter = "OFF", GroupName = "AutoSkipOrjumpSetting", IsChecked = false });

            AutoCursorRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "自动移动鼠标指针" };
            AutoCursorRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = AutoCursorCommand, CommandParameter = "ON", GroupName = "AutoCursorSetting", IsChecked = false });
            AutoCursorRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = AutoCursorCommand, CommandParameter = "OFF", GroupName = "AutoCursorSetting", IsChecked = false });

            AutoCursorDefaultOptionRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "鼠标指针自动移动时指向的按键" };
            AutoCursorDefaultOptionRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "启动", DelegateCommand = AutoCursorDefaultOptionCommand, CommandParameter = "ON", GroupName = "AutoCursorDefaultOption", IsChecked = false });
            AutoCursorDefaultOptionRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "关闭", DelegateCommand = AutoCursorDefaultOptionCommand, CommandParameter = "OFF", GroupName = "AutoCursorDefaultOption", IsChecked = false });

            HideMouseCursorRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "自动隐藏鼠标指针" };
            HideMouseCursorRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "不隐藏", DelegateCommand = HideMouseCursorCommand, CommandParameter = "ON", GroupName = "HideMouseCursor", IsChecked = false });
            HideMouseCursorRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "5 秒", DelegateCommand = HideMouseCursorCommand, CommandParameter = "OFF", GroupName = "HideMouseCursor", IsChecked = false });
            HideMouseCursorRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "10 秒", DelegateCommand = HideMouseCursorCommand, CommandParameter = "OFF", GroupName = "HideMouseCursor", IsChecked = false });
            HideMouseCursorRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "15 秒", DelegateCommand = HideMouseCursorCommand, CommandParameter = "OFF", GroupName = "HideMouseCursor", IsChecked = false });

            SaveOrloadConfirmationRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "存档，读档时的鼠标操作" };
            SaveOrloadConfirmationRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "双击", DelegateCommand = SaveOrloadConfirmationCommand, CommandParameter = "ON", GroupName = "SaveOrloadConfirmation", IsChecked = false });
            SaveOrloadConfirmationRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "单击", DelegateCommand = SaveOrloadConfirmationCommand, CommandParameter = "OFF", GroupName = "SaveOrloadConfirmation", IsChecked = false });

            ShowUnreadScenesInFlowchartRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "流程图中显示未读章节" };
            ShowUnreadScenesInFlowchartRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = ShowUnreadScenesInFlowchartCommand, CommandParameter = "ON", GroupName = "ShowUnreadScenesInFlowchart", IsChecked = false });
            ShowUnreadScenesInFlowchartRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = ShowUnreadScenesInFlowchartCommand, CommandParameter = "OFF", GroupName = "ShowUnreadScenesInFlowchart", IsChecked = false });

            WhenWindowIsInactiveRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "久未操作时的游戏状态" };
            WhenWindowIsInactiveRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "停止", DelegateCommand = WhenWindowIsInactiveCommand, CommandParameter = "ON", GroupName = "WhenWindowIsInactive", IsChecked = false });
            WhenWindowIsInactiveRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "继续", DelegateCommand = WhenWindowIsInactiveCommand, CommandParameter = "OFF", GroupName = "WhenWindowIsInactive", IsChecked = false });

            TaskbarPreviewRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "预览功能" };
            TaskbarPreviewRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = TaskbarPreviewCommand, CommandParameter = "ON", GroupName = "TaskbarPreview", IsChecked = false });
            TaskbarPreviewRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = TaskbarPreviewCommand, CommandParameter = "OFF", GroupName = "TaskbarPreview", IsChecked = false });

            SuspendradioButtonsRadioButtons = new ItemForRadioButtonViewModel { ItemTitle = "自动继续游戏" };
            SuspendradioButtonsRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O N", DelegateCommand = SuspendradioButtonsCommand, CommandParameter = "ON", GroupName = "SuspendradioButtons", IsChecked = false });
            SuspendradioButtonsRadioButtons.RadioButtons.Add(new RadioButtonViewModel { Content = "O F F", DelegateCommand = SuspendradioButtonsCommand, CommandParameter = "OFF", GroupName = "SuspendradioButtons", IsChecked = false });

        }

        // 界面多选一项类
        public class ItemForRadioButtonViewModel
        {
            public string ItemTitle { get; set; }
            public ObservableCollection<RadioButtonViewModel> RadioButtons { get; set; } = new ObservableCollection<RadioButtonViewModel>();

        }


        //// 界面多选一按钮类
        //public class RadioButtonViewModel
        //{
        //    public string Content { get; set; }
        //    public DelegateCommand<object> DelegateCommand { get; set; }
        //    public string CommandParameter { get; set; }
        //    public bool IsChecked { get; set; }
        //    public string GroupName { get; set; }
        //}


        // 界面多选一项类的实例
        public ItemForRadioButtonViewModel AutoSkipOrjumpOverReadTextRadioButtons { get; set; }
        public ItemForRadioButtonViewModel AutoSkipOrjumpSettingRadioButtons { get; set; }
        public ItemForRadioButtonViewModel AutoCursorRadioButtons { get; set; }
        public ItemForRadioButtonViewModel AutoCursorDefaultOptionRadioButtons { get; set; }
        public ItemForRadioButtonViewModel HideMouseCursorRadioButtons { get; set; }
        public ItemForRadioButtonViewModel SaveOrloadConfirmationRadioButtons { get; set; }
        public ItemForRadioButtonViewModel ShowUnreadScenesInFlowchartRadioButtons { get; set; }
        public ItemForRadioButtonViewModel WhenWindowIsInactiveRadioButtons { get; set; }
        public ItemForRadioButtonViewModel TaskbarPreviewRadioButtons { get; set; }
        public ItemForRadioButtonViewModel SuspendradioButtonsRadioButtons { get; set; }


        // 界面实例按钮委托
        private DelegateCommand<object> _autoSkipOrjumpOverReadTextCommand;
        public DelegateCommand<object> AutoSkipOrjumpOverReadTextCommand =>
            _autoSkipOrjumpOverReadTextCommand ?? (_autoSkipOrjumpOverReadTextCommand = new DelegateCommand<object>(ExecuteAutoSkipOrjumpOverReadTextCommand));

        private void ExecuteAutoSkipOrjumpOverReadTextCommand(object obj)
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

        private DelegateCommand<object> _autoSkipOrjumpSettingCommand;
        public DelegateCommand<object> AutoSkipOrjumpSettingCommand =>
            _autoSkipOrjumpSettingCommand ?? (_autoSkipOrjumpSettingCommand = new DelegateCommand<object>(ExecuteAutoSkipOrjumpSettingCommand));

        private DelegateCommand<object> _autoCursorCommand;
        public DelegateCommand<object> AutoCursorCommand =>
            _autoCursorCommand ?? (_autoCursorCommand = new DelegateCommand<object>(ExecuteAutoCursorCommand));

        private void ExecuteAutoCursorCommand(object obj)
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

        private DelegateCommand<object> _autoCursorDefaultOptionCommand;
        public DelegateCommand<object> AutoCursorDefaultOptionCommand =>
            _autoCursorDefaultOptionCommand ?? (_autoCursorDefaultOptionCommand = new DelegateCommand<object>(ExecuteAutoCursorDefaultOptionCommand));

        private void ExecuteAutoCursorDefaultOptionCommand(object obj)
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

        private DelegateCommand<object> _hideMouseCursorCommand;
        public DelegateCommand<object> HideMouseCursorCommand =>
            _hideMouseCursorCommand ?? (_hideMouseCursorCommand = new DelegateCommand<object>(ExecuteHideMouseCursorCommand));

        private void ExecuteHideMouseCursorCommand(object obj)
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

        private DelegateCommand<object> _saveOrloadConfirmationCommand;
        public DelegateCommand<object> SaveOrloadConfirmationCommand =>
            _saveOrloadConfirmationCommand ?? (_saveOrloadConfirmationCommand = new DelegateCommand<object>(ExecuteSaveOrloadConfirmationCommand));

        private void ExecuteSaveOrloadConfirmationCommand(object obj)
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

        private DelegateCommand<object> _showUnreadScenesInFlowchartCommand;
        public DelegateCommand<object> ShowUnreadScenesInFlowchartCommand =>
            _showUnreadScenesInFlowchartCommand ?? (_showUnreadScenesInFlowchartCommand = new DelegateCommand<object>(ExecuteShowUnreadScenesInFlowchartCommand));

        private void ExecuteShowUnreadScenesInFlowchartCommand(object obj)
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

        private DelegateCommand<object> _whenWindowIsInactiveCommand;
        public DelegateCommand<object> WhenWindowIsInactiveCommand =>
            _whenWindowIsInactiveCommand ?? (_whenWindowIsInactiveCommand = new DelegateCommand<object>(ExecuteWhenWindowIsInactiveCommand));

        private void ExecuteWhenWindowIsInactiveCommand(object obj)
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

        private DelegateCommand<object> _taskbarPreviewCommand;
        public DelegateCommand<object> TaskbarPreviewCommand =>
            _taskbarPreviewCommand ?? (_taskbarPreviewCommand = new DelegateCommand<object>(ExecuteTaskbarPreviewCommand));

        private void ExecuteTaskbarPreviewCommand(object obj)
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

        private DelegateCommand<object> _suspendradioButtonsCommand;
        public DelegateCommand<object> SuspendradioButtonsCommand =>
            _suspendradioButtonsCommand ?? (_suspendradioButtonsCommand = new DelegateCommand<object>(ExecuteSuspendradioButtonsCommand));

        private void ExecuteSuspendradioButtonsCommand(object obj)
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

        private void ExecuteAutoSkipOrjumpSettingCommand(object obj)
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
