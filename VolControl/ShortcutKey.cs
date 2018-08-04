using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VolControl
{
    class ShortcutKey
    {

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys key);

        public bool keyPressed(int appNumber) {

            if (appNumber == 1)
            {
                //Dash Key
                if (GetAsyncKeyState(Keys.OemMinus) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else {
                //Plus Key
                if (GetAsyncKeyState(Keys.Oemplus) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            

        }


    }
}
