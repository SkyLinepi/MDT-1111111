using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance
{
    internal interface ISwitchControl
    {
        bool IsOn { get; set; }

        void TurnOn();

        void TurnOff();

    }
}