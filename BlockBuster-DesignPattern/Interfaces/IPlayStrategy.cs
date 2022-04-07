using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_DesignPattern.Interfaces
{
    public interface IPlayStrategy
    {
        void Play(List<string> scenes);
    }
}
