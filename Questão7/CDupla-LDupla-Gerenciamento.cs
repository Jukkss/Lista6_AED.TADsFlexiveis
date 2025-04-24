using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão7
{
    /*Cdupla*/
    class CelulaDupla
    {
        public string Musica;
        public CelulaDupla Ant;
        public CelulaDupla Prox;

        public CelulaDupla(string musica)
        {
            Musica = musica;
            Ant = null;
            Prox = null;
        }
    }

    /*LDupla*/
    class ListaDupla
    {
        private CelulaDupla primeiro;
        private CelulaDupla ultimo;

        public ListaDupla()
        {
            primeiro = ultimo = null;
        }

        public void InserirFinal(string musica)
        {
            CelulaDupla nova = new CelulaDupla(musica);
            if (ultimo == null)
            {
                primeiro = ultimo = nova;
            }
            else
            {
                ultimo.Prox = nova;
                nova.Ant = ultimo;
                ultimo = nova;
            }
        }

        public void InserirInicio(string musica)
        {
            CelulaDupla nova = new CelulaDupla(musica);
            if (primeiro == null)
            {
                primeiro = ultimo = nova;
            }
            else
            {
                nova.Prox = primeiro;
                primeiro.Ant = nova;
                primeiro = nova;
            }
        }

        public void InserirPosicao(int posicao, string musica)
        {
            if (posicao <= 1)
            {
                InserirInicio(musica);
            }
            else
            {
                CelulaDupla temp = primeiro;
                for (int i = 1; i < posicao - 1 && temp != null; i++)
                {
                    temp = temp.Prox;
                }
                if (temp != null)
                {
                    CelulaDupla nova = new CelulaDupla(musica);
                    nova.Prox = temp.Prox;
                    if (temp.Prox != null)
                        temp.Prox.Ant = nova;
                    temp.Prox = nova;
                    nova.Ant = temp;
                    if (nova.Prox == null)
                        ultimo = nova;
                }
            }
        }

        public void RemoverInicio()
        {
            if (primeiro != null)
            {
                Console.WriteLine(primeiro.Musica);
                primeiro = primeiro.Prox;
                if (primeiro != null)
                    primeiro.Ant = null;
                else
                    ultimo = null;
            }
        }

        public void RemoverFinal()
        {
            if (ultimo != null)
            {
                Console.WriteLine(ultimo.Musica);
                ultimo = ultimo.Ant;
                if (ultimo != null)
                    ultimo.Prox = null;
                else
                    primeiro = null;
            }
        }

        public void RemoverPosicao(int posicao)
        {
            CelulaDupla temp = primeiro;
            for (int i = 1; i < posicao && temp != null; i++)
            {
                temp = temp.Prox;
            }
            if (temp != null)
            {
                Console.WriteLine(temp.Musica);
                if (temp.Ant != null)
                    temp.Ant.Prox = temp.Prox;
                if (temp.Prox != null)
                    temp.Prox.Ant = temp.Ant;
                if (temp == primeiro)
                    primeiro = temp.Prox;
                if (temp == ultimo)
                    ultimo = temp.Ant;
            }
        }

        public bool RemoverMusica(string musica)
        {
            CelulaDupla temp = primeiro;
            while (temp != null)
            {
                bool iguais = true;
                if (temp.Musica.Length == musica.Length)
                {
                    for (int i = 0; i < temp.Musica.Length; i++)
                    {
                        if (temp.Musica[i] != musica[i])
                        {
                            iguais = false;
                            break;
                        }
                    }
                }
                else
                {
                    iguais = false;
                }

                if (iguais)
                {
                    Console.WriteLine("S");
                    if (temp.Ant != null)
                        temp.Ant.Prox = temp.Prox;
                    if (temp.Prox != null)
                        temp.Prox.Ant = temp.Ant;
                    if (temp == primeiro)
                        primeiro = temp.Prox;
                    if (temp == ultimo)
                        ultimo = temp.Ant;
                    return true;
                }
                temp = temp.Prox;
            }
            Console.WriteLine("N");
            return false;
        }

        public void Mostrar()
        {
            CelulaDupla temp = primeiro;
            while (temp != null)
            {
                Console.WriteLine(temp.Musica);
                temp = temp.Prox;
            }
        }

        public void MostrarInverso()
        {
            CelulaDupla temp = ultimo;
            while (temp != null)
            {
                Console.WriteLine(temp.Musica);
                temp = temp.Ant;
            }
        }

        public bool Pesquisar(string musica)
        {
            CelulaDupla temp = primeiro;
            while (temp != null)
            {
                bool iguais = true;
                if (temp.Musica.Length == musica.Length)
                {
                    for (int i = 0; i < temp.Musica.Length; i++)
                    {
                        if (temp.Musica[i] != musica[i])
                        {
                            iguais = false;
                            break;
                        }
                    }
                }
                else
                {
                    iguais = false;
                }

                if (iguais)
                    return true;
                temp = temp.Prox;
            }
            return false;
        }

        public string PesquisarAnt(string musica)
        {
            CelulaDupla temp = primeiro;
            while (temp != null)
            {
                bool iguais = true;
                if (temp.Musica.Length == musica.Length)
                {
                    for (int i = 0; i < temp.Musica.Length; i++)
                    {
                        if (temp.Musica[i] != musica[i])
                        {
                            iguais = false;
                            break;
                        }
                    }
                }
                else
                {
                    iguais = false;
                }

                if (iguais)
                {
                    if (temp.Ant != null)
                        return temp.Ant.Musica;
                    else
                        return "N";
                }
                temp = temp.Prox;
            }
            return "N";
        }

        public string PesquisarPosterior(string musica)
        {
            CelulaDupla temp = primeiro;
            while (temp != null)
            {
                bool iguais = true;
                if (temp.Musica.Length == musica.Length)
                {
                    for (int i = 0; i < temp.Musica.Length; i++)
                    {
                        if (temp.Musica[i] != musica[i])
                        {
                            iguais = false;
                            break;
                        }
                    }
                }
                else
                {
                    iguais = false;
                }

                if (iguais)
                {
                    if (temp.Prox != null)
                        return temp.Prox.Musica;
                    else
                        return "N";
                }
                temp = temp.Prox;
            }
            return "N";
        }
    }

    /*Gerenciamento*/
    class GerenciadorMusica
    {
        static void Main(string[] args)
        {
            ListaDupla lista = new ListaDupla();
            int opcao;
            do
            {
                Console.WriteLine("Op:");
                string entrada = Console.ReadLine();
                opcao = int.Parse(entrada);

                switch (opcao)
                {
                    case 1:
                        string musica1 = Console.ReadLine();
                        lista.InserirFinal(musica1);
                        break;

                    case 2:
                        string musica2 = Console.ReadLine();
                        lista.InserirInicio(musica2);
                        break;

                    case 3:
                        int pos = int.Parse(Console.ReadLine());
                        string musica3 = Console.ReadLine();
                        lista.InserirPosicao(pos, musica3);
                        break;

                    case 4:
                        lista.RemoverInicio();
                        break;

                    case 5:
                        lista.RemoverFinal();
                        break;

                    case 6:
                        int posRem = int.Parse(Console.ReadLine());
                        lista.RemoverPosicao(posRem);
                        break;

                    case 7:
                        string musicaRemover = Console.ReadLine();
                        lista.RemoverMusica(musicaRemover);
                        break;

                    case 8:
                        lista.Mostrar();
                        break;

                    case 9:
                        lista.MostrarInverso();
                        break;

                    case 10:
                        string musicaPesquisar = Console.ReadLine();
                        if (lista.Pesquisar(musicaPesquisar))
                            Console.WriteLine("S");
                        else
                            Console.WriteLine("N");
                        break;

                    case 11:
                        string musicaAnt = Console.ReadLine();
                        Console.WriteLine(lista.PesquisarAnt(musicaAnt));
                        break;

                    case 12:
                        string musicaPosterior = Console.ReadLine();
                        Console.WriteLine(lista.PesquisarPosterior(musicaPosterior));
                        break;

                    case 13:
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 13);
        }
    }
}
