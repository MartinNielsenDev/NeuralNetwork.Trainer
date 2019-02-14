using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork.Trainer
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(String.Empty))
            {
                string[] dataSplit = textBox1.Text.Replace("{", "").Replace("};", "").Split(',');
                double[] data = new double[dataSplit.Length];

                for (int i = 0; i < dataSplit.Length - 1; i++)
                {
                    if (!double.TryParse(dataSplit[i], out data[i]))
                    {
                        MessageBox.Show("Failed to parse, data invalid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Program.gui.backpropNetwork.LoadFromArray(data);
                this.Hide();
            }
        }

        private void LoadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
