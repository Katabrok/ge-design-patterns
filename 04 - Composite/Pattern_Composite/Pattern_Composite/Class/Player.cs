using Pattern_Composite.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Composite.Class
{
    public class Player : IJogador
    {
        public string Name { get; set; }
        public int Gold { get; set; }
        public int Exp { get; set; }

        //Implementando os métodos da Interface IJogador
        public void Loot()
        {
            Console.WriteLine("{0} ganhou {1} em moedas e {2} de experiencia.", Name, Gold, Exp);
        }

        public void TotalGold()
        {
            Console.WriteLine("O jogador {0} possui {1} em moedas.", Name, Gold);
        }

        public void TotalExp()
        {
            Console.WriteLine("O jogador {0} possui {1} de Experiencia.", Name, Exp);
        }
    }
}
