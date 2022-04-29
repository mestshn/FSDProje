using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDProje
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string input;
            Map marsMap;
            MarsRover pars;
            MarsRover pardus;

            while (true)
            {
                Console.WriteLine("Harita büyüklüğünü giriniz:");
                input = Console.ReadLine();
                string[] mapsize = input.Split(' ');
                if (mapsize.Length != 2)
                {
                    Console.WriteLine("Harita büyüklüğünü hatalı girdiniz.");
                    continue;
                }

                try
                {
                    marsMap = new Map(Convert.ToInt32(mapsize[0]), Convert.ToInt32(mapsize[1]));
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Harita büyüklüğünü hatalı girdiniz.");
                }
            }

            int x;
            int y;
            char direction;

            while (true)
            {
                Console.WriteLine("1. Rover' ı konumlandırınız. Örn:1 3 N");
                input = Console.ReadLine();
                string[] inputs = input.Split(' ');
                if (inputs.Length != 3)
                {
                    Console.WriteLine("1. Rover' ın konumunu yanlış girdiniz.");
                    continue;
                }

                if (!inputs[2].Equals("N") && !inputs[2].Equals("E") && !inputs[2].Equals("S") && !inputs[2].Equals("W"))
                {
                    Console.WriteLine("1. Rover' ın konumunu yanlış girdiniz.");
                    continue;
                }
                direction = inputs[2][0];

                if (!Int32.TryParse(inputs[0], out x))
                {
                    Console.WriteLine("1. Rover' ın konumunu yanlış girdiniz.");
                    continue;
                }

                if (!Int32.TryParse(inputs[1], out y))
                {
                    Console.WriteLine("1. Rover' ın konumunu yanlış girdiniz.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("1. Rover' ın komutlarını giriniz. Örn:M R L");
                input = Console.ReadLine();
                string[] inputs = input.Split(' ');
                bool validation = true;

                for (int i = 0; i < inputs.Length; i++)
                {
                    if (!inputs[i].Equals("M") && !inputs[i].Equals("R") && !inputs[i].Equals("L"))
                    {
                        validation = false;
                        break;
                    }
                }

                if (!validation)
                {
                    Console.WriteLine("Hatalı komut girdiniz.");
                    continue;
                }

                List<char> commands = new List<char>();

                for (int i = 0; i < inputs.Length; i++)
                {
                    commands.Add(inputs[i][0]);
                }

                pars = new MarsRover(x, y, direction, commands, "Pars");
                break;
            }

            while (true)
            {
                Console.WriteLine("2. Rover' ı konumlandırınız. Örn:1 3 N");
                input = Console.ReadLine();
                string[] inputs = input.Split(' ');
                if (inputs.Length != 3)
                {
                    Console.WriteLine("2. Rover' ın konumunu yanlış girdiniz.");
                    continue;
                }

                if (!inputs[2].Equals("N") && !inputs[2].Equals("E") && !inputs[2].Equals("S") && !inputs[2].Equals("W"))
                {
                    Console.WriteLine("2. Rover' ın konumunu yanlış girdiniz.");
                    continue;
                }
                direction = inputs[2][0];

                if (!Int32.TryParse(inputs[0], out x))
                {
                    Console.WriteLine("2. Rover' ın konumunu yanlış girdiniz.");
                    continue;
                }

                if (!Int32.TryParse(inputs[1], out y))
                {
                    Console.WriteLine("2. Rover' ın konumunu yanlış girdiniz.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("2. Rover' ın komutlarını giriniz. Örn:M R L");
                input = Console.ReadLine();
                string[] inputs = input.Split(' ');
                bool validation = true;

                for (int i = 0; i < inputs.Length; i++)
                {
                    if (!inputs[i].Equals("M") && !inputs[i].Equals("R") && !inputs[i].Equals("L"))
                    {
                        validation = false;
                        break;
                    }
                }

                if (!validation)
                {
                    Console.WriteLine("Hatalı komut girdiniz.");
                    continue;
                }

                List<char> commands = new List<char>();

                for (int i = 0; i < inputs.Length; i++)
                {
                    commands.Add(inputs[i][0]);
                }

                pardus = new MarsRover(x, y, direction, commands, "Pardus");
                pars.RegisterObserver(pardus);
                break;
            }

            Console.WriteLine("Roverlar harekete geçiyor");
            pars.StartRover();
            Console.WriteLine(pars.GetStatus());
            Console.WriteLine(pardus.GetStatus());
            Console.ReadKey();

        }
    }
}
