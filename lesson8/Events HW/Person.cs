using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HW
{
    delegate string ActionHandler(string subject);

    class Person
    {
        public event ActionHandler SignatureHandler;
        public string FullName { get; set; }
        public bool WantToSing { get; set; }

        public string SingAction()
        {
            if (WantToSing)
            {
                if (SignatureHandler!=null)
                return SignatureHandler(FullName);
            }

            return null;
        }
    }
}
