using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Padrão_Strategy___Mortal_Kombat.Program;

namespace Padrão_Strategy___Mortal_Kombat
{
        public abstract class Personagem
        {
            //Qual o tipo ideal para declarar essas variáveis?
            protected string Nome { get; set; } // Essa é a forma ideal para get e set?
            protected int PontosVida { get; set; }
            protected int Forca { get; set; }
            protected int Velocidade { get; set; }

            //Porque ele tem o tipo "Interface"?
            List<IHabilidade> habilidadeAtual = new List<IHabilidade>();

            // Construtor padrão
            public Personagem() {
                Nome = "Desconhecido";
                PontosVida = 0;
                Forca = 0;
                Velocidade = 0;
            }

            // Construtor com parâmetros (opcional)
            public Personagem(string nome, int pontosVida, int forca, int velocidade) {
                Nome = nome;
                PontosVida = pontosVida;
                Forca = forca;
                Velocidade = velocidade;
            }

            public void DefinirHabilidade(IHabilidade habilidade) {
                habilidadeAtual.Add(habilidade);
            }

            public void ativarHabilidade(int numHabilidade) {
                habilidadeAtual[numHabilidade].AtivarHabilidade();
            }

            public void MostrarInfos() {
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("Pontos De Vida: " + PontosVida);
                Console.WriteLine("Força: " + Forca);
                Console.WriteLine("Velocidade: " + Velocidade);
            }

        }
}
