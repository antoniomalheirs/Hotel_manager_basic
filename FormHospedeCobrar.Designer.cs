namespace Apredizado
{
    partial class FormHospedeCobrar
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
            lista = new TreeView();
            liberadevedor = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lista
            // 
            lista.Location = new Point(12, 33);
            lista.Name = "lista";
            lista.Size = new Size(241, 311);
            lista.TabIndex = 0;
            // 
            // liberadevedor
            // 
            liberadevedor.Location = new Point(414, 33);
            liberadevedor.Name = "liberadevedor";
            liberadevedor.Size = new Size(75, 23);
            liberadevedor.TabIndex = 1;
            liberadevedor.Text = "Liberar ";
            liberadevedor.UseVisualStyleBackColor = true;
            liberadevedor.Click += liberadevedor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 2;
            label1.Text = "Lista de Devedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(415, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 3;
            label2.Text = "Funções";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(283, 37);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 4;
            label3.Text = "Confirmar Pagamento";
            // 
            // FormHospedeCobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 358);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(liberadevedor);
            Controls.Add(lista);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHospedeCobrar";
            Text = "FormHospedeCobrar";
            Load += FormHospedeCobrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView lista;
        private Button liberadevedor;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}