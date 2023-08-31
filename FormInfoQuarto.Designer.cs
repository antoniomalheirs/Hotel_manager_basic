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
            infoquarto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            infoquarto.Location = new Point(10, 50);
            infoquarto.Name = "infoquarto";
            infoquarto.Size = new Size(207, 25);
            infoquarto.TabIndex = 2;
            infoquarto.Text = "Informações do Quarto";
            // 
            // FormInfoQuarto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(infoquarto);
            Controls.Add(descricao);
            Controls.Add(numero);
            Name = "FormInfoQuarto";
            Text = "FormInfoQuarto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numero;
        private Label descricao;
        private Label infoquarto;
    }
}