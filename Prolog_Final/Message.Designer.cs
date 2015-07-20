namespace Prolog_Final
{
    partial class Message
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_Msg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Send = new System.Windows.Forms.Button();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LB_Text = new System.Windows.Forms.Label();
            this.lb_Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Msg
            // 
            this.bt_Msg.BackColor = System.Drawing.Color.Maroon;
            this.bt_Msg.Location = new System.Drawing.Point(199, 306);
            this.bt_Msg.Name = "bt_Msg";
            this.bt_Msg.Size = new System.Drawing.Size(111, 107);
            this.bt_Msg.TabIndex = 0;
            this.bt_Msg.Text = "PUSH";
            this.bt_Msg.UseVisualStyleBackColor = false;
            this.bt_Msg.Click += new System.EventHandler(this.bt_Msg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(400, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question ";
            this.label1.UseMnemonic = false;
            // 
            // bt_Send
            // 
            this.bt_Send.Location = new System.Drawing.Point(235, 463);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(75, 42);
            this.bt_Send.TabIndex = 3;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // txt_Answer
            // 
            this.txt_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Answer.Location = new System.Drawing.Point(109, 426);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(311, 31);
            this.txt_Answer.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LB_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Text.ForeColor = System.Drawing.Color.Yellow;
            this.LB_Text.Location = new System.Drawing.Point(420, 388);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(0, 25);
            this.LB_Text.TabIndex = 5;
            // 
            // lb_Answer
            // 
            this.lb_Answer.AutoSize = true;
            this.lb_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Answer.ForeColor = System.Drawing.Color.Yellow;
            this.lb_Answer.Location = new System.Drawing.Point(12, 230);
            this.lb_Answer.MaximumSize = new System.Drawing.Size(400, 200);
            this.lb_Answer.Name = "lb_Answer";
            this.lb_Answer.Size = new System.Drawing.Size(0, 25);
            this.lb_Answer.TabIndex = 6;
            this.lb_Answer.UseMnemonic = false;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(539, 517);
            this.Controls.Add(this.lb_Answer);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Msg);
            this.Name = "Message";
            this.Text = "Message";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Message_FormClosed);
            this.Load += new System.EventHandler(this.Message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Msg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LB_Text;
        private System.Windows.Forms.Label lb_Answer;
    }
}