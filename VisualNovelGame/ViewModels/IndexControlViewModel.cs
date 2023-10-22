using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Globalization;
using System.Windows;
using VisualNovelGame.Resources.Languages;

namespace VisualNovelGame.ViewModels
{
    public class IndexControlViewModel : BindableBase
    {
        // 服务
        private readonly IRegionManager _regionManager;
        private LanguageState languageSettingState = (LanguageState)Properties.Settings.Default.CurrentLanguage;

        private DelegateCommand<string> _indexTogoCommand;
        public DelegateCommand<string> IndexTogoCommand =>
            _indexTogoCommand ?? (_indexTogoCommand = new DelegateCommand<string>(ExecuteIndexTogoCommand));

        // 构造函数
        public IndexControlViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            SwitchLanguageCommand = new DelegateCommand(switchLanguage);

            InitialPageLanguage();
        }

        public void InitialPageLanguage()
        {
            string code = languageSettingState.ToCode();
            Language.Strings.Culture = new CultureInfo(code);
            CurrentLanguage = languageSettingState;
            UpdateStrings();
        }

        // 首页按钮点击事件
        private void ExecuteIndexTogoCommand(string page)
        {
            if (page == "NewGame")
            {
                // 开始游戏
                // 使MainView清空所有视图并导航到GameView
                var parameters = new NavigationParameters();
                parameters.Add("ReturnRegion", "IndexViewRegion");
                parameters.Add("ReturnView", "IndexControl");
                _regionManager.RequestNavigate("MainViewRegion", "GameView", parameters);
            }
            else if (page == "Load")
            {

            }
            else if (page == "System")
            {
                // 系统
                // 使IndexView导航至SystemSettings
                var parameters = new NavigationParameters();
                parameters.Add("ReturnRegion", "IndexViewRegion");
                parameters.Add("ReturnView", "IndexControl");
                //_regionManager.RequestNavigate("IndexViewRegion", "SystemSettingsView", parameters);
                
            }
            else if (page == "Quit")
            {

            }
            else if (page == "Language")
            {
                CurrentLanguage = (LanguageState)(((int)CurrentLanguage + 1) % Enum.GetNames(typeof(LanguageState)).Length);
                UpdateStrings();
            }
        }


        // 首页ToggleButton三状态
        public enum LanguageState
        {
            Chinese,
            English,
            Japanese
        };
        
        public LanguageState CurrentLanguage
        {
            get { return languageSettingState; }
            set
            {
                if (languageSettingState != value)
                {
                    SetProperty(ref languageSettingState, value);
                    Properties.Settings.Default.CurrentLanguage = (int)CurrentLanguage;
                    Properties.Settings.Default.Save();
                    string code = CurrentLanguage.ToCode();
                    UpdateStrings();
                    Language.Strings.Culture = new CultureInfo(code);
                }
            }
        }

        public void UpdateStrings()
        {
            RaisePropertyChanged(nameof(NewGame));
            RaisePropertyChanged(nameof(LanguageChange));
            RaisePropertyChanged(nameof(Load));
            RaisePropertyChanged(nameof(System));
            RaisePropertyChanged(nameof(Quit));
        }

        public string NewGame => Language.Strings.NewGame;
        public string LanguageChange => Language.Strings.Language;
        public string Load => Language.Strings.Load;
        public string System => Language.Strings.System;
        public string Quit => Language.Strings.Quit;

        public DelegateCommand SwitchLanguageCommand { get; }
        private void switchLanguage()
        {
            CurrentLanguage = (LanguageState)(((int)CurrentLanguage + 1) % Enum.GetNames(typeof(LanguageState)).Length);
        }
    }
}
