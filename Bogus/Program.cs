using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using VisualNovelGameDB.Entities;
using VisualNovelGameDB.Models;
using VisualNovelGameDB.Repositories;
using VisualNovelGameDB.Repositories.IRepositories;
using VisualNovelGameDB.Services;

namespace fake
{
    public class Program
    {
        static void Main(string[] args)
        {
            var visualNovelGameDBContext = new VisualNovelGameDBContext();
            var initialMethod = new InitialMethod(visualNovelGameDBContext);

            initialMethod.AllInitial();
        }

        public class InitialMethod
        {
            private string _jsonPath = "./settings.json";
            private string jsonContent;
            private InitialValue? _initialValues;
            private List<Character> _characterList;

            private readonly VisualNovelGameDBContext context;

            public InitialMethod(VisualNovelGameDBContext visualNovelGameDBContext)
            {
                this.context = visualNovelGameDBContext;

                jsonContent = File.ReadAllText(_jsonPath);
                _initialValues = JsonConvert.DeserializeObject<InitialValue>(jsonContent);
            }

            public void AllInitial()
            {
                Console.WriteLine("初始化开始");
                InitialCharacter();
                _characterList = GetRandomCharacterSpeakList();
                InitialAudio();
                InitialBGM();
                InitialCharacterImage();
                InitialOptionCollection();
                InitialChoiceOption();
                InitialScene();
                InitialMainlineText();
                InitialMainlineDialogue();
                InitialMainlineDialogue_CharacterImage();
                Console.WriteLine("初始化结束");
            }

            public void InitialAudio()
            {
                if (_initialValues?.isInitialAudio == false)
                {
                    var characters = context.Characters.ToList();

                    foreach (var character in characters)
                    {
                        var characterId = character.Id;
                        var characterENName = character.ENName;

                        context.Audios.Add(new Audio
                        {
                            CharacterId = characterId,
                            AudioPath = $"{characterENName}_audio1"
                        });
                        context.Audios.Add(new Audio
                        {
                            CharacterId = characterId,
                            AudioPath = $"{characterENName}_audio2"
                        });
                    }

                    _initialValues.isInitialAudio = true;
                    SaveJsonAndContext();
                    Console.WriteLine("成功,Audio表已被创建");
                    return;
                }
                Console.WriteLine("Audio表已经存在，初始化将不被执行");
            }

            public void InitialBGM()
            {
                if (_initialValues?.isInitialBGM == false)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        context.Bgms.Add(new Bgm
                        {
                            Description = $"介绍_{i}",
                            BgmPath = $"BGM_{i}"
                        });
                    }

                    _initialValues.isInitialBGM = true;
                    SaveJsonAndContext();
                    Console.WriteLine("成功,BGM表已被创建");
                    return;
                }
                Console.WriteLine("BGM表已经存在，初始化将不被执行");
            }

            public void InitialCharacter()
            {
                if (_initialValues?.isInitialCharacter == false)
                {
                    var characterList = new List<Character>();
                    characterList.Add(new Character { CNName = "伊蕾娜", ENName = "Elaina", JPName = "イレイナ" });
                    characterList.Add(new Character { CNName = "星空凛", ENName = "Rin Hoshizora", JPName = "星空凛" });
                    characterList.Add(new Character { CNName = "城门翼", ENName = "Tsubasa Kido", JPName = "城門 ツバサ" });
                    characterList.Add(new Character { CNName = "理塘丁真", ENName = "Litang Dingzhen", JPName = "リトウ　デイチン" });
                    foreach (var character in characterList)
                    {
                        context.Characters.Add(character);
                    }

                    _initialValues.isInitialCharacter = true;
                    SaveJsonAndContext();
                    Console.WriteLine("成功，角色表已创建");
                    return;
                }
                Console.WriteLine("角色表已经存在，初始化将不被执行");
            }

            public void InitialCharacterImage()
            {
                if (_initialValues?.isInitialCharacterImage == false)
                {
                    var characterImageList = new List<CharacterImage>();
                    characterImageList.Add(new CharacterImage { CharacterId = 1, VerticalPainting = "Elaina_1", Path = "Elaina_1" });
                    characterImageList.Add(new CharacterImage { CharacterId = 1, VerticalPainting = "Elaina_2", Path = "Elaina_2" });
                    characterImageList.Add(new CharacterImage { CharacterId = 2, VerticalPainting = "Rin_1", Path = "Rin_1" });
                    characterImageList.Add(new CharacterImage { CharacterId = 2, VerticalPainting = "Rin_2", Path = "Rin_2" });
                    characterImageList.Add(new CharacterImage { CharacterId = 3, VerticalPainting = "Tsubasa_1", Path = "Tsubasa_1" });
                    characterImageList.Add(new CharacterImage { CharacterId = 3, VerticalPainting = "Tsubasa_2", Path = "Tsubasa_2" });
                    characterImageList.Add(new CharacterImage { CharacterId = 4, VerticalPainting = "Dingzhen_1", Path = "Dingzhen_1" });
                    characterImageList.Add(new CharacterImage { CharacterId = 4, VerticalPainting = "Dingzhen_2", Path = "Dingzhen_2" });

                    foreach (var characterImage in characterImageList)
                    {
                        context.CharacterImages.Add(characterImage);
                    }

                    _initialValues.isInitialCharacterImage = true;
                    SaveJsonAndContext();
                    Console.WriteLine("成功，角色立绘表已创建");
                    return;
                }
                Console.WriteLine("角色立绘表已经存在，初始化将不被执行");
            }

