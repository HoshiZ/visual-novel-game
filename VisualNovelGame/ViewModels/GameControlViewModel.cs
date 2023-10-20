using Microsoft.Extensions.Logging.Abstractions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Media3D;
using VisualNovelGameDB.Models;
using VisualNovelGameDB.Repositories;
using VisualNovelGameDB.Services;
using VisualNovelGameDB.Services.IServices;

namespace VisualNovelGame.ViewModels
{
    public class GameControlViewModel : BindableBase
    {
        // 服务
        private readonly IRegionManager _regionManager;
        private readonly IVNCService _VNCService;

        // 委托
        public DelegateCommand SettingsCommand { get; set; }
        public DelegateCommand LeftClickEvent { get; set; }

        // 构造函数
        public GameControlViewModel(IRegionManager regionManager, IVNCService vNCService)
        {
            SettingsCommand = new DelegateCommand(ExecuteSettingsCommand);

            _regionManager = regionManager;
            _VNCService = vNCService;

            LeftClickEvent = new DelegateCommand(ExecuteLeftClickEvent);

            // 连接数据库
            CharacterRepository();
        }


        private void ExecuteSettingsCommand()
        {
            var parameters = new NavigationParameters();
            parameters.Add("ReturnRegion", "GameViewRegion");
            parameters.Add("ReturnView", "GameControl");
            _regionManager.RequestNavigate("GameViewRegion", "SystemSettingsView", parameters);
        }


        // 左键点击
        //private int _currentIndex = -1;
        //private IEnumerable<string> _strings;
        //private IEnumerable<DialogueModel> dialogues;
        public void CharacterRepository()
        {
            //var characterRepository = new CharacterRepository();
            //_strings = characterRepository.GetCharacters();
            //var characterService = new CharacterService();
            //dialogues = characterService.GetDialogue();
        }

        private void ExecuteLeftClickEvent()
        {
            //_currentIndex++;
            //if (_currentIndex < dialogues.Count())
            //{
            //    //StoryText = _strings.ElementAt(_currentIndex);
            //    StoryText = dialogues.ElementAt(_currentIndex).Text;
            //    FullImageSource = $"pack://application:,,,/Resources/image/full/{dialogues.ElementAt(_currentIndex).Name}_full.png";
            //    AvatarImageSource = $"pack://application:,,,/Resources/image/amatar/{dialogues.ElementAt(_currentIndex).Name}_avatar.png";
            //    CharacterName = dialogues.ElementAt(_currentIndex).Name;
            //}
            //else
            //{
            //    return;
            //}
            var data = _VNCService.GetGameDataModel();
            if (data != null)
            {
                StoryText = data.Text;
                //FullImageSource = $"pack://application:,,,/Resources/image/full/{dialogues.ElementAt(_currentIndex).Name}_full.png";
                FullImageSource = $"pack://application:,,,/Resources/image/full/{data.CharacterImages.ElementAt(0)}.png";
                AvatarImageSource = $"pack://application:,,,/Resources/image/avatar/{data.CharacterAvatar}_avatar.png";
                CharacterName = data.CharacterName;
            }
            else if (data == null)
            {
                StoryText = "游戏结束，感谢阅读";
                FullImageSource = null;
                AvatarImageSource = null;
                CharacterName = "系统公告";
            }
        }



        private string _storyText;
        public string StoryText
        {
            get { return _storyText; }
            set
            {
                SetProperty(ref _storyText, value);
            }
        }

        private string _fullImageSource;
        public string FullImageSource
        {
            get { return _fullImageSource; }
            set
            {
                SetProperty(ref _fullImageSource, value);
            }
        }

        //private IEnumerable<string?> _characterImages;
        //public IEnumerable<string?> CharacterImages
        //{
        //    get { return _characterImages; }
        //    set
        //    {

        //    }
        //}


        private string _avatarImageSource;
        public string AvatarImageSource
        {
            get { return _avatarImageSource; }
            set
            {
                SetProperty(ref _avatarImageSource, value);
            }
        }

        private string _characterName;
        public string CharacterName
        {
            get { return _characterName; }
            set
            {
                SetProperty(ref _characterName, value);
            }
        }
    }
}
