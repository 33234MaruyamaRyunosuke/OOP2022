using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        

        static void Main(string[] args) {

            var songs = new Song[] {
                new Song("タイトル1", "アーティストa", 243),
                new Song("タイトル2", "アーティストb", 226),
                new Song("タイトル3", "アーティストc", 304),
                new Song("タイトル4", "アーティストc", 280),
                new Song("タイトル5", "アーティストe", 319),
            };
            PrintSongs(songs);
        }

        private static void PrintSongs(Song[] songs) {
            foreach(var song in songs) {

            }
        }
    }
}
