using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloCShaprWorld
{
    public partial class MainHWindow : Form
    {
        public MainHWindow()
        {
            InitializeComponent();
        }

        private void button_goodby_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, Glad to see you ! )))");
        }

        private void button_talk_Click(object sender, EventArgs e)
        {
            if (textBox_dialog.Visible)
            {
                textBox_dialog.Visible = false;
                label_dialog.Visible = false;
                button_talk.Text = "Let's talk";
            }else
            {
                textBox_dialog.Visible = true;
                label_dialog.Visible = true;
                button_talk.Text = "Stop talking";
            }
        }

        private void textBox_dialog_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\r')
            {
                DateTime now = System.DateTime.UtcNow;
                if (now.Millisecond < 100)
                    textBox_dialog.AppendText("\r\n - Понятно!");
                else if (now.Millisecond < 200)
                    textBox_dialog.AppendText("\r\n - Вы уверены?");
                else if (now.Millisecond < 300)
                    textBox_dialog.AppendText("\r\n - А ведь я так и думал!");
                else if (now.Millisecond < 400)
                    textBox_dialog.AppendText("\r\n - Да что вы говорите!");
                else if (now.Millisecond < 500)
                    textBox_dialog.AppendText("\r\n - Но это не точно.");
                else if (now.Millisecond < 600)
                    textBox_dialog.AppendText("\r\n - Так точно!");
                else if (now.Millisecond < 700)
                    textBox_dialog.AppendText("\r\n - Никак нет!");
                else if (now.Millisecond < 800)
                    textBox_dialog.AppendText("\r\n - Вы всё-таки думайте, что говорите!");
                else if (now.Millisecond < 900)
                    textBox_dialog.AppendText("\r\n - Нет, на это я пойти не могу!");
                else //if (now.Millisecond < 90)
                    textBox_dialog.AppendText("\r\n - Так бы сразу и сказали!");
            }
        }

    }
}
