using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão3
{
    /*Arquivo*/
    class Arquivo
    {
        public string Nome { get; set; }
        public int Paginas { get; set; }

        public Arquivo(string nome, int paginas)
        {
            Nome = nome;
            Paginas = paginas;
        }

        public override string ToString()
        {
            return $"{Nome} {Paginas}";
        }
    }
    
    /*Celula*/
    class Celula
    {
        public Arquivo Elemento { get; set; }
        public Celula Prox { get; set; }

        public Celula(Arquivo elemento)
        {
            this.Elemento = elemento;
            this.Prox = null;
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
        public void Inserir(Arquivo arquivo)
        {
            Celula nova = new Celula(arquivo);
            if (primeiro == null)
            {
                primeiro = ultimo = nova;
            }
            else
            {
                ultimo.Prox = nova;
                ultimo = nova;
            }
        }
        public Arquivo Remover()
        {
            if (primeiro == null)
                throw new Exception("Fila de impressão vazia");

            Arquivo removido = primeiro.Elemento;
            primeiro = primeiro.Prox;
            if (primeiro == null)
                ultimo = null;

            return removido;
        }
        public void Mostrar()
        {
            for (Celula i = primeiro; i != null; i = i.Prox)
            {
                Console.WriteLine(i.Elemento.ToString());
            }
        }
        public bool VrfVazia()
        {
            return primeiro == null;
        }

        /*Main*/
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            int opcao;

            do
            {
                Console.WriteLine("Op:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        string nome = Console.ReadLine();
                        int paginas = int.Parse(Console.ReadLine());
                        Arquivo arquivo = new Arquivo(nome, paginas);
                        fila.Inserir(arquivo);
                        break;

                    case 2:
                        if (fila.VrfVazia())
                        {
                            Console.WriteLine("Fila de impressão vazia");
                        }
                        else
                        {
                            Arquivo impresso = fila.Remover();
                            Console.WriteLine(impresso.Nome);
                        }
                        break;

                    case 3:
                        fila.Mostrar();
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 4);
        }
    }
}
