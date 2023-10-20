using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisualNovelGameDB.Migrations
{
    /// <inheritdoc />
    public partial class kukule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AUDIO",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    character_id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    audio_path = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUDIO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BGM",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    bgm_path = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BGM", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CHARACTER",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    cn_name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    en_name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    jp_name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHARACTER", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CHARACTERIMAGE",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    character_id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    vertical_painting = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    path = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHARACTERIMAGE", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MAINLINETEXT",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    cn_text = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    en_text = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    jp_text = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAINLINETEXT", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OPTIONCOLLECTION",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPTIONCOLLECTION", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SCENE",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    path = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCENE", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MAINLINEDIALOGUE",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    scene_id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    audio_path = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    is_choice_point = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    choice_option_collection_id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    is_bgm_change = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    bgm_id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    character_id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    mainline_text_id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    have_read = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    chapter = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AudioId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAINLINEDIALOGUE", x => x.id);
                    table.ForeignKey(
                        name: "FK_MAINLINEDIALOGUE_AUDIO_AudioId",
                        column: x => x.AudioId,
                        principalTable: "AUDIO",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_MAINLINEDIALOGUE_BGM_bgm_id",
                        column: x => x.bgm_id,
                        principalTable: "BGM",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_MAINLINEDIALOGUE_CHARACTER_character_id",
                        column: x => x.character_id,
                        principalTable: "CHARACTER",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_MAINLINEDIALOGUE_MAINLINETEXT_mainline_text_id",
                        column: x => x.mainline_text_id,
                        principalTable: "MAINLINETEXT",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_MAINLINEDIALOGUE_OPTIONCOLLECTION_choice_option_collection_id",
                        column: x => x.choice_option_collection_id,
                        principalTable: "OPTIONCOLLECTION",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_MAINLINEDIALOGUE_SCENE_scene_id",
                        column: x => x.scene_id,
                        principalTable: "SCENE",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CHOICEOPTION",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    option_collection_id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    current_mainline_dialogue_id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    choice_cn_text = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    choice_en_text = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    choice_jp_text = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    next_mainline_dialogue_id = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHOICEOPTION", x => x.id);
                    table.ForeignKey(
                        name: "FK_CHOICEOPTION_MAINLINEDIALOGUE_current_mainline_dialogue_id",
                        column: x => x.current_mainline_dialogue_id,
                        principalTable: "MAINLINEDIALOGUE",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_CHOICEOPTION_MAINLINEDIALOGUE_next_mainline_dialogue_id",
                        column: x => x.next_mainline_dialogue_id,
                        principalTable: "MAINLINEDIALOGUE",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_CHOICEOPTION_OPTIONCOLLECTION_option_collection_id",
                        column: x => x.option_collection_id,
                        principalTable: "OPTIONCOLLECTION",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "MAINLINEDIALOGUE_CHARACTERIMAGE",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    mainline_dialogue_id = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    character_id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    character_path = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAINLINEDIALOGUE_CHARACTERIMAGE", x => x.id);
                    table.ForeignKey(
                        name: "FK_MAINLINEDIALOGUE_CHARACTERIMAGE_MAINLINEDIALOGUE_mainline_dialogue_id",
                        column: x => x.mainline_dialogue_id,
                        principalTable: "MAINLINEDIALOGUE",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHOICEOPTION_current_mainline_dialogue_id",
                table: "CHOICEOPTION",
                column: "current_mainline_dialogue_id");

            migrationBuilder.CreateIndex(
                name: "IX_CHOICEOPTION_next_mainline_dialogue_id",
                table: "CHOICEOPTION",
                column: "next_mainline_dialogue_id");

            migrationBuilder.CreateIndex(
                name: "IX_CHOICEOPTION_option_collection_id",
                table: "CHOICEOPTION",
                column: "option_collection_id");

            migrationBuilder.CreateIndex(
                name: "IX_MAINLINEDIALOGUE_AudioId",
                table: "MAINLINEDIALOGUE",
                column: "AudioId");

            migrationBuilder.CreateIndex(
                name: "IX_MAINLINEDIALOGUE_bgm_id",
                table: "MAINLINEDIALOGUE",
                column: "bgm_id");

            migrationBuilder.CreateIndex(
                name: "IX_MAINLINEDIALOGUE_character_id",
                table: "MAINLINEDIALOGUE",
                column: "character_id");

            migrationBuilder.CreateIndex(
                name: "IX_MAINLINEDIALOGUE_choice_option_collection_id",
                table: "MAINLINEDIALOGUE",
                column: "choice_option_collection_id");

            migrationBuilder.CreateIndex(
                name: "IX_MAINLINEDIALOGUE_mainline_text_id",
                table: "MAINLINEDIALOGUE",
                column: "mainline_text_id");

            migrationBuilder.CreateIndex(
                name: "IX_MAINLINEDIALOGUE_scene_id",
                table: "MAINLINEDIALOGUE",
                column: "scene_id");

            migrationBuilder.CreateIndex(
                name: "IX_MAINLINEDIALOGUE_CHARACTERIMAGE_mainline_dialogue_id",
                table: "MAINLINEDIALOGUE_CHARACTERIMAGE",
                column: "mainline_dialogue_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHARACTERIMAGE");

            migrationBuilder.DropTable(
                name: "CHOICEOPTION");

            migrationBuilder.DropTable(
                name: "MAINLINEDIALOGUE_CHARACTERIMAGE");

            migrationBuilder.DropTable(
                name: "MAINLINEDIALOGUE");

            migrationBuilder.DropTable(
                name: "AUDIO");

            migrationBuilder.DropTable(
                name: "BGM");

            migrationBuilder.DropTable(
                name: "CHARACTER");

            migrationBuilder.DropTable(
                name: "MAINLINETEXT");

            migrationBuilder.DropTable(
                name: "OPTIONCOLLECTION");

            migrationBuilder.DropTable(
                name: "SCENE");
        }
    }
}
