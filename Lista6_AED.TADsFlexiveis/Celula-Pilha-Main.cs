using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6_AED.TADsFlexiveis
{
    using System;

    namespace Lista6_AED.TADsFlexiveis
    {
        class Celula
        {
            private char elemento;
            private Celula prox;

            public Celula(char elemento)
            {
                this.elemento = elemento;
                this.prox = null;
            }

            public Celula()
            {
                this.elemento = '\0';
                this.prox = null;
            }

            public Celula Prox
            {
                get { return this.prox; }
                set { this.prox = value; }
            }

            public char Elemento
            {
                get { return this.elemento; }
                set { this.elemento = value; }
            }
        }

        class Pilha
        {
            private Celula topo;

            public Pilha()
            {
                topo = null;
            }

            public void Inserir(char c)
            {
                Celula tmp = new Celula(c);
                tmp.Prox = topo;
                topo = tmp;
            }

            public char Remover()
            {
                if (topo == null)
                {
                    throw new Exception("Erro!");
                }

                char elemento = topo.Elemento;
                topo = topo.Prox;
                return elemento;
            }

            public bool VrfVazia()
            {
                return topo == null;
            }

            public static bool VrfSeq(string sequencia)
            {
                Pilha pilha = new Pilha();

                foreach (char c in sequencia)
                {
                    if (c == '(' || c == '[')
                    {
                        pilha.Inserir(c);
                    }
                    else if (c == ')' || c == ']')
                    {
                        if (pilha.VrfVazia())
                            return false;

                        char topo = pilha.Remover();

                        if ((c == ')' && topo != '(') || (c == ']' && topo != '['))
                            return false;
                    }
                }
                return pilha.VrfVazia();
            }
            static void Main(string[] args)
            {
                string entrada = Console.ReadLine();
                if (VrfSeq(entrada))
                    Console.WriteLine("correta");
                else
                    Console.WriteLine("errada");
            }
        }
    }
}
