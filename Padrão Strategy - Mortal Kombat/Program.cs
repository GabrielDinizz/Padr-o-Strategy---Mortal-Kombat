using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrão_Strategy___Mortal_Kombat
{
    internal class Program
    {

        public class Personagem
        {
            public string Nome { get; protected set; } // Agora é pública para leitura, protegida para escrita
            protected int PontosVida;
            protected int Forca;
            protected int Velocidade;

            // Construtor padrão
            public Personagem()
            {
                Nome = "Desconhecido";
                PontosVida = 0;
                Forca = 0;
                Velocidade = 0;
            }

            // Construtor com parâmetros (opcional)
            public Personagem(string nome, int pontosVida, int forca, int velocidade)
            {
                Nome = nome;
                PontosVida = pontosVida;
                Forca = forca;
                Velocidade = velocidade;
            }

            public void MostrarInfos() {
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("Pontos De Vida: " + PontosVida);
                Console.WriteLine("Força: " + Forca);
                Console.WriteLine("Velocidade: " + Velocidade);
            }

        }

        public class Humano : Personagem
        {

        }

        public class Monstro : Personagem
        {

        }

        public class Deus : Personagem
        {

        }



        static void Main(string[] args)
        {

        }
    }
}
