using System;
using PracticaDobosh.DAL.Context;

namespace PracticaDobosh
{
    internal class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    
    }
}