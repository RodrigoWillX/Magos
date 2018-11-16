using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago gandalf = new Mago("Gandalf", 100, 30, 60, 100, 200);
            

            //Chama metodo atacar do objeto Gandalf
            gandalf.Atacar();
            gandalf.Defender("Saruman");
            gandalf.Defender("Mia");
            gandalf.Mover(2);
            Console.WriteLine(gandalf.Mover(2));

            //metodo de lancar magia
            gandalf.LancarMagia("Saruman");

            Console.WriteLine("Dano da magia de Gandalf " + gandalf.LancarMagia("Saruman"));

            //Cria objeto mago saruman
            Mago saruman = new Mago("Saruman", 120, 40, 70, 80, 180);
            

            //Chama metodo atacar do objeto Saruman
            saruman.Atacar();
            saruman.Defender("Mia");
            saruman.Defender("Gandalf");
            saruman.Mover(0);
            Console.WriteLine(saruman.Mover(0));

            //Cria objeto mago Mia 
            Mago mia = new Mago("Mia", 150, 90, 100, 120, 250);
            

            //Chama metodo atacar do objeto Saruman
            mia.Atacar();
            mia.Defender("Saruman");
            mia.Defender("Gandalf");
            mia.Mover(1);
            Console.WriteLine(mia.Mover(1));

            Console.ReadLine();
        }
    }
}
