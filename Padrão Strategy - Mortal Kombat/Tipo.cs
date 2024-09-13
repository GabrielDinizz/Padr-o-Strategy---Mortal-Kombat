using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrão_Strategy___Mortal_Kombat
{

    public class Humano : Personagem
    {
        //Terei que fazer isso em todos? Porque? Sendo que já estou referenciando a classe base.

        // Construtor padrão
        public Humano() : base() {
        }

        // Construtor com parâmetros
        public Humano(string nome, int pontosVida, int forca, int velocidade)
            : base(nome, pontosVida, forca, velocidade) {
        }
   
    }

    public class Monstro : Personagem
    {
        // Construtor padrão
        public Monstro() : base() {
        }

        // Construtor com parâmetros
        public Monstro(string nome, int pontosVida, int forca, int velocidade)
            : base(nome, pontosVida, forca, velocidade) {
        }
    }

    public class Deus : Personagem
    {
        // Construtor padrão
        public Deus() : base() {
        }

        // Construtor com parâmetros
        public Deus(string nome, int pontosVida, int forca, int velocidade)
            : base(nome, pontosVida, forca, velocidade) {
        }
    }


}
