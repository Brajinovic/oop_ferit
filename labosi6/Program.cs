using System;
using System.Collections.Generic;

namespace labosi6
{
    class Program
    {
        static void Main(string[] args)
        {
            //kreiraj 3 posta
            Dictionary<string, Post> dPosts = new Dictionary<string, Post>();
            dPosts.Add("admin", new Post("Jovan Fitilj", "djes ba, djes ba", new List<string>() { "oop", "ferit", "programiranje" }));
            dPosts.Add("kum", new Post("Kum", "jede pringles, pije pivo", new List<string>() { "pringles", "pivo", "studentskiZivot" }));
            dPosts.Add("ilija", new Post("Ilija", "spava, jede jadru", new List<string>() { "jadro", "spavanje", "studentskiZivot" }));
            //ispis
            Console.WriteLine($"{dPosts["admin"].ToString()}");
            Console.WriteLine($"{dPosts["kum"].ToString()}");
            Console.WriteLine($"{dPosts["ilija"].ToString()}");
            //duboko kopiranje
            List<Post> lPosts = new List<Post>();
            foreach(string key in new List<string>() { "admin", "kum", "ilija" })
            {
                lPosts.Add(new Post(dPosts[key]));
                
            }
            //obrisi tagove i ispisi clonove
            foreach (Post post in lPosts)
            {
                post.Hashtags.Clear();
                Console.WriteLine($"{post.ToString()}");
            }
            //isprintaj originale
            Console.WriteLine($"{dPosts["admin"].ToString()}");
            Console.WriteLine($"{dPosts["kum"].ToString()}");
            Console.WriteLine($"{dPosts["ilija"].ToString()}");



        }
    }
}
