namespace Exercise_45
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    public static class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr frgWnd, out uint frgWndProcessId);

        private static void Main()
        {
            var processTitel = "";

            while (true)
            {
                var currentProcess = Process.GetCurrentProcess();
                var fw = GetForegroundWindow();

                GetWindowThreadProcessId(fw, out var processId);

                var actualProcess = Process.GetProcessById(Convert.ToInt32(processId)).MainWindowTitle;

                var processName = Process.GetProcessById(Convert.ToInt32(processId)).ProcessName;

                if (processId == currentProcess.Id || processName == "explorer" || actualProcess == processTitel || actualProcess == "")
                {
                    continue;
                }
                processTitel = actualProcess;


                Console.WriteLine("Fenstername: " + processTitel);
                Console.WriteLine("Prozessname: " + processName + "\n");
            }
            // ReSharper disable once FunctionNeverReturns
        }
    }
}