namespace AS2324._3G.Prof.TestWindowsForm
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
            txtNome = new TextBox();
            label1 = new Label();
            lblSaluto = new Label();
            btnSaluta = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(220, 83);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 86);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // lblSaluto
            // 
            lblSaluto.AutoSize = true;
            lblSaluto.Location = new Point(200, 250);
            lblSaluto.Name = "lblSaluto";
            lblSaluto.Size = new Size(52, 20);
            lblSaluto.TabIndex = 1;
            lblSaluto.Text = "Ciao ...";
            lblSaluto.Click += label1_Click;
            // 
            // btnSaluta
            // 
            btnSaluta.Location = new Point(203, 141);
            btnSaluta.Name = "btnSaluta";
            btnSaluta.Size = new Size(150, 54);
            btnSaluta.TabIndex = 2;
            btnSaluta.Text = "Saluta";
            btnSaluta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaluta);
            Controls.Add(lblSaluto);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "3G;14/03/24;Prof;Test windows form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label lblSaluto;
        private Button btnSaluta;
    }
}
