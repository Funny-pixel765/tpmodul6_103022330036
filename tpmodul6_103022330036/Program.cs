using System;
namespace tpmodul6_103022330036
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo(1, "Tutorial Design By Contract-- Tio Funny", 0);
            video1.increasePlayCount(100);
            Console.WriteLine();
            video1.increasePlayCount(10000);
            video1.printVideoDetails();

        }
    }
}