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
    public partial class Jeopardy : Form
    {
         private static Jeopardy instance;
        public static Jeopardy Instance
        {
          get 
             {
              if (instance == null)
                           {
                             instance = new Jeopardy();
                           }
         return instance;
             }
        }

        
        Clases.PLQuerys Handler = Clases.PLQuerys.Instance;
        string Categoria;
        string Puntajes;
        public int  Valores;
        public int Valores_CPU;
        public int Counter_ToWin=0;
        //System.Media.SoundPlayer Sounds = new System.Media.SoundPlayer(@"C:\Users\Hector\Desktop\Prolog_Final\Dragon_Ball_Opening_Latino_HD_720p.wav");
        private Jeopardy()
        {
            InitializeComponent();
            bt_desempate.Visible = false;
            Handler.Prolog_Connection();
            //Sounds.Play();
        }

        public void Cambiar(string Cat, string val)
        {
            Message frm = new Message(Cat,val);
            frm.Show();
            this.Hide();
        }

       public void Update_All()
        { 
            lb_Player_Score.Text = "$" + Valores;
            lb_CPU_Score.Text = "$" + Valores_CPU;
            Winner(Counter_ToWin);
        }

        public void Winner(int c)
       {
            if(c == 25)
            {
                if (Valores > Valores_CPU)
                {
                    MessageBox.Show("Felicidades Ganaste");
                    this.Close();
                }
                else if(Valores == Valores_CPU)
                {
                    bt_desempate.Visible = true; 
                }
                else if(Valores < Valores_CPU);
                {
                    MessageBox.Show("Buen intento. El Ganador es la Maquina. Suerte en la Proxima");
                    this.Close();
                }
            }
            else if(c == 26)
            {
                if(Valores > Valores_CPU)
                {
                    MessageBox.Show("Felicidades Ganaste");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Buen intento. El Ganador es la Maquina. Suerte en la Proxima");
                    this.Close();
                }
            }
       }

        private void bt_1_1_Click(object sender, EventArgs e)
        {
            Categoria = "adivinaquien";
            Puntajes = "adivina1";
            Cambiar(Categoria, Puntajes);
            bt_1_1.Visible = false;
            Update_All(); 

        }
        
        private void bt_1_2_Click(object sender, EventArgs e)
        {
            Categoria = "adivinaquien";
            Puntajes = "adivina2";
            Cambiar(Categoria, Puntajes);
            bt_1_2.Visible = false;
        }

        private void bt_1_3_Click(object sender, EventArgs e)
        {
            Categoria = "adivinaquien";
            Puntajes = "adivina3";
            Cambiar(Categoria, Puntajes);
            bt_1_3.Visible = false;
        }

        private void bt_1_4_Click(object sender, EventArgs e)
        {
            Categoria = "adivinaquien";
            Puntajes = "adivina4";
            Cambiar(Categoria, Puntajes);
            bt_1_4.Visible = false;
        }

        private void bt_1_5_Click(object sender, EventArgs e)
        {
            
            Categoria = "adivinaquien";
            Puntajes = "adivina5";
            Cambiar(Categoria, Puntajes);
            bt_1_5.Visible = false;
        }

        private void bt_2_1_Click(object sender, EventArgs e)
        {
            
            Categoria = "peleas";
            Puntajes = "pelea1";
            Cambiar(Categoria, Puntajes);
            bt_2_1.Visible = false;
            Update_All();
        }

        private void bt_2_2_Click(object sender, EventArgs e)
        {
            
            Categoria = "peleas";
            Puntajes = "pelea2";
            Cambiar(Categoria, Puntajes);
            bt_2_2.Visible = false;
            
        }

        private void bt_2_3_Click(object sender, EventArgs e)
        {
            
            Categoria = "peleas";
            Puntajes = "pelea3";
            Cambiar(Categoria, Puntajes);
            bt_2_3.Visible = false;
        }

        private void bt_2_4_Click(object sender, EventArgs e)
        {
            
            Categoria = "peleas";
            Puntajes = "pelea4";
            Cambiar(Categoria, Puntajes);
            bt_2_4.Visible = false;
        }

        private void bt_2_5_Click(object sender, EventArgs e)
        {
            
            Categoria = "peleas";
            Puntajes = "pelea5";
            Cambiar(Categoria, Puntajes);
            bt_2_5.Visible = false;
        }

        private void bt_3_1_Click(object sender, EventArgs e)
        {
           
            Categoria = "sagas";
            Puntajes = "saga1";
            Cambiar(Categoria, Puntajes);
            bt_3_1.Visible = false;
        }

        private void bt_3_2_Click(object sender, EventArgs e)
        {
            
            Categoria = "sagas";
            Puntajes = "saga2";
            Cambiar(Categoria, Puntajes);
            bt_3_2.Visible = false;
        }

        private void bt_3_3_Click(object sender, EventArgs e)
        {
            
            Categoria = "sagas";
            Puntajes = "saga3";
            Cambiar(Categoria, Puntajes);
            bt_3_3.Visible = false;
        }

        private void bt_3_4_Click(object sender, EventArgs e)
        {
            
            Categoria = "sagas";
            Puntajes = "saga4";
            Cambiar(Categoria, Puntajes);
            bt_3_4.Visible = false;
        }

        private void bt_3_5_Click(object sender, EventArgs e)
        {
            
            Categoria = "sagas";
            Puntajes = "saga5";
            Cambiar(Categoria, Puntajes);
            bt_3_5.Visible = false;
        }

        private void bt_4_1_Click(object sender, EventArgs e)
        {
            
            Categoria = "intruso";
            Puntajes = "intruso1";
            Cambiar(Categoria, Puntajes);
            bt_4_1.Visible = false;
        }

        private void bt_4_2_Click(object sender, EventArgs e)
        {
            
            Categoria = "intruso";
            Puntajes = "intruso2";
            Cambiar(Categoria, Puntajes);
            bt_4_2.Visible = false;
        }

        private void bt_4_3_Click(object sender, EventArgs e)
        {
            
            Categoria = "intruso";
            Puntajes = "intruso3";
            Cambiar(Categoria, Puntajes);
            bt_4_3.Visible = false;
        }

        private void bt_4_4_Click(object sender, EventArgs e)
        {
            
            Categoria = "intruso";
            Puntajes = "intruso4";
            Cambiar(Categoria, Puntajes);
            bt_4_4.Visible = false;
        }

        private void bt_4_5_Click(object sender, EventArgs e)
        {
            
            Categoria = "intruso";
            Puntajes = "intruso5";
            Cambiar(Categoria, Puntajes);
            bt_4_5.Visible = false;
        }

        private void bt_5_1_Click(object sender, EventArgs e)
        {
            
            Categoria = "hardcore";
            Puntajes = "hardcore1";
            Cambiar(Categoria, Puntajes);
            bt_5_1.Visible = false;
        }

        private void bt_5_2_Click(object sender, EventArgs e)
        {
   
            Categoria = "hardcore";
            Puntajes = "hardcore2";
            Cambiar(Categoria, Puntajes);
            bt_5_2.Visible = false;
        }

        private void bt_5_3_Click(object sender, EventArgs e)
        {
            
            Categoria = "hardcore";
            Puntajes = "hardcore3";
            Cambiar(Categoria, Puntajes);
            bt_5_3.Visible = false;
        }

        private void bt_5_4_Click(object sender, EventArgs e)
        {
            
            Categoria = "hardcore";
            Puntajes = "hardcore4";
            Cambiar(Categoria, Puntajes);
            bt_5_4.Visible = false;
        }

        private void bt_5_5_Click(object sender, EventArgs e)
        {
            ;
            Categoria = "hardcore";
            Puntajes = "hardcore5";
            Cambiar(Categoria, Puntajes);
            bt_5_5.Visible = false;
        }
        
        private void Jeopardy_Load(object sender, EventArgs e)
        {
            lb_Player_Score.Text = "$" + Handler.P_Score.ToString();
        }

        private void bt_desempate_Click(object sender, EventArgs e)
        {
            Categoria = "adivinaquien";
            Puntajes = "adivina6";
            Cambiar(Categoria, Puntajes);
        }
    }
}
