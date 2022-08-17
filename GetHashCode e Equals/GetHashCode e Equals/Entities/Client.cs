using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

      
        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client Other = obj as Client;
            return Email.Equals(Other.Email);
        }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }

    }
}
