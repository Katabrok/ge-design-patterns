using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Composite.Interface
{
    public interface IJogador
    {
        int Gold { get; set; }
        int Exp { get; set; }
        void Loot();
        void TotalGold();
        void TotalExp();
    }
}
