using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ADDBook
{
    public class AltF4Filter : IMessageFilter
    {
        //ALT+F4 키 막기
        public bool PreFilterMessage(ref Message m)
        {
            const int WM_SYSKEYDOWN = 0x0104;
            if(m.Msg == WM_SYSKEYDOWN)
            {
                bool alt = ((int)m.LParam & 0x20000000) != 0;
                if(alt&&(m.WParam == new IntPtr((int)Keys.F4)))
                {
                    Console.WriteLine("ALT+F4 Filtering 됨.");
                }
                return true;
            }
            return false;
        }
    }

    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.AddMessageFilter(new AltF4Filter());
            Application.Run(new FrmLogin());
        }
    }
}
