using Pattern_Composite.Class;
using Pattern_Composite.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pattern_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            int DungeounGold = 1023;
            int DungeounExp = 6000;

            Console.WriteLine("Parabens pela sua Batalha! A recompensa por essa missão é de {0} Moedas e {1} Experiencia!", DungeounGold, DungeounExp);

            //Criação dos Players
            IJogador Bichao = new Player { Name = "Bichao" };
            IJogador Birl = new Player { Name = "Birl" };

            IJogador SirJosh = new Player { Name = "SirJosh" };
            IJogador SirArthur = new Player { Name = "SirArthur" };

            IJogador AloneWolf = new Player { Name = "AloneWolf" };

            //Criação dos Grupos (Clã)            
            IJogador FamiliaBirl = new Grupo { Name = "The Birls Family", Jogadores = { Bichao, Birl } };
            IJogador Cavaleiros = new Grupo { Name = "Cavaleiros da Tavola Redonda", Jogadores = { SirJosh, SirArthur } };

            //Criação do Party
            IJogador participants = new Grupo { Name = "A Ordem de Falhur", Jogadores = { Cavaleiros, FamiliaBirl, AloneWolf } };

            //Adicionando as recompensas
            participants.Gold += DungeounGold;
            participants.Exp += DungeounExp;
            participants.Loot();

            //Verificando as divisões de Gold
            Console.WriteLine("------------Divisao geral de Gold-----------");
            participants.TotalGold();
            FamiliaBirl.TotalGold();
            Cavaleiros.TotalGold();
            AloneWolf.TotalGold();

            //Verificando as divisões de Exp
            Console.WriteLine("------------Divisao geral de Exp-----------");
            participants.TotalExp();
            FamiliaBirl.TotalExp();
            Cavaleiros.TotalExp();
            AloneWolf.TotalExp();

            Console.ReadKey();
        }
    }
}
