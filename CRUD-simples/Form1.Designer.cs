namespace CRUD_simples
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
            btnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            lstContatos = new ListView();
            label4 = new Label();
            txtBusca = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(172, 226);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 102);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 166);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(17, 58);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(230, 23);
            txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(17, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(17, 184);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(230, 23);
            txtTelefone.TabIndex = 6;
            // 
            // lstContatos
            // 
            lstContatos.Location = new Point(266, 87);
            lstContatos.Name = "lstContatos";
            lstContatos.Size = new Size(559, 162);
            lstContatos.TabIndex = 7;
            lstContatos.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 40);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 8;
            label4.Text = "Buscar Contato";
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(266, 58);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(398, 23);
            txtBusca.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(670, 58);
            button1.Name = "button1";
            button1.Size = new Size(155, 23);
            button1.TabIndex = 10;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 271);
            Controls.Add(button1);
            Controls.Add(txtBusca);
            Controls.Add(label4);
            Controls.Add(lstContatos);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private ListView lstContatos;
        private Label label4;
        private TextBox txtBusca;
        private Button button1;
    }
}