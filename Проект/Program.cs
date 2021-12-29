using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage2.Forms;

namespace Storage2
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FAuth());
        }

        //выводит сообщение пользователю с текстом ошибки
        public static void Log(Exception ex, string from = "")
        { MessageBox.Show($"{from}{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //выводит сообщение пользователю с обычной информацией
        public static void Log(string text)
        { MessageBox.Show(text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        //копирует строку в буфер обмена
        public static void Copy(params object[] values)
        { Clipboard.SetText(String.Join(";", values)); }

        //очишает память
        public static void Clear()
        { GC.Collect(); GC.WaitForPendingFinalizers(); GC.Collect(); }
    }
}
