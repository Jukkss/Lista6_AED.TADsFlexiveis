using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão4
{
    /*Celula*/
    class Celula
    {
        public string elemento;
        public Celula prox;

        public Celula(string elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
    }

    /*Fila*/
    class Fila
    {
        private Celula primeiro;
        private Celula ultimo;

        public Fila()
        {
            primeiro = ultimo = null;
        }

        public void Inserir(string nome)
        {
            Celula nova = new Celula(nome);
            if (primeiro == null)
            {
                primeiro = ultimo = nova;
            }
            else
            {
                ultimo.prox = nova;
                ultimo = nova;
            }
        }

        public string Remover()
        {
            if (primeiro == null)
            {
                throw new Exception("Fila vazia");
            }

            string nome = primeiro.elemento;
            primeiro = primeiro.prox;
            if (primeiro == null)
            {
                ultimo = null;
            }
            return nome;
        }

        public void Mostrar()
        {
            Celula i = primeiro;
            while (i != null)
            {
                Console.WriteLine(i.elemento);
                i = i.prox;
            }
        }

        public bool Pesquisar(string nome)
        {
            Celula i = primeiro;
            while (i != null)
            {
                if (i.elemento == nome)
                {
                    return true;
                }
                i = i.prox;
            }
            return false;
        }

        public bool VrfVazia()
        {
            return primeiro == null;
        }

        /*Main*/
        static void Main(string[] args)
        {
            Fila filaIC = new Fila();
            Fila filaMestrado = new Fila();
            int opcao = 0;

            do
            {
                Console.WriteLine("Op:");
                string entrada = Console.ReadLine();
                opcao = int.Parse(entrada);

                switch (opcao)
                {
                    case 1:
                        string nomeIC = Console.ReadLine();
                        filaIC.Inserir(nomeIC);
                        break;

                    case 2:
                        string nomeMestrado = Console.ReadLine();
                        filaMestrado.Inserir(nomeMestrado);
                        break;

                    case 3:
                        try
                        {
                            string removidoIC = filaIC.Remover();
                            Console.WriteLine(removidoIC);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 4:
                        try
                        {
                            string removidoMestrado = filaMestrado.Remover();
                            Console.WriteLine(removidoMestrado);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 5:
                        filaIC.Mostrar();
                        break;

                    case 6:
                        filaMestrado.Mostrar();
                        break;

                    case 7:
                        string buscaIC = Console.ReadLine();
                        Console.WriteLine(filaIC.Pesquisar(buscaIC) ? "S" : "N");
                        break;

                    case 8:
                        string buscaMestrado = Console.ReadLine();
                        Console.WriteLine(filaMestrado.Pesquisar(buscaMestrado) ? "S" : "N");
                        break;

                    case 9:
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 9);
        }
    }
}
