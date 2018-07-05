using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolControl
{
    class _App
    {

        private string _Name;
        private List<int> _ProID = new List<int>();
        private float? _OriginalVol;

        public _App(string Name, int ProID ){

            _Name = Name;
            _ProID.Add(ProID);

        }

        public void AddId(int ProID) { 
            _ProID.Add(ProID);
        }

        public string Name{ 
                get { return _Name; }
        }

        public List<int> ProID {
            get { return _ProID; }
        }

        public void Output() {

            Console.Write(_Name);

            foreach(int a in _ProID) {
                Console.Write(" ID:" + a.ToString());

            }
            Console.Write("\r\n");
        }

    }
}
