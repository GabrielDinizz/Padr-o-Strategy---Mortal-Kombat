using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrão_Strategy___Mortal_Kombat
{
    public interface IHabilidade
    {
        void AtivarHabilidade();

    }

    public class Congelamento : IHabilidade
    {
        public void AtivarHabilidade() {
            Console.WriteLine($"Habilidade de Congelamento ativada. ");
        }
    }

    public class Atirar : IHabilidade
    {
        public void AtivarHabilidade() {
            Console.Write("Habilidade de Atirar ativada.  +");
        }
    }

    public class Teletransportar : IHabilidade
    {
        public void AtivarHabilidade() {
            Console.WriteLine($"Habilidade de teletransportar ativada. ");
        }
    }
}
