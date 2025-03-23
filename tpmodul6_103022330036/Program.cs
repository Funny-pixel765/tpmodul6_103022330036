using System;
namespace tpmodul6_103022330036
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract-- Tio Funny");
                video1.printVideoDetails();
                Console.WriteLine();
                for (int i = 0; i < 1000; i++) //perulangan untuk menambahkan jumlah view sebanyak 1000
                {
                    video1.increasePlayCount(1000000);
                    video1.printVideoDetails();
                    Console.WriteLine();
                    if (video1.getPlayCount() == int.MaxValue) // berfungsi membatasi perulangan jika jumlah view sudah dibatas maksimum
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error! " + e.Message);
            }
        }
    }
}