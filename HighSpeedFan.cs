using System;
using System.Collections.Generic;

namespace Appliance
{
    internal class Fan : ISwitchControl, ISpeedControl
    {
        private int CurrentSpeed = 0;
        bool _isOn;
        public bool IsOn
        private int MaxS = 200;
        private int MinS = 100;
        {
            get => _isOn;

            set => _isOn = value;
        }

        public void TurnOn()

        {
            _isOn = true;
            CurrentSpeed = MinS;
            Console.WriteLine("Fan is turning at a rate of "+ CurrentSpeed);
        }

        public void TurnOff()
        {
            _isOn = true;
            CurrentSpeed = 0;
            Console.WriteLine("Fan gave up");
        }

        private void IncreaseS()
        {
            CurrentSpeed = MaxS;
        }

        public void DecreaseS()
        {
            CurrentSpeed = MinS;
        }
    }
}