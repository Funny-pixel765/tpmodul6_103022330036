using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022330036
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        Random random = new Random();

        public SayaTubeVideo(int id, string title, int playCount)
        {
            this.id = random.Next(1000, 9999);
            this.title = title;
            this.playCount = 0;
        }

        public void increasePlayCount(int view)
        {
            this.playCount += view;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Jumlah views: " + this.playCount);
        }
    }
}

        
