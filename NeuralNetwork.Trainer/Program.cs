using System;
using System.Windows.Forms;

namespace NeuralNetwork.Trainer
{
    class Program
    {
        public static GUI gui;
        public static LoadForm loadForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gui = new GUI();
            loadForm = new LoadForm();
            Application.Run(gui);
        }
    }
}
