using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    class Test
    {
        static Product CreateCPU()
        {
            return new Product(100, "Центральний процесор", "Центральный процессор ", "Processor");
        }

        static Product CreateMotherboard()
        {
            return new Product(110, "Материнська плата", "Материнская плата", "Motherboard");
        }

        static Product CreateVideoCard()
        {
            return new Product(200, "Відеокарта", "Видеокарта", "Video card");
        }

        static Product CreateRAM()
        {
            return new Product(50, "Оперативна пам'ять", "Оперативная память", "RAM");
        }

        static Product CreateHardDisk()
        {
            return new Product(60, "Твердий диск", "Жёсткий диск", "Hard disk");
        }

        public static void Main()
        {
            Cart cart = new Cart();

            cart.localization = new UALocalization();
            cart.AddToCart(CreateCPU());
            cart.AddToCart(CreateMotherboard());
            cart.AddToCart(CreateVideoCard());
            cart.AddToCart(CreateRAM());
            cart.AddToCart(CreateHardDisk());
            Console.WriteLine(cart.Buy());

            cart.localization = new RULocalization();
            cart.AddToCart(CreateCPU());
            cart.AddToCart(CreateMotherboard());
            cart.AddToCart(CreateVideoCard());
            cart.AddToCart(CreateRAM());
            cart.AddToCart(CreateHardDisk());
            Console.WriteLine(cart.Buy());

            cart.localization = new USLocalization();
            cart.AddToCart(CreateCPU());
            cart.AddToCart(CreateMotherboard());
            cart.AddToCart(CreateVideoCard());
            cart.AddToCart(CreateRAM());
            cart.AddToCart(CreateHardDisk());
            Console.WriteLine(cart.Buy());

            Console.Read();
        }
    }
}
