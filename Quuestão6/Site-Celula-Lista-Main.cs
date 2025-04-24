using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quuestão6
{
    /*Site*/
    class Site
    {
        public string Nome { get; set; }
        public string Link { get; set; }

        public Site(string nome, string link)
        {
            Nome = nome;
            Link = link;
        }
    }

    /*Celula*/
    class Celula
    {
        public Site elemento;
        public Celula prox;

        public Celula(Site site)
        {
            elemento = site;
            prox = null;
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

        public void InserirInicio(string nome, string link)
        {
            Site site = new Site(nome, link);
            Celula nova = new Celula(site);
            if (primeiro == null)
            {
                primeiro = ultimo = nova;
            }
            else
            {
                nova.prox = primeiro;
                primeiro = nova;
            }
        }

        public void InserirFim(string nome, string link)
        {
            Site site = new Site(nome, link);
            Celula nova = new Celula(site);
            if (ultimo == null)
            {
                primeiro = ultimo = nova;
            }
            else
            {
                ultimo.prox = nova;
                ultimo = nova;
            }
        }

        public void Inserir(int pos, string nome, string link)
        {
            if (pos == 0)
            {
                InserirInicio(nome, link);
                return;
            }

            Celula i = primeiro;
            for (int j = 0; j < pos - 1 && i != null; j++, i = i.prox) ;

            if (i == null) InserirFim(nome, link);
            else
            {
                Site site = new Site(nome, link);
                Celula nova = new Celula(site);
                nova.prox = i.prox;
                i.prox = nova;
            }
        }

        public string RemoverInicio()
        {
            if (primeiro == null) throw new Exception("Lista vazia");

            string nome = primeiro.elemento.Nome;
            primeiro = primeiro.prox;
            if (primeiro == null) ultimo = null;

            return nome;
        }

        public string RemoverFim()
        {
            if (ultimo == null) throw new Exception("Lista vazia");

            string nome = ultimo.elemento.Nome;
            if (primeiro == ultimo)
            {
                primeiro = ultimo = null;
            }
            else
            {
                Celula penultimo = primeiro;
                while (penultimo.prox != ultimo) penultimo = penultimo.prox;
                ultimo = penultimo;
                ultimo.prox = null;
            }

            return nome;
        }

        public string Remover(int pos)
        {
            if (pos == 0) return RemoverInicio();

            Celula i = primeiro;
            for (int j = 0; j < pos - 1 && i != null; j++, i = i.prox) ;

            if (i == null || i.prox == null) throw new Exception("Posição inválida");

            string nome = i.prox.elemento.Nome;
            i.prox = i.prox.prox;

            return nome;
        }

        public void Mostrar()
        {
            Celula i = primeiro;
            while (i != null)
            {
                Console.WriteLine($"{i.elemento.Nome}: {i.elemento.Link}");
                i = i.prox;
            }
        }

        public string PesquisarLink(string nome)
        {
            Celula i = primeiro;
            while (i != null)
            {
                if (i.elemento.Nome.ToLower() == nome.ToLower())
                {
                    return i.elemento.Link;
                }
                i = i.prox;
            }
            return "N";
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
                        string nome1 = Console.ReadLine();
                        string link1 = Console.ReadLine();
                        lista.InserirInicio(nome1, link1);
                        break;
                    case 2:
                        string nome2 = Console.ReadLine();
                        string link2 = Console.ReadLine();
                        lista.InserirFim(nome2, link2);
                        break;
                    case 3:
                        int pos = Convert.ToInt32(Console.ReadLine());
                        string nome3 = Console.ReadLine();
                        string link3 = Console.ReadLine();
                        lista.Inserir(pos, nome3, link3);
                        break;
                    case 4:
                        Console.WriteLine(lista.RemoverInicio());
                        break;
                    case 5:
                        Console.WriteLine(lista.RemoverFim());
                        break;
                    case 6:
                        Console.WriteLine(lista.Remover(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 7:
                        lista.Mostrar();
                        break;
                    case 8:
                        string nome8 = Console.ReadLine();
                        Console.WriteLine(lista.PesquisarLink(nome8));
                        break;
                    case 9:
                        break;
                }

            } while (opcao != 9);
        }
    }
}
