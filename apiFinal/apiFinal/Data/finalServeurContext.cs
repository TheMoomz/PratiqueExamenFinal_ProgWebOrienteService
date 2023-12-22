using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using finalServeur.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace finalServeur.Data
{
    public class finalServeurContext : IdentityDbContext<User>
    {
        public finalServeurContext (DbContextOptions<finalServeurContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Users
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            User u1 = new User
            {
                Id = "11111111-1111-1111-1111-111111111111",
                UserName = "Nicole",
                NormalizedUserName = "NICOLE",
                Email = "n@n.n",
                NormalizedEmail = "N@N.N"
            };
            u1.PasswordHash = hasher.HashPassword(u1, "Salut1!");
            User u2 = new User
            {
                Id = "11111111-1111-1111-1111-111111111112",
                UserName = "Solange",
                NormalizedUserName = "SOLANGE",
                Email = "s@s.s",
                NormalizedEmail = "S@S.S"
            };
            u2.PasswordHash = hasher.HashPassword(u2, "Salut1!");
            User u3 = new User
            {
                Id = "11111111-1111-1111-1111-111111111113",
                UserName = "Fernando",
                NormalizedUserName = "FERNANDO",
                Email = "f@f.f",
                NormalizedEmail = "F@F.F"
            };
            u3.PasswordHash = hasher.HashPassword(u3, "Salut1!");
            User u4 = new User
            {
                Id = "11111111-1111-1111-1111-111111111114",
                UserName = "Marc",
                NormalizedUserName = "MARC",
                Email = "m@m.m",
                NormalizedEmail = "M@M.M"
            };
            u4.PasswordHash = hasher.HashPassword(u4, "Salut1!");
            builder.Entity<User>().HasData(u1, u2, u3, u4);

            // Tweets
            builder.Entity<Tweet>().HasData(
            new
            {
                Id = 1,
                Text = "Lorsque mon chat veut sortir et qu'il voit qu'il pleut dans la porte arrière, il veut que j'aille lui ouvrir la porte avant pour vérifier s'il pleut aussi dans l'autre univers" + Environment.NewLine + "-Nicole",
                Score = 1,
                UserId = "11111111-1111-1111-1111-111111111111"
            },
            new
            {
                Id = 2,
                Text = "AAAAAAAAAAAAAAAAAAAAAAAA" + Environment.NewLine + "-Solange",
                Score = 0,
                UserId = "11111111-1111-1111-1111-111111111112"
            },
            new
            {
                Id = 3,
                Text = "Inutile d'essayer de raconter une histoire drôle Nicole, les étudiants sont en plein examen et doivent se concentrer." + Environment.NewLine + "-Fernando",
                Score = -1,
                UserId = "11111111-1111-1111-1111-111111111113",
                AnswerToId = 1
            },
            new
            {
                Id = 4,
                Text = "ok" + Environment.NewLine + "-Nicole",
                Score = 2,
                UserId = "11111111-1111-1111-1111-111111111111",
                AnswerToId = 2
            });
        }

        public DbSet<finalServeur.Models.Tweet> Tweet { get; set; }

        public DbSet<finalServeur.Models.Picture> Picture { get; set; }
    }
}
