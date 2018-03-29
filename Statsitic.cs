using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analysis
{
    public class Statsitic
    {
        private string type;
        private double val;


        public Statsitic(string _type)
        {
            this.type = _type;
            this.val = 0.0;
        }

        public Statsitic(string _type, double val)
        {
            this.type = _type;
            this.val = val;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public double Val
        {
            get
            {
                return this.val;
            }
            set
            {
                this.val = value;
            }
        }



    }
}