using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Balanced_Soccer_Team_Generator.Migrations
{
    /// <inheritdoc />
    public partial class Seed100Players : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BallControl", "Dribbling", "Name", "PassingAccuracy", "Shooting" },
                values: new object[] { 10, 10, "Lionel Messi", 10, 10 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BallControl", "Dribbling", "Name", "PassingAccuracy", "Shooting" },
                values: new object[] { 9, 9, "Cristiano Ronaldo", 8, 10 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dribbling", "Name" },
                values: new object[] { 10, "Kylian Mbappé" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BallControl", "DefensiveAwareness", "Dribbling", "Name", "PassingAccuracy", "Shooting" },
                values: new object[] { 8, 6, 7, "Erling Haaland", 7, 10 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BallControl", "DefensiveAwareness", "Dribbling", "Name", "OverallScore", "PassingAccuracy", "Rank", "Shooting" },
                values: new object[,]
                {
                    { 5, 9, 8, 8, "Kevin De Bruyne", 0, 10, 0, 8 },
                    { 6, 10, 6, 10, "Neymar Jr", 0, 9, 0, 8 },
                    { 7, 9, 6, 9, "Mohamed Salah", 0, 8, 0, 9 },
                    { 8, 9, 7, 8, "Harry Kane", 0, 9, 0, 10 },
                    { 9, 9, 8, 9, "Jude Bellingham", 0, 9, 0, 8 },
                    { 10, 9, 6, 10, "Vinícius Jr", 0, 8, 0, 8 },
                    { 11, 9, 6, 8, "Robert Lewandowski", 0, 8, 0, 10 },
                    { 12, 9, 7, 9, "Luka Modrić", 0, 10, 0, 7 },
                    { 13, 9, 7, 8, "Karim Benzema", 0, 8, 0, 9 },
                    { 14, 8, 7, 8, "Bruno Fernandes", 0, 9, 0, 8 },
                    { 15, 8, 7, 9, "Sadio Mané", 0, 7, 0, 8 },
                    { 16, 9, 7, 9, "Antoine Griezmann", 0, 9, 0, 8 },
                    { 17, 9, 8, 9, "Bernardo Silva", 0, 9, 0, 7 },
                    { 18, 9, 6, 9, "Phil Foden", 0, 8, 0, 8 },
                    { 19, 8, 9, 7, "Rodri", 0, 10, 0, 6 },
                    { 20, 8, 7, 8, "João Cancelo", 0, 9, 0, 7 },
                    { 21, 9, 6, 9, "Bukayo Saka", 0, 8, 0, 8 },
                    { 22, 9, 6, 8, "Martin Ødegaard", 0, 10, 0, 7 },
                    { 23, 7, 9, 7, "Declan Rice", 0, 8, 0, 6 },
                    { 24, 7, 10, 6, "Virgil van Dijk", 0, 7, 0, 6 },
                    { 25, 9, 5, 8, "Trent Alexander-Arnold", 0, 10, 0, 7 },
                    { 26, 6, 10, 5, "Alisson Becker", 0, 7, 0, 3 },
                    { 27, 7, 9, 6, "Ederson Moraes", 0, 9, 0, 4 },
                    { 28, 7, 9, 6, "Rúben Dias", 0, 7, 0, 5 },
                    { 29, 9, 6, 9, "Jack Grealish", 0, 8, 0, 7 },
                    { 30, 8, 6, 9, "Marcus Rashford", 0, 7, 0, 9 },
                    { 31, 7, 10, 6, "Casemiro", 0, 7, 0, 7 },
                    { 32, 8, 8, 7, "Bruno Guimarães", 0, 9, 0, 7 },
                    { 33, 9, 6, 9, "Son Heung-min", 0, 8, 0, 9 },
                    { 34, 9, 5, 8, "James Maddison", 0, 9, 0, 8 },
                    { 35, 8, 6, 8, "Kai Havertz", 0, 8, 0, 8 },
                    { 36, 7, 10, 6, "Thiago Silva", 0, 7, 0, 5 },
                    { 37, 8, 7, 8, "Enzo Fernández", 0, 8, 0, 6 },
                    { 38, 8, 5, 9, "Raheem Sterling", 0, 7, 0, 7 },
                    { 39, 7, 6, 7, "Dominic Calvert-Lewin", 0, 6, 0, 8 },
                    { 40, 9, 5, 9, "Luis Díaz", 0, 8, 0, 7 },
                    { 41, 9, 7, 9, "Pedri", 0, 9, 0, 7 },
                    { 42, 8, 8, 8, "Gavi", 0, 8, 0, 6 },
                    { 43, 9, 7, 9, "Frenkie de Jong", 0, 9, 0, 6 },
                    { 44, 6, 10, 5, "Ronald Araújo", 0, 6, 0, 5 },
                    { 45, 9, 7, 8, "Ilkay Gündogan", 0, 9, 0, 7 },
                    { 46, 9, 5, 10, "Ousmane Dembélé", 0, 7, 0, 7 },
                    { 47, 10, 6, 10, "Jamal Musiala", 0, 8, 0, 8 },
                    { 48, 8, 9, 7, "Joshua Kimmich", 0, 9, 0, 6 },
                    { 49, 9, 5, 9, "Leroy Sané", 0, 8, 0, 8 },
                    { 50, 8, 7, 7, "Thomas Müller", 0, 9, 0, 8 },
                    { 51, 8, 6, 8, "Victor Osimhen", 0, 7, 0, 9 },
                    { 52, 9, 6, 10, "Khvicha Kvaratskhelia", 0, 8, 0, 8 },
                    { 53, 8, 6, 9, "Federico Chiesa", 0, 7, 0, 8 },
                    { 54, 9, 5, 9, "Paulo Dybala", 0, 9, 0, 8 },
                    { 55, 8, 7, 8, "Lautaro Martínez", 0, 7, 0, 9 },
                    { 56, 8, 9, 8, "Nicolo Barella", 0, 9, 0, 6 },
                    { 57, 8, 7, 7, "Hakan Çalhanoğlu", 0, 9, 0, 9 },
                    { 58, 9, 5, 10, "Rafael Leão", 0, 7, 0, 8 },
                    { 59, 7, 5, 6, "Krzysztof Piątek", 0, 6, 0, 8 },
                    { 60, 8, 5, 9, "Serge Gnabry", 0, 7, 0, 8 },
                    { 61, 9, 6, 8, "Marco Reus", 0, 8, 0, 8 },
                    { 62, 9, 5, 10, "Jadon Sancho", 0, 8, 0, 7 },
                    { 63, 7, 6, 6, "Niclas Füllkrug", 0, 6, 0, 8 },
                    { 64, 7, 9, 6, "Mats Hummels", 0, 8, 0, 5 },
                    { 65, 9, 6, 9, "Julian Brandt", 0, 9, 0, 7 },
                    { 66, 9, 6, 9, "Ángel Di María", 0, 9, 0, 8 },
                    { 67, 7, 8, 7, "Leandro Paredes", 0, 8, 0, 6 },
                    { 68, 8, 5, 9, "Giovanni Reyna", 0, 7, 0, 7 },
                    { 69, 7, 5, 7, "André Silva", 0, 7, 0, 8 },
                    { 70, 8, 4, 9, "Youssoufa Moukoko", 0, 7, 0, 7 },
                    { 71, 8, 5, 9, "Christian Pulisic", 0, 7, 0, 7 },
                    { 72, 9, 8, 10, "Alphonso Davies", 0, 8, 0, 6 },
                    { 73, 8, 5, 8, "Jonathan David", 0, 7, 0, 8 },
                    { 74, 7, 5, 6, "Cyle Larin", 0, 6, 0, 8 },
                    { 75, 7, 6, 8, "Ismaël Koné", 0, 7, 0, 6 },
                    { 76, 5, 9, 4, "Milan Borjan", 0, 6, 0, 3 },
                    { 77, 8, 5, 9, "Hirving Lozano", 0, 7, 0, 7 },
                    { 78, 7, 9, 6, "Edson Álvarez", 0, 8, 0, 5 },
                    { 79, 7, 6, 7, "Raúl Jiménez", 0, 7, 0, 8 },
                    { 80, 7, 8, 7, "Weston McKennie", 0, 7, 0, 6 },
                    { 81, 8, 5, 8, "Sergiño Dest", 0, 7, 0, 5 },
                    { 82, 7, 9, 6, "Tyler Adams", 0, 7, 0, 5 },
                    { 83, 6, 10, 5, "Giorgio Chiellini", 0, 7, 0, 4 },
                    { 84, 9, 5, 9, "Carlos Vela", 0, 8, 0, 9 },
                    { 85, 9, 5, 9, "Lorenzo Insigne", 0, 9, 0, 7 },
                    { 86, 8, 5, 8, "Federico Bernardeschi", 0, 8, 0, 7 },
                    { 87, 9, 4, 8, "Xherdan Shaqiri", 0, 8, 0, 8 },
                    { 88, 8, 5, 8, "Cucho Hernández", 0, 7, 0, 7 },
                    { 89, 8, 5, 7, "Josef Martínez", 0, 7, 0, 9 },
                    { 90, 9, 5, 9, "Riqui Puig", 0, 9, 0, 6 },
                    { 91, 9, 5, 10, "Thiago Almada", 0, 9, 0, 7 },
                    { 92, 7, 5, 6, "Brandon Vazquez", 0, 6, 0, 8 },
                    { 93, 7, 7, 7, "Paul Arriola", 0, 7, 0, 6 },
                    { 94, 7, 6, 7, "Jordan Morris", 0, 6, 0, 8 },
                    { 95, 8, 6, 8, "Djordje Mihailovic", 0, 8, 0, 7 },
                    { 96, 7, 7, 6, "Damir Kreilach", 0, 7, 0, 7 },
                    { 97, 9, 6, 9, "Emanuel Reynoso", 0, 9, 0, 7 },
                    { 98, 8, 6, 8, "Jesús Ferreira", 0, 8, 0, 7 },
                    { 99, 6, 10, 5, "Walker Zimmerman", 0, 7, 0, 5 },
                    { 100, 7, 9, 6, "Miles Robinson", 0, 7, 0, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BallControl", "Dribbling", "Name", "PassingAccuracy", "Shooting" },
                values: new object[] { 8, 8, "Alex", 7, 7 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BallControl", "Dribbling", "Name", "PassingAccuracy", "Shooting" },
                values: new object[] { 6, 7, "Blake", 6, 6 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dribbling", "Name" },
                values: new object[] { 8, "Casey" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BallControl", "DefensiveAwareness", "Dribbling", "Name", "PassingAccuracy", "Shooting" },
                values: new object[] { 5, 5, 5, "Drew", 5, 5 });
        }
    }
}