            public void InitialChoiceOption()
            {
                int k = 1;
                if (_initialValues?.isInitialChoiceOption == false)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 2; j++)
                        {
                            context.ChoiceOptions.Add(new ChoiceOption
                            {
                                Id = k++,
                                OptionCollectionId = i,
                                CurrentMainlineDialogueId = null,
                                ChoiceCNText = $"测试组{j}",
                                ChoiceENText = $"Choice{j}",
                                ChoiceJPText = $"テキスト{j}"
                            });
                        }
                    }

                    _initialValues.isInitialChoiceOption = true;
                    SaveJsonAndContext();
                    Console.WriteLine("成功,ChoiceOption表已被创建");
                    return;
                }
                Console.WriteLine("ChoiceOption表已经存在，初始化将不被执行");
            }

            public void InitialMainlineDialogue()
            {
                if (_initialValues?.isInitialMainlineDialogue == false)
                {
                    var random = new Random();

                    for (int i = 1; i <= 100; i++)
                    {
                        var character = _characterList.ElementAt(i);
                        context.MainlineDialogues.Add(new MainlineDialogue
                        {
                            SceneId = GetRandomScene().Id,
                            AudioPath = GetRandomAudioPathByCharacter(character.ENName),
                            IsChoicePoint = false,
                            ChoiceOptionCollectionId = null,
                            IsBgmChange = false,
                            BgmId = null,
                            CharacterId = character.Id,
                            MainlineTextId = i,
                            HaveRead = false,
                            Chapter = $"{i / 25 + 1} - {(i / 5 + 1) % 6}",
                        });
                    }

                    _initialValues.isInitialMainlineDialogue = true;
                    SaveJsonAndContext();
                    Console.WriteLine("成功,MainDialogue表已被创建");
                    return;
                }
                Console.WriteLine("MainDialogue表已经存在，初始化将不被执行");
            }

            public void InitialMainlineDialogue_CharacterImage()
            {
                if (_initialValues?.isInitialMainlineDialogue_CharacterImage == false)
                {

                    // 添加逻辑
                    var random = new Random();
                    var mainlineDialogues = context.MainlineDialogues.ToList();

                    foreach (var dialogue in mainlineDialogues)
                    {
                        var characterId = dialogue.CharacterId;
                        var NowCharacter = context.Characters.Find(characterId);
                        var NowCharacterENName = NowCharacter!.ENName;


                        context.MainlineDialogues_CharacterImages.Add(new MainlineDialogue_CharacterImage
                        {
                            MainlineDialogueId = dialogue.Id,
                            CharacterId = characterId,
                            CharacterPath = $"{NowCharacterENName}_" + (random.Next(2) + 1)
                        });

                        if (random.NextDouble() < 0.15)
                        {
                            int newCharacterId = random.Next(1, 5);
                            while (newCharacterId == characterId)
                                newCharacterId = random.Next(1, 5);

                            var character = context.Characters.Find(newCharacterId);
                            var enName = character!.ENName;

                            context.MainlineDialogues_CharacterImages.Add(new MainlineDialogue_CharacterImage
                            {
                                MainlineDialogueId = dialogue.Id,
                                CharacterId = newCharacterId,
                                CharacterPath = $"{enName}_" + (random.Next(2) + 1)
                            });
                        }
                    }
                    // 添加逻辑结束

                    _initialValues.isInitialMainlineDialogue_CharacterImage = true;
                    SaveJsonAndContext();
                    Console.WriteLine("成功,MainDialogue_CharacterImage表已被创建");
                    return;
                }
                Console.WriteLine("MainDialogue_CharacterImage表已经存在，初始化将不被执行");
            }

            public void InitialMainlineText()
            {
                if (_initialValues?.isInitialMainlineText == false)
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        var tancemiao = _characterList.ElementAt(i);
                        var CNName = tancemiao.CNName;
                        var ENName = tancemiao.ENName;
                        var JPName = tancemiao.JPName;
                        var character = GetRandomCharacter();
                        string cn_text = $"第 {i} 行文本，角色 {CNName}说话了。";
                        string en_text = $"Line {i}, character {ENName} is speaking.";
                        string jp_text = $"第 {i} 行のテキスト、キャラクター {JPName} が話しています。";
                        
                        context.MainlineTexts.Add(new MainlineText { CNText = cn_text, ENText = en_text, JPText = jp_text });
                    }

                    _initialValues.isInitialMainlineText = true;
                    SaveJsonAndContext();
                    Console.WriteLine("成功，主线文本表已创建");
                    return;
                }
                Console.WriteLine("主线文本表已经存在，初始化将不被执行");
            }

            public void InitialOptionCollection()
            {
                if (_initialValues?.isInitialOptionCollection == false)
                {
                    var optionCollection = new List<OptionCollection>();
                    for (int i =1; i <= 5; i++)
                    {
                        optionCollection.Add(new OptionCollection { Id = i }); // 五个选项集喵
                    }

                    foreach (var option in optionCollection)
                    {
                        context.OptionCollections.Add(option);
                    }

                    _initialValues.isInitialOptionCollection = true;
                    SaveJsonAndContext();
                    Console.WriteLine("成功,OptionCollection表已被创建");
                    return;
                }
                Console.WriteLine("OptionCollection表已经存在，初始化将不被执行");
            }

            public void InitialScene()
            {
                if (_initialValues?.isInitialScene == false)
                {
                    var sceneList = new List<Scene>();
                    sceneList.Add(new Scene { Description = "场景1", ScenePath = "Scene_1" });
                    sceneList.Add(new Scene { Description = "场景2", ScenePath = "Scene_2" });
                    sceneList.Add(new Scene { Description = "场景3", ScenePath = "Scene_3" });
                    sceneList.Add(new Scene { Description = "场景4", ScenePath = "Scene_4" });
                    sceneList.Add(new Scene { Description = "场景5", ScenePath = "Scene_5" });
                    sceneList.Add(new Scene { Description = "场景6", ScenePath = "Scene_6" });

                    foreach (var scene in sceneList)
                    {
                        context.Scenes.Add(scene);
                    }

                    _initialValues.isInitialScene = true;
                    SaveJsonAndContext();
                    Console.WriteLine("成功，场景表已创建");
                    return;
                }
                Console.WriteLine("场景表已经存在，初始化将不被执行");
            }



            // 使用的方法
            public Character? GetRandomCharacter()
            {
                var random = new Random();
                var maxValueOnCharacterTable = context.Characters.Count();
                int randomValue = random.Next(0, maxValueOnCharacterTable);
                var character = context.Characters.Skip(randomValue).FirstOrDefault();
                return character;
            }

            public Scene? GetRandomScene()
            {
                var random = new Random();
                var maxValueOnSceneTable = context.Scenes.Count();
                int randomValue = random.Next(0, maxValueOnSceneTable);
                var scene = context.Scenes.Skip(randomValue).FirstOrDefault();
                return scene;
            }

            public string GetRandomAudioPathByCharacter(string characterName)
            {
                var random = new Random();
                //var character = context.Characters.Select(c => c.ENName == characterName).FirstOrDefault();
                //var maxValueOnAudioTable = context.Audios.Count(e => e.CharacterId == characterId);

                return $"{characterName}_Audio{random.Next(1, 3)}";
            }

            public void SaveJsonAndContext()
            {
                var updatedJson = JsonConvert.SerializeObject(_initialValues, Formatting.Indented);
                File.WriteAllText(_jsonPath, updatedJson);
                context.SaveChanges();
            }

            public List<Character> GetRandomCharacterSpeakList()
            {
                var characterList = new List<Character>();
                for (int i = 1; i <= 101; i++)
                {
                    characterList.Add(GetRandomCharacter());
                }
                return characterList;
            }
        }


        public class VisualNovelGameDBContext : DbContext
        {
            public DbSet<Audio> Audios { get; set; }
            public DbSet<Bgm> Bgms { get; set; }
            public DbSet<Character> Characters { get; set; }
            public DbSet<CharacterImage> CharacterImages { get; set; }
            public DbSet<ChoiceOption> ChoiceOptions { get; set; }
            public DbSet<MainlineDialogue> MainlineDialogues { get; set; }
            public DbSet<MainlineDialogue_CharacterImage> MainlineDialogues_CharacterImages { get; set; }
            public DbSet<MainlineText> MainlineTexts { get; set; }
            public DbSet<OptionCollection> OptionCollections { get; set; }
            public DbSet<Scene> Scenes { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseOracle(
                    "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=127.0.0.1)(PORT=1522))(CONNECT_DATA=(SERVICE_NAME=visual_novel_game_ceshi)));User ID=HOSHIZ;Password=1707;"
                    );
            }
        }

        public class InitialValue
        {
            public bool isInitialAudio { get; set; }
            public bool isInitialBGM { get; set; }
            public bool isInitialCharacter { get; set; }
            public bool isInitialCharacterImage { get; set; }
            public bool isInitialChoiceOption { get; set; }
            public bool isInitialMainlineDialogue { get; set; }
            public bool isInitialMainlineDialogue_CharacterImage { get; set; }
            public bool isInitialMainlineText { get; set; }
            public bool isInitialOptionCollection { get; set; }
            public bool isInitialScene { get; set; }
        }
    }
}