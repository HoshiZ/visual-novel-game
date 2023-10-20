using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualNovelGameDB.Entities;

namespace VisualNovelGameDB.Data
{
    public class VNGDBContext : DbContext
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
}
