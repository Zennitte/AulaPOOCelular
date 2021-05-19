using System;

namespace Celular_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();

            celular1.cor = "Azul";

            celular1.modelo = "Galaxy S20";

            celular1.tamanho = 6.2f;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Deseja Ligar o Celular: S para sim e N para não");
            string celularLigado = Console.ReadLine().ToUpper();

            do
            {
                if (celularLigado == "S")
                {
                    celular1.Ligar();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(@"
            Qual ação você quer fazer?

            1 - Desligar
            2 - Enviar Mensagem
            3 - Fazer Ligação
            4 - Informações do Dispositivo");

                    string acao = Console.ReadLine();
                    Console.WriteLine();

                    switch (acao)
                    {
                        case "1":
                            celular1.Desligar();
                            break;
                        case "2":
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Para qual contato você quer enviar a mensagem");
                            celular1.contato = Console.ReadLine();

                            Console.WriteLine("Qual a mensagem");
                            string mensagem = Console.ReadLine();

                            Console.WriteLine($"{celular1.EnviarMensagem()}: {mensagem}");
                            break;
                        case "3":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Para qual contato você ligar");
                            celular1.contato = Console.ReadLine();

                            Console.WriteLine($"{celular1.FazerLigacao()}");
                            break;
                        case "4":
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Informações de Dispositivo");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($"Cor: {celular1.cor}");
                            Console.WriteLine($"Modelo: {celular1.modelo}");
                            Console.WriteLine($"Tamanho: {celular1.tamanho}\n");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    celular1.Desligar();
                }
            } while (celular1.ligado == true);

        }
    }
}
