using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão5
{
    internal class Program
    {
        /*Celula*/
        class Celula
        {
            public double elemento;
            public Celula ant, prox;

            public Celula(double elemento)
            {
                this.elemento = elemento;
                this.ant = null;
                this.prox = null;
            }
        }

        /*Lista*/
        class Lista
        {
            private Celula primeiro, ultimo;

            public Lista()
            {
                primeiro = ultimo = null;
            }

            public void InserirInicio(double x)
            {
                Celula nova = new Celula(x);
                if (primeiro == null)
                {
                    primeiro = ultimo = nova;
                }
                else
                {
                    nova.prox = primeiro;
                    primeiro.ant = nova;
                    primeiro = nova;
                }
            }

            public void InserirFim(double x)
            {
                Celula nova = new Celula(x);
                if (ultimo == null)
                {
                    primeiro = ultimo = nova;
                }
                else
                {
                    ultimo.prox = nova;
                    nova.ant = ultimo;
                    ultimo = nova;
                }
            }

            public void Inserir(double x, int pos)
            {
                if (pos == 0)
                {
                    InserirInicio(x);
                }
                else
                {
                    Celula i = primeiro;
                    for (int j = 0; j < pos - 1 && i != null; j++, i = i.prox) ;
                    if (i == null || (i == ultimo && pos > 0)) InserirFim(x);
                    else
                    {
                        Celula nova = new Celula(x);
                        nova.prox = i.prox;
                        nova.ant = i;
                        if (i.prox != null) i.prox.ant = nova;
                        i.prox = nova;
                    }
                }
            }

            public double RemoverInicio()
            {
                if (primeiro == null) throw new Exception("Lista vazia");
                double elemento = primeiro.elemento;
                if (primeiro == ultimo) primeiro = ultimo = null;
                else
                {
                    primeiro = primeiro.prox;
                    primeiro.ant = null;
                }
                return elemento;
            }

            public double RemoverFim()
            {
                if (ultimo == null) throw new Exception("Lista vazia");
                double elemento = ultimo.elemento;
                if (primeiro == ultimo) primeiro = ultimo = null;
                else
                {
                    ultimo = ultimo.ant;
                    ultimo.prox = null;
                }
                return elemento;
            }

            public double Remover(int pos)
            {
                if (pos == 0) return RemoverInicio();
                Celula i = primeiro;
                for (int j = 0; j < pos && i != null; j++, i = i.prox) ;
                if (i == null) throw new Exception("Posição inválida");
                if (i == ultimo) return RemoverFim();

                double elemento = i.elemento;
                i.ant.prox = i.prox;
                i.prox.ant = i.ant;
                return elemento;
            }

            public void RemoverItem(double x)
            {
                Celula i = primeiro;
                while (i != null)
                {
                    if (i.elemento == x)
                    {
                        if (i == primeiro) { RemoverInicio(); return; }
                        else if (i == ultimo) { RemoverFim(); return; }
                        else
                        {
                            i.ant.prox = i.prox;
                            i.prox.ant = i.ant;
                            return;
                        }
                    }
                    i = i.prox;
                }
            }

            public int Contar(double x)
            {
                int cont = 0;
                for (Celula i = primeiro; i != null; i = i.prox)
                {
                    if (i.elemento == x) cont++;
                }
                return cont;
            }

            public void Mostrar()
            {
                for (Celula i = primeiro; i != null; i = i.prox)
                {
                    Console.WriteLine(i.elemento);
                }
            }

            /*Main*/
            static void Main(string[] args)
            {
                Lista lista = new Lista();
                int opcao = 0;
                do
                {
                    Console.WriteLine("Op:");
                    string entrada = Console.ReadLine();
                    opcao = int.Parse(entrada);
                  
                    switch (opcao)
                    {
                        case 1:
                            lista.InserirInicio(double.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            lista.InserirFim(double.Parse(Console.ReadLine()));
                            break;
                        case 3:
                            double tempo = double.Parse(Console.ReadLine());
                            int pos = int.Parse(Console.ReadLine());
                            lista.Inserir(tempo, pos);
                            break;
                        case 4:
                            Console.WriteLine(lista.RemoverInicio());
                            break;
                        case 5:
                            Console.WriteLine(lista.RemoverFim());
                            break;
                        case 6:
                            Console.WriteLine(lista.Remover(int.Parse(Console.ReadLine())));
                            break;
                        case 7:
                            lista.RemoverItem(double.Parse(Console.ReadLine()));
                            break;
                        case 8:
                            Console.WriteLine(lista.Contar(double.Parse(Console.ReadLine())));
                            break;
                        case 9:
                            lista.Mostrar();
                            break;
                    }

                } while (opcao != 10);
            }
        }
    }
}
