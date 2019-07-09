namespace CSharp_WinF_BingoMania
{
    partial class Player
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.btn_bingo = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(13, 13);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(48, 45);
            this.b1.TabIndex = 0;
            this.b1.Text = "button1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.btn_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(67, 13);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(48, 45);
            this.b2.TabIndex = 1;
            this.b2.Text = "button2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.btn_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(121, 13);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(48, 45);
            this.b3.TabIndex = 2;
            this.b3.Text = "button3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.btn_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(121, 64);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(48, 45);
            this.b6.TabIndex = 5;
            this.b6.Text = "button4";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.btn_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(67, 64);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(48, 45);
            this.b5.TabIndex = 4;
            this.b5.Text = "button5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.btn_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(13, 64);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(48, 45);
            this.b4.TabIndex = 3;
            this.b4.Text = "button6";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.btn_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(121, 115);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(48, 45);
            this.b9.TabIndex = 8;
            this.b9.Text = "button7";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.btn_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(67, 115);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(48, 45);
            this.b8.TabIndex = 7;
            this.b8.Text = "button8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.btn_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(13, 115);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(48, 45);
            this.b7.TabIndex = 6;
            this.b7.Text = "button9";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_bingo
            // 
            this.btn_bingo.Location = new System.Drawing.Point(13, 167);
            this.btn_bingo.Name = "btn_bingo";
            this.btn_bingo.Size = new System.Drawing.Size(156, 65);
            this.btn_bingo.TabIndex = 9;
            this.btn_bingo.Text = "BINGO!";
            this.btn_bingo.UseVisualStyleBackColor = true;
            this.btn_bingo.Click += new System.EventHandler(this.Btn_bingo_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(13, 258);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(13, 293);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(159, 20);
            this.txt_nome.TabIndex = 11;
            this.txt_nome.TextChanged += new System.EventHandler(this.Txt_nome_TextChanged);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 325);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_bingo);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Player";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button btn_bingo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox txt_nome;
    }
}