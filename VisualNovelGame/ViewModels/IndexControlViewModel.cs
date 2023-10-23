using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Globalization;
using System.Windows;
using VisualNovelGame.Events;
using VisualNovelGame.Resources.Languages;
using VisualNovelGame.Services.Interfaces;

namespace VisualNovelGame.ViewModels
{
    public class IndexControlViewModel : BindableBase
    {
        // 服务
        private readonly IRegionManager _regionManager;
        private readonly IUIStringsService _UIStringsService;

        //private LanguageState languageSettingState = (LanguageState)Properties.Settings.Default.CurrentLanguage;

        private DelegateCommand<string> _indexTogoCommand;
        public DelegateCommand<string> IndexTogoCommand =>
            _indexTogoCommand ?? (_indexTogoCommand = new DelegateCommand<string>(ExecuteIndexTogoCommand));

        // 构造函数
        public IndexControlViewModel(IRegionManager regionManager, IUIStringsService uIStringsService, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _UIStringsService = uIStringsService;
            //SwitchLanguageCommand = new DelegateCommand(switchLanguage);
            //languageSettingState.ToCode();
            //InitialPageLanguage();
            _UIStringsService.UpdateUI();
            eventAggregator.GetEvent<LanguageChangedEvent>().Subscribe(UpdateStrings);
            //UpdateStrings2();
        }

        //public void InitialPageLanguage()
        //{
        //    string code = languageSettingState.ToCode();
        //    Language.Strings.Culture = new CultureInfo(code);
        //    CurrentLanguage = languageSettingState;
        //    _UIStringsService.UpdateStrings();
        //}

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
                _regionManager.RequestNavigate("IndexViewRegion", "SystemSettingsView", parameters);

            }
            else if (page == "Quit")
            {

            }
            else if (page == "Language")
            {
                _UIStringsService.ChangeUIStrings();
            }
        }

        public string NewGame => _UIStringsService.NewGame;
        public string LanguageChange => _UIStringsService.LanguageChange;
        public string Load => _UIStringsService.Load;
        public string System => _UIStringsService.System;
        public string Quit => _UIStringsService.Quit;

        public void UpdateStrings()
        {
            RaisePropertyChanged(nameof(NewGame));
            RaisePropertyChanged(nameof(LanguageChange));
            RaisePropertyChanged(nameof(Load));
            RaisePropertyChanged(nameof(System));
            RaisePropertyChanged(nameof(Quit));
        }

        public DelegateCommand SwitchLanguageCommand { get; }
        //private void switchLanguage()
        //{
        //    CurrentLanguage = (LanguageState)(((int)CurrentLanguage + 1) % Enum.GetNames(typeof(LanguageState)).Length);
        //}
    }
}
