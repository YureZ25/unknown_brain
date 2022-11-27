using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UB.Data.Domain
{
    public class WelcomeForm : Entity
    {
        public bool IsPM { get; set; }

        public bool IsDocWriter { get; set; }

        public User User { get; set; }

        public Specialization Specialization { get; set; }

        public Grade Grade { get; set; }

        public string Comment { get; set; }
    }
}
