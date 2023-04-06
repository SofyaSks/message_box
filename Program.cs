using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        // 1
        /* static DialogResult ShowMesageBox()
        {
           string message = "Window show text";
            string caption = "Window with two buttons";
            DialogResult res = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);
            string button = res.ToString();

            res = MessageBox.Show($"You presseed button {button}. Retry? ", button, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);

            return res;
        }*/

        // 2
       /* static DialogResult ShowMesageBox()
        {
            DialogResult res = MessageBox.Show("Error. No disk access", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            if(res == DialogResult.Abort)
            {
                MessageBox.Show("You pressed button abort");
            }
            else if (res == DialogResult.Retry)
            {
                MessageBox.Show("You pressed button retry");
            }
            else if (res == DialogResult.Ignore)
            {
                MessageBox.Show("You pressed button ignore");
            }

            return res;
        }*/


        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            // 1

            /*DialogResult result;
            do
            {
                result = ShowMesageBox();
            } while (result == DialogResult.Retry);*/

            // 2

            /* DialogResult result;
             do
             {
                 result = ShowMesageBox();
             } while (result != DialogResult.Abort);*/

            // Модальное и немодальное окно
        }
    }

}
