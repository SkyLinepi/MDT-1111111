using System;
using System.Collections.Generic;

namespace Appliance
{
    internal class Fan : ISwitchControl
    {
        public float RotateSpeed = 190f;
        bool _isOn;
        public bool IsOn
        {
            get => _isOn;

            set => _isOn = value;
        }

        public void TurnOn()

        {
            _isOn = true;
            Console.WriteLine("Fan is turning at a rate of "+ RotateSpeed);
        }

        public void TurnOff()
        {
            _isOn = true;
            Console.WriteLine("Fan gave up");
        }
    }
}