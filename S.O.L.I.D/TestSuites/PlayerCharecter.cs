using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.TestSuites
{
    public class PlayerCharecter
    {
        public PlayerCharecter()
        {
            Name = GenerateName();
            IsNoob = true;
            NickName = "";
            CreateStartingWeapons();
        }

        private void CreateStartingWeapons()
        {
            Weapons = new List<string>
            {
            "Short Sword",
            "Short Bow",
            "Long Bow",
            "Long Sword"
            };
        }

        public int Health { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public bool IsNoob { get; set; }
        public List<string> Weapons { get; set; }
        public int Sleep()
        {
            var rnd = new Random();
            var healthIncrease = rnd.Next(1, 101);
            Health += healthIncrease;
            return Health;
        }
        public void TakeDamage(int damage)
        {
            Health = Math.Max(1, Health -= damage);
        }

        private string GenerateName()
        {
            var names = new[] {
                "abc", "def", "ghi", "jkl"
            };
            return names[new Random().Next(0, names.Length)];
        }

    }
}
