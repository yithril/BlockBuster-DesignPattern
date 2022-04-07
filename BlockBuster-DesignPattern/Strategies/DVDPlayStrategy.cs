using BlockBuster_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_DesignPattern.Strategies
{
    public class DVDPlayStrategy : IPlayStrategy
    {
        public void Play(List<string> scenes)
        {
            //This has logic for how to specifically play a dvd
            Console.WriteLine("Select scene to play by number:");

            for(var i = 0; i < scenes.Count; i++)
            {
                Console.WriteLine($"[{i}]: {scenes[i]}");
            }

            int choice = int.Parse(Console.ReadLine());

            PlayMovie(choice, scenes);
        }

        private void PlayMovie(int index, List<string> scenes)
        {
            for(int i = index; i < scenes.Count; i++)
            {
                Console.WriteLine(scenes[i]);
            }
        }
    }
}
