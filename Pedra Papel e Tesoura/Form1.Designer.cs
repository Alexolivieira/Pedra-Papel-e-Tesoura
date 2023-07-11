namespace Pedra_Papel_e_Tesoura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Pedra = new Button();
            btn_Papel = new Button();
            btn_Tesoura = new Button();
            computador = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Vencedor = new TextBox();
            usuario = new TextBox();
            SuspendLayout();
            // 
            // btn_Pedra
            // 
            btn_Pedra.Location = new Point(133, 85);
            btn_Pedra.Name = "btn_Pedra";
            btn_Pedra.Size = new Size(154, 52);
            btn_Pedra.TabIndex = 0;
            btn_Pedra.Text = "Pedra";
            btn_Pedra.UseVisualStyleBackColor = true;
            btn_Pedra.Click += btn_Pedra_Click;
            // 
            // btn_Papel
            // 
            btn_Papel.Location = new Point(133, 160);
            btn_Papel.Name = "btn_Papel";
            btn_Papel.Size = new Size(154, 52);
            btn_Papel.TabIndex = 1;
            btn_Papel.Text = "Papel";
            btn_Papel.UseVisualStyleBackColor = true;
            btn_Papel.Click += btn_Papel_Click;
            // 
            // btn_Tesoura
            // 
            btn_Tesoura.Location = new Point(133, 237);
            btn_Tesoura.Name = "btn_Tesoura";
            btn_Tesoura.Size = new Size(154, 52);
            btn_Tesoura.TabIndex = 2;
            btn_Tesoura.Text = "Tesoura";
            btn_Tesoura.UseVisualStyleBackColor = true;
            btn_Tesoura.Click += btn_Tesoura_Click;
            // 
            // computador
            // 
            computador.Location = new Point(401, 134);
            computador.Name = "computador";
            computador.Size = new Size(233, 31);
            computador.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 40);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 5;
            label1.Text = "Pedra, Papel ou Tesoura?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 99);
            label2.Name = "label2";
            label2.Size = new Size(202, 25);
            label2.TabIndex = 6;
            label2.Text = "Escolha do computador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 187);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 7;
            label3.Text = "Escolha do Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(665, 52);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 291);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 9;
            label5.Text = "Vencedor";
            // 
            // Vencedor
            // 
            Vencedor.Location = new Point(401, 329);
            Vencedor.Name = "Vencedor";
            Vencedor.Size = new Size(233, 31);
            Vencedor.TabIndex = 10;
            // 
            // usuario
            // 
            usuario.Location = new Point(401, 237);
            usuario.Name = "usuario";
            usuario.Size = new Size(233, 31);
            usuario.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(usuario);
            Controls.Add(Vencedor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(computador);
            Controls.Add(btn_Tesoura);
            Controls.Add(btn_Papel);
            Controls.Add(btn_Pedra);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Pedra;
        private Button btn_Papel;
        private Button btn_Tesoura;
        private TextBox computador;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Vencedor;
        private TextBox usuario;
    }
}