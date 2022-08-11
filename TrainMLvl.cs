using System;
using System.Linq;
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

        [DllImport("User32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        public bool active;
        public String processName;
        private int iterations;
        private IntPtr p;
        private System.Timers.Timer spellTimer;

        public TrainMLvl()
        {
            spellTimer = new System.Timers.Timer();
            spellTimer.Elapsed += new ElapsedEventHandler(SendSpellKey);

            iterations = 0;
        }

        public bool StartTimer(int interval)
        {
            p = GetWindowHandle(processName);
            if (p == IntPtr.Zero)
                return false;
            spellTimer.Interval = interval;
            spellTimer.Enabled = true;
            active = true;
            return true;
        }

        public void StopTimer()
        {
            spellTimer.Enabled = false;
            active = false;
        }

        private IntPtr GetWindowHandle(String name)
        {
            Process[] processes = Process.GetProcessesByName(name);
            if (processes.Length == 0)
            {
                MessageBox.Show("Tibia Process not found.");
                return IntPtr.Zero;
            }
            return processes.FirstOrDefault().MainWindowHandle;
        }

        private void SendSpellKey(object source, ElapsedEventArgs e)
        {
            PostMessage(p, WM_KEYDOWN, (int)Keys.F10, 0);
            Thread.Sleep(500);
            PostMessage(p, WM_KEYDOWN, (int)Keys.F11, 0);
        }
    }
}
