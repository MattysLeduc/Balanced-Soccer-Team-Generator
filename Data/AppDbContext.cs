using Balanced_Soccer_Team_Generator.Models;
using Microsoft.EntityFrameworkCore;
using Balanced_Soccer_Team_Generator.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Balanced_Soccer_Team_Generator.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Player> Players => Set<Player>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Optional: Seed a few players so you can test quickly
            modelBuilder.Entity<Player>().HasData(
// TOP WORLD-CLASS PLAYERS (1–20)
new Player { Id = 1, Name = "Lionel Messi", BallControl = 10, PassingAccuracy = 10, Dribbling = 10, DefensiveAwareness = 6, Shooting = 10 },
new Player { Id = 2, Name = "Cristiano Ronaldo", BallControl = 9, PassingAccuracy = 8, Dribbling = 9, DefensiveAwareness = 7, Shooting = 10 },
new Player { Id = 3, Name = "Kylian Mbappé", BallControl = 9, PassingAccuracy = 8, Dribbling = 10, DefensiveAwareness = 7, Shooting = 9 },
new Player { Id = 4, Name = "Erling Haaland", BallControl = 8, PassingAccuracy = 7, Dribbling = 7, DefensiveAwareness = 6, Shooting = 10 },
new Player { Id = 5, Name = "Kevin De Bruyne", BallControl = 9, PassingAccuracy = 10, Dribbling = 8, DefensiveAwareness = 8, Shooting = 8 },
new Player { Id = 6, Name = "Neymar Jr", BallControl = 10, PassingAccuracy = 9, Dribbling = 10, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 7, Name = "Mohamed Salah", BallControl = 9, PassingAccuracy = 8, Dribbling = 9, DefensiveAwareness = 6, Shooting = 9 },
new Player { Id = 8, Name = "Harry Kane", BallControl = 9, PassingAccuracy = 9, Dribbling = 8, DefensiveAwareness = 7, Shooting = 10 },
new Player { Id = 9, Name = "Jude Bellingham", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 8, Shooting = 8 },
new Player { Id = 10, Name = "Vinícius Jr", BallControl = 9, PassingAccuracy = 8, Dribbling = 10, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 11, Name = "Robert Lewandowski", BallControl = 9, PassingAccuracy = 8, Dribbling = 8, DefensiveAwareness = 6, Shooting = 10 },
new Player { Id = 12, Name = "Luka Modrić", BallControl = 9, PassingAccuracy = 10, Dribbling = 9, DefensiveAwareness = 7, Shooting = 7 },
new Player { Id = 13, Name = "Karim Benzema", BallControl = 9, PassingAccuracy = 8, Dribbling = 8, DefensiveAwareness = 7, Shooting = 9 },
new Player { Id = 14, Name = "Bruno Fernandes", BallControl = 8, PassingAccuracy = 9, Dribbling = 8, DefensiveAwareness = 7, Shooting = 8 },
new Player { Id = 15, Name = "Sadio Mané", BallControl = 8, PassingAccuracy = 7, Dribbling = 9, DefensiveAwareness = 7, Shooting = 8 },
new Player { Id = 16, Name = "Antoine Griezmann", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 7, Shooting = 8 },
new Player { Id = 17, Name = "Bernardo Silva", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 8, Shooting = 7 },
new Player { Id = 18, Name = "Phil Foden", BallControl = 9, PassingAccuracy = 8, Dribbling = 9, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 19, Name = "Rodri", BallControl = 8, PassingAccuracy = 10, Dribbling = 7, DefensiveAwareness = 9, Shooting = 6 },
new Player { Id = 20, Name = "João Cancelo", BallControl = 8, PassingAccuracy = 9, Dribbling = 8, DefensiveAwareness = 7, Shooting = 7 },

// PREMIER LEAGUE STARS (21–40)
new Player { Id = 21, Name = "Bukayo Saka", BallControl = 9, PassingAccuracy = 8, Dribbling = 9, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 22, Name = "Martin Ødegaard", BallControl = 9, PassingAccuracy = 10, Dribbling = 8, DefensiveAwareness = 6, Shooting = 7 },
new Player { Id = 23, Name = "Declan Rice", BallControl = 7, PassingAccuracy = 8, Dribbling = 7, DefensiveAwareness = 9, Shooting = 6 },
new Player { Id = 24, Name = "Virgil van Dijk", BallControl = 7, PassingAccuracy = 7, Dribbling = 6, DefensiveAwareness = 10, Shooting = 6 },
new Player { Id = 25, Name = "Trent Alexander-Arnold", BallControl = 9, PassingAccuracy = 10, Dribbling = 8, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 26, Name = "Alisson Becker", BallControl = 6, PassingAccuracy = 7, Dribbling = 5, DefensiveAwareness = 10, Shooting = 3 },
new Player { Id = 27, Name = "Ederson Moraes", BallControl = 7, PassingAccuracy = 9, Dribbling = 6, DefensiveAwareness = 9, Shooting = 4 },
new Player { Id = 28, Name = "Rúben Dias", BallControl = 7, PassingAccuracy = 7, Dribbling = 6, DefensiveAwareness = 9, Shooting = 5 },
new Player { Id = 29, Name = "Jack Grealish", BallControl = 9, PassingAccuracy = 8, Dribbling = 9, DefensiveAwareness = 6, Shooting = 7 },
new Player { Id = 30, Name = "Marcus Rashford", BallControl = 8, PassingAccuracy = 7, Dribbling = 9, DefensiveAwareness = 6, Shooting = 9 },
new Player { Id = 31, Name = "Casemiro", BallControl = 7, PassingAccuracy = 7, Dribbling = 6, DefensiveAwareness = 10, Shooting = 7 },
new Player { Id = 32, Name = "Bruno Guimarães", BallControl = 8, PassingAccuracy = 9, Dribbling = 7, DefensiveAwareness = 8, Shooting = 7 },
new Player { Id = 33, Name = "Son Heung-min", BallControl = 9, PassingAccuracy = 8, Dribbling = 9, DefensiveAwareness = 6, Shooting = 9 },
new Player { Id = 34, Name = "James Maddison", BallControl = 9, PassingAccuracy = 9, Dribbling = 8, DefensiveAwareness = 5, Shooting = 8 },
new Player { Id = 35, Name = "Kai Havertz", BallControl = 8, PassingAccuracy = 8, Dribbling = 8, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 36, Name = "Thiago Silva", BallControl = 7, PassingAccuracy = 7, Dribbling = 6, DefensiveAwareness = 10, Shooting = 5 },
new Player { Id = 37, Name = "Enzo Fernández", BallControl = 8, PassingAccuracy = 8, Dribbling = 8, DefensiveAwareness = 7, Shooting = 6 },
new Player { Id = 38, Name = "Raheem Sterling", BallControl = 8, PassingAccuracy = 7, Dribbling = 9, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 39, Name = "Dominic Calvert-Lewin", BallControl = 7, PassingAccuracy = 6, Dribbling = 7, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 40, Name = "Luis Díaz", BallControl = 9, PassingAccuracy = 8, Dribbling = 9, DefensiveAwareness = 5, Shooting = 7 },

// LA LIGA + SERIE A + BUNDESLIGA (41–70)
new Player { Id = 41, Name = "Pedri", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 7, Shooting = 7 },
new Player { Id = 42, Name = "Gavi", BallControl = 8, PassingAccuracy = 8, Dribbling = 8, DefensiveAwareness = 8, Shooting = 6 },
new Player { Id = 43, Name = "Frenkie de Jong", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 7, Shooting = 6 },
new Player { Id = 44, Name = "Ronald Araújo", BallControl = 6, PassingAccuracy = 6, Dribbling = 5, DefensiveAwareness = 10, Shooting = 5 },
new Player { Id = 45, Name = "Ilkay Gündogan", BallControl = 9, PassingAccuracy = 9, Dribbling = 8, DefensiveAwareness = 7, Shooting = 7 },
new Player { Id = 46, Name = "Ousmane Dembélé", BallControl = 9, PassingAccuracy = 7, Dribbling = 10, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 47, Name = "Jamal Musiala", BallControl = 10, PassingAccuracy = 8, Dribbling = 10, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 48, Name = "Joshua Kimmich", BallControl = 8, PassingAccuracy = 9, Dribbling = 7, DefensiveAwareness = 9, Shooting = 6 },
new Player { Id = 49, Name = "Leroy Sané", BallControl = 9, PassingAccuracy = 8, Dribbling = 9, DefensiveAwareness = 5, Shooting = 8 },
new Player { Id = 50, Name = "Thomas Müller", BallControl = 8, PassingAccuracy = 9, Dribbling = 7, DefensiveAwareness = 7, Shooting = 8 },

new Player { Id = 51, Name = "Victor Osimhen", BallControl = 8, PassingAccuracy = 7, Dribbling = 8, DefensiveAwareness = 6, Shooting = 9 },
new Player { Id = 52, Name = "Khvicha Kvaratskhelia", BallControl = 9, PassingAccuracy = 8, Dribbling = 10, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 53, Name = "Federico Chiesa", BallControl = 8, PassingAccuracy = 7, Dribbling = 9, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 54, Name = "Paulo Dybala", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 5, Shooting = 8 },
new Player { Id = 55, Name = "Lautaro Martínez", BallControl = 8, PassingAccuracy = 7, Dribbling = 8, DefensiveAwareness = 7, Shooting = 9 },
new Player { Id = 56, Name = "Nicolo Barella", BallControl = 8, PassingAccuracy = 9, Dribbling = 8, DefensiveAwareness = 9, Shooting = 6 },
new Player { Id = 57, Name = "Hakan Çalhanoğlu", BallControl = 8, PassingAccuracy = 9, Dribbling = 7, DefensiveAwareness = 7, Shooting = 9 },
new Player { Id = 58, Name = "Rafael Leão", BallControl = 9, PassingAccuracy = 7, Dribbling = 10, DefensiveAwareness = 5, Shooting = 8 },
new Player { Id = 59, Name = "Krzysztof Piątek", BallControl = 7, PassingAccuracy = 6, Dribbling = 6, DefensiveAwareness = 5, Shooting = 8 },
new Player { Id = 60, Name = "Serge Gnabry", BallControl = 8, PassingAccuracy = 7, Dribbling = 9, DefensiveAwareness = 5, Shooting = 8 },

new Player { Id = 61, Name = "Marco Reus", BallControl = 9, PassingAccuracy = 8, Dribbling = 8, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 62, Name = "Jadon Sancho", BallControl = 9, PassingAccuracy = 8, Dribbling = 10, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 63, Name = "Niclas Füllkrug", BallControl = 7, PassingAccuracy = 6, Dribbling = 6, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 64, Name = "Mats Hummels", BallControl = 7, PassingAccuracy = 8, Dribbling = 6, DefensiveAwareness = 9, Shooting = 5 },
new Player { Id = 65, Name = "Julian Brandt", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 6, Shooting = 7 },
new Player { Id = 66, Name = "Ángel Di María", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 67, Name = "Leandro Paredes", BallControl = 7, PassingAccuracy = 8, Dribbling = 7, DefensiveAwareness = 8, Shooting = 6 },
new Player { Id = 68, Name = "Giovanni Reyna", BallControl = 8, PassingAccuracy = 7, Dribbling = 9, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 69, Name = "André Silva", BallControl = 7, PassingAccuracy = 7, Dribbling = 7, DefensiveAwareness = 5, Shooting = 8 },
new Player { Id = 70, Name = "Youssoufa Moukoko", BallControl = 8, PassingAccuracy = 7, Dribbling = 9, DefensiveAwareness = 4, Shooting = 7 },

// EXTRA EUROPEAN + MLS (71–100)
new Player { Id = 71, Name = "Christian Pulisic", BallControl = 8, PassingAccuracy = 7, Dribbling = 9, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 72, Name = "Alphonso Davies", BallControl = 9, PassingAccuracy = 8, Dribbling = 10, DefensiveAwareness = 8, Shooting = 6 },
new Player { Id = 73, Name = "Jonathan David", BallControl = 8, PassingAccuracy = 7, Dribbling = 8, DefensiveAwareness = 5, Shooting = 8 },
new Player { Id = 74, Name = "Cyle Larin", BallControl = 7, PassingAccuracy = 6, Dribbling = 6, DefensiveAwareness = 5, Shooting = 8 },
new Player { Id = 75, Name = "Ismaël Koné", BallControl = 7, PassingAccuracy = 7, Dribbling = 8, DefensiveAwareness = 6, Shooting = 6 },
new Player { Id = 76, Name = "Milan Borjan", BallControl = 5, PassingAccuracy = 6, Dribbling = 4, DefensiveAwareness = 9, Shooting = 3 },
new Player { Id = 77, Name = "Hirving Lozano", BallControl = 8, PassingAccuracy = 7, Dribbling = 9, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 78, Name = "Edson Álvarez", BallControl = 7, PassingAccuracy = 8, Dribbling = 6, DefensiveAwareness = 9, Shooting = 5 },
new Player { Id = 79, Name = "Raúl Jiménez", BallControl = 7, PassingAccuracy = 7, Dribbling = 7, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 80, Name = "Weston McKennie", BallControl = 7, PassingAccuracy = 7, Dribbling = 7, DefensiveAwareness = 8, Shooting = 6 },

new Player { Id = 81, Name = "Sergiño Dest", BallControl = 8, PassingAccuracy = 7, Dribbling = 8, DefensiveAwareness = 5, Shooting = 5 },
new Player { Id = 82, Name = "Tyler Adams", BallControl = 7, PassingAccuracy = 7, Dribbling = 6, DefensiveAwareness = 9, Shooting = 5 },
new Player { Id = 83, Name = "Giorgio Chiellini", BallControl = 6, PassingAccuracy = 7, Dribbling = 5, DefensiveAwareness = 10, Shooting = 4 },
new Player { Id = 84, Name = "Carlos Vela", BallControl = 9, PassingAccuracy = 8, Dribbling = 9, DefensiveAwareness = 5, Shooting = 9 },
new Player { Id = 85, Name = "Lorenzo Insigne", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 86, Name = "Federico Bernardeschi", BallControl = 8, PassingAccuracy = 8, Dribbling = 8, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 87, Name = "Xherdan Shaqiri", BallControl = 9, PassingAccuracy = 8, Dribbling = 8, DefensiveAwareness = 4, Shooting = 8 },
new Player { Id = 88, Name = "Cucho Hernández", BallControl = 8, PassingAccuracy = 7, Dribbling = 8, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 89, Name = "Josef Martínez", BallControl = 8, PassingAccuracy = 7, Dribbling = 7, DefensiveAwareness = 5, Shooting = 9 },
new Player { Id = 90, Name = "Riqui Puig", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 5, Shooting = 6 },

new Player { Id = 91, Name = "Thiago Almada", BallControl = 9, PassingAccuracy = 9, Dribbling = 10, DefensiveAwareness = 5, Shooting = 7 },
new Player { Id = 92, Name = "Brandon Vazquez", BallControl = 7, PassingAccuracy = 6, Dribbling = 6, DefensiveAwareness = 5, Shooting = 8 },
new Player { Id = 93, Name = "Paul Arriola", BallControl = 7, PassingAccuracy = 7, Dribbling = 7, DefensiveAwareness = 7, Shooting = 6 },
new Player { Id = 94, Name = "Jordan Morris", BallControl = 7, PassingAccuracy = 6, Dribbling = 7, DefensiveAwareness = 6, Shooting = 8 },
new Player { Id = 95, Name = "Djordje Mihailovic", BallControl = 8, PassingAccuracy = 8, Dribbling = 8, DefensiveAwareness = 6, Shooting = 7 },
new Player { Id = 96, Name = "Damir Kreilach", BallControl = 7, PassingAccuracy = 7, Dribbling = 6, DefensiveAwareness = 7, Shooting = 7 },
new Player { Id = 97, Name = "Emanuel Reynoso", BallControl = 9, PassingAccuracy = 9, Dribbling = 9, DefensiveAwareness = 6, Shooting = 7 },
new Player { Id = 98, Name = "Jesús Ferreira", BallControl = 8, PassingAccuracy = 8, Dribbling = 8, DefensiveAwareness = 6, Shooting = 7 },
new Player { Id = 99, Name = "Walker Zimmerman", BallControl = 6, PassingAccuracy = 7, Dribbling = 5, DefensiveAwareness = 10, Shooting = 5 },
new Player { Id = 100, Name = "Miles Robinson", BallControl = 7, PassingAccuracy = 7, Dribbling = 6, DefensiveAwareness = 9, Shooting = 5 }

            );
        }
    }
}
