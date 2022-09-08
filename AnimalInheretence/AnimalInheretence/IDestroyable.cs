using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheretence
{
    interface IDestroyable
    {
        string DesctructionSound { get; set; }
        void Destroy();
    }
}
