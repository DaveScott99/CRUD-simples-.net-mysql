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
            components = new System.ComponentModel.Container();
            btnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            lstContatos = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            label4 = new Label();
            txtBusca = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnExcluir = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(181, 226);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(66, 23);
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
            lstContatos.ContextMenuStrip = contextMenuStrip1;
            lstContatos.Location = new Point(266, 87);
            lstContatos.MultiSelect = false;
            lstContatos.Name = "lstContatos";
            lstContatos.Size = new Size(559, 379);
            lstContatos.TabIndex = 7;
            lstContatos.UseCompatibleStateImageBehavior = false;
            lstContatos.ItemSelectionChanged += lstContatos_ItemSelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(156, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(155, 22);
            toolStripMenuItem1.Text = "Excluir Contato";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
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
            // button2
            // 
            button2.Location = new Point(110, 226);
            button2.Name = "button2";
            button2.Size = new Size(65, 23);
            button2.TabIndex = 11;
            button2.Text = "Novo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(38, 226);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(66, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = " Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Visible = false;
            btnExcluir.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 480);
            Controls.Add(btnExcluir);
            Controls.Add(button2);
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
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
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
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button btnExcluir;
    }
}