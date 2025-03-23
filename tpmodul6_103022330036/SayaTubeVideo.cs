using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
        Random random = new Random(); // random untuk menginisiasikan id video

        public SayaTubeVideo(string title) // constructor untuk input title dan inisiasi id serta playcount
        {
            
            Debug.Assert(title != null, "Judul tidak boleh kosong");
            Debug.Assert(title.Length <= 100, "Judul tidak boleh lebih dari 100 kata");
             
            this.id = random.Next(10000, 99999); // disini menginput dengan random number
            this.title = title;
            this.playCount = 0; //playcount awal mulai dari 0
        }

        public void increasePlayCount(int views)
        {
            // Method untuk menambah jumlah views dan tidak lebih dari ketentuan yang sudah diberikan
            Debug.Assert(views < 10000000, "Jumlah view harus lebih dari 0 tetapi tidak lebih dari 10.000.000");

            try
            {
                checked // jika terjadi overflow maka akan masuk ke exception
                {
                    if (this.playCount > int.MaxValue - views)
                    {
                        
                        throw new OverflowException(); //jika exception playcount melebihi batas maksimum int
                    }
                    this.playCount += views; //menambahkan views ke playcount
                }
            }
            // exception untuk menghandle overflow jika melebihi batas maksimum int

            catch (OverflowException)
            {
                Console.WriteLine("Terjadi Error! sudah melebihi batas maksimum views");
                // jika melebihi batas maka playcount akan di set ke nilai maksimum int
                this.playCount = int.MaxValue;
            }
        }

        public void printVideoDetails()
        {
            // Method disini untuk menampilkan detail video
            Console.WriteLine("ID : " + this.id);
            Console.WriteLine("Judul Video: " + this.title);
            Console.WriteLine("Jumlah Views: " + this.playCount);
        }

        public int getPlayCount()
        {
            // getter untuk mendapatkan jumlah playcount
            return this.playCount;
        }
    }
}