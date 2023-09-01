namespace Apredizado
{
    partial class FormInfoQuarto
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
            numero = new Label();
            descricao = new Label();
            infoquarto = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            salvahospede = new Button();
            label5 = new Label();
            label6 = new Label();
            entrada = new Label();
            saida = new Label();
            label8 = new Label();
            dias = new NumericUpDown();
            label7 = new Label();
            label9 = new Label();
            txtcpf = new TextBox();
            nascimento = new DateTimePicker();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dias).BeginInit();
            SuspendLayout();
            // 
            // numero
            // 
            numero.AutoSize = true;
            numero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            numero.Location = new Point(180, 10);
            numero.Name = "numero";
            numero.Size = new Size(0, 30);
            numero.TabIndex = 0;
            // 
            // descricao
            // 
            descricao.AutoSize = true;
            descricao.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            descricao.Location = new Point(35, 80);
            descricao.Name = "descricao";
            descricao.Size = new Size(0, 21);
            descricao.TabIndex = 1;
            // 
            // infoquarto
            // 
            infoquarto.AutoSize = true;
            infoquarto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            infoquarto.Location = new Point(10, 50);
            infoquarto.Name = "infoquarto";
            infoquarto.Size = new Size(221, 25);
            infoquarto.TabIndex = 2;
            infoquarto.Text = "Informações do Quarto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(10, 120);
            label1.Name = "label1";
            label1.Size = new Size(236, 25);
            label1.TabIndex = 3;
            label1.Text = "Informações do Hospede";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 161);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(80, 190);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(137, 23);
            txtEmail.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(35, 169);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(24, 198);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(39, 227);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // salvahospede
            // 
            salvahospede.Location = new Point(24, 260);
            salvahospede.Name = "salvahospede";
            salvahospede.Size = new Size(75, 23);
            salvahospede.TabIndex = 10;
            salvahospede.Text = "Hospedar";
            salvahospede.UseVisualStyleBackColor = true;
            salvahospede.Click += salvahospede_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(10, 310);
            label5.Name = "label5";
            label5.Size = new Size(224, 25);
            label5.TabIndex = 11;
            label5.Text = "Informações da Reserva";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(35, 347);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 12;
            label6.Text = "Data/Hora Entrada";
            // 
            // entrada
            // 
            entrada.AutoSize = true;
            entrada.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            entrada.Location = new Point(50, 371);
            entrada.Name = "entrada";
            entrada.Size = new Size(0, 15);
            entrada.TabIndex = 13;
            // 
            // saida
            // 
            saida.AutoSize = true;
            saida.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saida.Location = new Point(50, 419);
            saida.Name = "saida";
            saida.Size = new Size(0, 15);
            saida.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(35, 395);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 14;
            label8.Text = "Data/Hora Saida";
            // 
            // dias
            // 
            dias.Location = new Point(265, 370);
            dias.Name = "dias";
            dias.Size = new Size(120, 23);
            dias.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(250, 347);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 17;
            label7.Text = "Dias Hospedado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(224, 169);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 19;
            label9.Text = "CPF";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(258, 161);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(137, 23);
            txtcpf.TabIndex = 18;
            // 
            // nascimento
            // 
            nascimento.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            nascimento.Format = DateTimePickerFormat.Short;
            nascimento.Location = new Point(309, 190);
            nascimento.Name = "nascimento";
            nascimento.Size = new Size(123, 22);
            nascimento.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label10.Location = new Point(224, 198);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 21;
            label10.Text = "Data de Nasc.";
            // 
            // FormInfoQuarto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(label10);
            Controls.Add(nascimento);
            Controls.Add(label9);
            Controls.Add(txtcpf);
            Controls.Add(label7);
            Controls.Add(dias);
            Controls.Add(saida);
            Controls.Add(label8);
            Controls.Add(entrada);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(salvahospede);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(infoquarto);
            Controls.Add(descricao);
            Controls.Add(numero);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInfoQuarto";
            Text = "Informações do Quarto";
            Load += FormInfoQuarto_Load;
            ((System.ComponentModel.ISupportInitialize)dias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numero;
        private Label descricao;
        private Label infoquarto;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button salvahospede;
        private Label label5;
        private Label label6;
        private Label entrada;
        private Label saida;
        private Label label8;
        private NumericUpDown dias;
        private Label label7;
        private Label label9;
        private TextBox txtcpf;
        private DateTimePicker nascimento;
        private Label label10;
    }
}