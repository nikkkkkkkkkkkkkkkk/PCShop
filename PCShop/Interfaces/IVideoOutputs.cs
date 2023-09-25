using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Interfaces
{
    interface IVideoOutputs : IAdditional
    {
        string Description { get; set; }
    }
}
