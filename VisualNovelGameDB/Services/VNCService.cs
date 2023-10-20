using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGameDB.Entities;
using VisualNovelGameDB.Models;
using VisualNovelGameDB.Repositories;
using VisualNovelGameDB.Repositories.IRepositories;
using VisualNovelGameDB.Services.IServices;

namespace VisualNovelGameDB.Services
{
    public class VNCService : IVNCService
    {
        private readonly IVNGRepository _repository;
        private GameDataModels _gameDataModels;
        private int _currentIndex = 1;
        private int _maxIndex = 100;
        public VNCService() 
        {
            _repository = new VNGRepository();
            InitialGameDataModels();
        }

        private void InitialGameDataModels()
        {
            var result = new GameDataModels();
            var mainlineDialogue = _repository.GetMainlineDialogues();
            result = new GameDataModels
            {
                Scene = _repository.GetSceneFromDialog(mainlineDialogue),
                Audio = _repository.GetAudioPathFromDialog(mainlineDialogue),
                //IsChoicePoint =
                //ChoiceOption = 
                //IsBGMChange = 
                BGM = _repository.GetBGMPathFromDialog(mainlineDialogue),
                CharacterName = _repository.GetCharacterNameFromDialog(mainlineDialogue, "cn"),
                CharacterImages = _repository.GetCharacterImagePathFromDialog(mainlineDialogue),
                Text = _repository.GetTextFromDialog(mainlineDialogue, "cn"),
                HaveRead = _repository.GetHaveReadFromDialog(mainlineDialogue),
                Chapter = _repository.GetChapterFromDialog(mainlineDialogue),
                CharacterAvatar = _repository.GetCharacterNameFromDialog(mainlineDialogue, "en")
            };
            _gameDataModels = result;
        }

        public GameDataModel GetGameDataModel()
        {
            if (_currentIndex >= _gameDataModels.Scene.Count())
            {
                return null;
            }

            var result = new GameDataModel
            {
                Scene = _gameDataModels.Scene.ElementAt(_currentIndex),
                Audio = _gameDataModels.Audio.ElementAt(_currentIndex),
                //IsChoicePoint =
                //ChoiceOption = 
                //IsBGMChange = 
                BGM = _gameDataModels.BGM.ElementAt(_currentIndex),
                CharacterName = _gameDataModels.CharacterName.ElementAt(_currentIndex),
                CharacterImages = _gameDataModels.CharacterImages.ElementAt(_currentIndex),
                Text = _gameDataModels.Text.ElementAt(_currentIndex),
                HaveRead = _gameDataModels.HaveRead.ElementAt(_currentIndex),
                Chapter = _gameDataModels.Chapter.ElementAt(_currentIndex),
                CharacterAvatar = _gameDataModels.CharacterAvatar.ElementAt(_currentIndex),
            };
            _currentIndex++;
            return result;
        }
    }
}
