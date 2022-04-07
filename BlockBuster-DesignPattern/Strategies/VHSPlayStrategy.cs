using BlockBuster_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_DesignPattern.Strategies
{
    public class VHSPlayStrategy : IPlayStrategy
    {
        public void Play(List<string> scenes)
        {
            //Our movies are rewound by our dedicated staff before renting them to customers
            for (int i = 0; i < scenes.Count; i++)
            {
                Console.WriteLine(scenes[i]);
            }
        }
    }
}
