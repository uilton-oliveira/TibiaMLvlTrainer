using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;
using System.Threading;

namespace TibiaMLVL
{
    class TrainMLvl
    {
        const uint WM_KEYDOWN = 0x0100;
        const uint maxCasts = 6;

        [DllImport("User32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        public bool active;
        public bool useManaP;
        private int iterations;
        private IntPtr p;
        private System.Timers.Timer spellTimer;

        public TrainMLvl(String name)
        {
            p = GetWindowHandle(name);

            spellTimer = new System.Timers.Timer();
            spellTimer.Elapsed += new ElapsedEventHandler(SendSpellKey);

            iterations = 0;
            useManaP = false;
        }

        public void StartTimer(int interval, bool mana)
        {
            spellTimer.Interval = interval;
            spellTimer.Enabled = true;
            active = true;
            useManaP = mana;
        }

        public void StopTimer()
        {
            spellTimer.Enabled = false;
            active = false;
        }

        private IntPtr GetWindowHandle(String name)
        {
            return Process.GetProcessesByName(name).FirstOrDefault().MainWindowHandle;
        }

        private void SendSpellKey(object source, ElapsedEventArgs e)
        {
            PostMessage(p, WM_KEYDOWN, (int)Keys.F10, 0);

            if (useManaP)
            {
                iterations++;

                if (iterations == maxCasts)
                {
                    Thread.Sleep(500);
                    PostMessage(p, WM_KEYDOWN, (int)Keys.F11, 0);
                    iterations = 0;
                }
            }
            else
            {
                Thread.Sleep(500);
                PostMessage(p, WM_KEYDOWN, (int)Keys.F11, 0);
            }
        }
    }
}
