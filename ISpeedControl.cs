using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface ISpeedControl
    {
        int CurrentSpeed { get; }      
        int MinSpeed { get; }     
        int MaxSpeed { get; }   
        void SetSpeed(int lv); 
        void IncreaseSpeed();    
        void DecreaseSpeed();  
    }
}
