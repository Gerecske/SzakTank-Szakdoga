using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzakTank2._0
{
    internal class Command
    {
        private string _CommandName;

        public string CommandName
        {
            get { return _CommandName; }
            set 
            {
                _CommandName = value;
            }
        }


        private int _CommandValue;

        public int CommandValue
        {
            get { return _CommandValue; }
            set { _CommandValue = value; }
        }


    }
}
