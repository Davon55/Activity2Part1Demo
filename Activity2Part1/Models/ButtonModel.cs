using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2Part1.Models
{
    public class ButtonModel
    {
        public ButtonModel(bool state) 
        {
            State = state;
        }
        public bool State { get; set; }
    }
}
