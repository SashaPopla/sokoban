using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public struct Place
    {
        public int x;
        public int y;

        public Place(int ax, int ay)
        {
            x = ax;
            y = ay;
        }
    }

    public enum Cell
    {
        none,
        wall,
        user,
        abox,
        here,
        done
    };
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WalcomeForm());
        }
    }
}
