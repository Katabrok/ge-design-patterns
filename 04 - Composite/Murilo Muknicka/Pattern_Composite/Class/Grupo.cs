using Pattern_Composite.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Composite.Class
{
    public class Grupo : IGrupo
    {
        public string Name { get; set; }
        public List<IJogador> Jogadores { get; set; }

        public Grupo()
        {
            Jogadores = new List<IJogador>();
        }

        //Implementando os Gets and Sets da Interface IJogador
        public int Gold
        {
            get
            {
                int totalGold = 0;
                foreach (IJogador Jogador in Jogadores)
                {
                    totalGold += Jogador.Gold;
                }

                return totalGold;
            }
            set
            {
                double eachSplit = value / Jogadores.Count;
                double leftOver = value % Jogadores.Count;
                foreach (IJogador Jogador in Jogadores)
                {
                    Jogador.Gold += (int)(eachSplit + leftOver);
                    leftOver = 0;
                }
            }
        }

        public int Exp
        {
            get
            {
                int totalExp = 0;
                foreach (IJogador Jogador in Jogadores)
                {
                    totalExp += Jogador.Exp;
                }

                return totalExp;
            }
            set
            {
                double eachSplit = value / Jogadores.Count;
                double leftOver = value % Jogadores.Count;
                foreach (IJogador Jogador in Jogadores)
                {
                    Jogador.Exp += (int)(eachSplit + leftOver);
                    leftOver = 0;
                }
            }
        }

        //Implementando os métodos da Interface IJogador
        public void Loot()
        {
            foreach (IJogador Jogador in Jogadores)
            {
                Jogador.Loot();
            }
        }

        public void TotalGold()
        {
            Console.WriteLine("O grupo {0} possui o total de {1} Moedas", Name, Jogadores.Sum(membro => membro.Gold));
        }

        public void TotalExp()
        {
            Console.WriteLine("O grupo {0} possui o total de {1} Experiencia acumulada", Name, Jogadores.Sum(membro => membro.Exp));
        }

    }
}
