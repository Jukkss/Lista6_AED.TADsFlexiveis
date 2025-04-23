using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2
{
    internal class Program
    {
        /*Celula*/
        class Celula
        {
            private int elemento;
            private Celula prox;

            public Celula(int elemento)
            {
                this.elemento = elemento;
                this.prox = null;
            }

            public Celula()
            {
                this.elemento = 0;
                this.prox = null;
            }

            public Celula Prox
            {
                get { return this.prox; }
                set { this.prox = value; }
            }

            public int Elemento
            {
                get { return this.elemento; }
                set { this.elemento = value; }
            }
        }

        /*Pilha*/
        class Pilha 
        {
            private Celula topo;

            public Pilha()
            {
                topo = null;
            }
            public void Inserir(int num)
            {
                Celula tmp = new Celula(num);
                tmp.Prox = topo;
                topo = tmp;
            }
            public int Remover()
            {
                if (topo == null)
                {
                    throw new Exception("Erro!");
                }

                int elemento = topo.Elemento;
                topo = topo.Prox;
                return elemento;
            }

            /*Main*/
            public bool VrfVazia()
            {
                return topo == null;
            }
            static void Main(string[] args)
            {
                string linha;
                while (!string.IsNullOrEmpty(linha = Console.ReadLine()))
                {
                    int numero = int.Parse(linha);
                    Pilha pilha = new Pilha();

                    if (numero == 0)
                    {
                        Console.WriteLine(0);
                        continue;
                    }

                    while (numero > 0)
                    {
                        int resto = numero % 8;
                        pilha.Inserir(resto);
                        numero /= 8;
                    }
                    while (!pilha.VrfVazia())
                    {
                        Console.Write(pilha.Remover());
                    }
                    Console.WriteLine(); 
                }
            }
        }
    }
}
