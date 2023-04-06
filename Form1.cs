using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            //Form2.Show(); // вызов немодального окна (не блокирует рабочий процесс)
            Form2.ShowDialog(); // вызов модального окна (перехватит на себя всё управление (пока не закончим с ней работу нельзя будет перейти на первую))
            
            MessageBox.Show("End of programm");

        }
    }
}
