using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolog_Final
{
    public partial class Message : Form
    {
        Jeopardy MainView = Jeopardy.Instance;
        Clases.PLQuerys Handler = Clases.PLQuerys.Instance;
        private int sec = 0;
        private string Pregunta;
        private string Cat;
        public static int score;

        public Message(string Categoria,string Question)
        {
            InitializeComponent();
            bt_Send.Visible = false;
            txt_Answer.Visible = false;
            Pregunta = Question;
            Cat = Categoria;
            sec = Handler.Get_Category(Cat);
        }

        

        public string GetAnswer()
        {
            return txt_Answer.Text;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            LB_Text.Text = sec.ToString();
            if(sec == 0)
            {
                //Robot
                timer1.Stop();
                MessageBox.Show(Handler.Get_MachineAnswer("timeout"));
                MainView.Valores_CPU += Handler.Point_Answer(Pregunta, Cat);
                MainView.Counter_ToWin++;
                MainView.Update_All();
                if (MainView.Counter_ToWin != 25 && MainView.Counter_ToWin != 26)
                MainView.Show();
                this.Close();
            }
        }

        private void Message_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            timer1.Start();
            label1.Text = Handler.Get_Question(Cat,Pregunta);
        }

        private void bt_Msg_Click(object sender, EventArgs e)
        {
            txt_Answer.Visible = true;
            bt_Send.Visible = true;
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            
            if(Handler.Answer(Pregunta, Cat, txt_Answer.Text) =="correcto")
            {
                timer1.Stop();
                MessageBox.Show(Handler.Answer(Pregunta, Cat, txt_Answer.Text));
                MainView.Valores += Handler.Point_Answer(Pregunta, Cat);
                MainView.Counter_ToWin++;
                MainView.Update_All();
                if(MainView.Counter_ToWin!=25 && MainView.Counter_ToWin!=26)
                MainView.Show();
                this.Close();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show(Handler.Answer(Pregunta, Cat, txt_Answer.Text) + ".Es Turno de la Maquina");
                //Robot
                MessageBox.Show(Handler.Get_MachineAnswer(Handler.Answer(Pregunta, Cat, txt_Answer.Text)));
                MainView.Valores_CPU += Handler.Point_Answer(Pregunta, Cat);
                MainView.Counter_ToWin++;
                MainView.Update_All();
                if (MainView.Counter_ToWin != 25 && MainView.Counter_ToWin != 26)
                MainView.Show();
                    this.Close();
            }
        }

        private void Message_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
