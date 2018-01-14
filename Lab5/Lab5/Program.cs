﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Program.NewEvent += Program.EventHandler;
            if (Program.NewEvent != null) Program.NewEvent("Вызов события");
        }

        public static event NewEventDelegate NewEvent;

        public static void EventHandler(string str)
        {
            Console.WriteLine("Обработчик событий");
        }
    }

    public delegate void NewEventDelegate(string str);
}
