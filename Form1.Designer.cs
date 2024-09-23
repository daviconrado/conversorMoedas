namespace ConversorMoedas
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
            label1 = new Label();
            valor1 = new TextBox();
            button1 = new Button();
            moeda1 = new ComboBox();
            moeda2 = new ComboBox();
            exibeResultado = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(523, 37);
            label1.TabIndex = 0;
            label1.Text = "Conversor de Moedas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // valor1
            // 
            valor1.Location = new Point(59, 171);
            valor1.Name = "valor1";
            valor1.PlaceholderText = "0,00";
            valor1.Size = new Size(86, 23);
            valor1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(210, 244);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 5;
            button1.Text = "CONVERTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // moeda1
            // 
            moeda1.FormattingEnabled = true;
            moeda1.Items.AddRange(new object[] { "Real (BRL)", "Dólar Americano (USD)", "Euro (EUR)" });
            moeda1.Location = new Point(387, 171);
            moeda1.Name = "moeda1";
            moeda1.Size = new Size(121, 23);
            moeda1.TabIndex = 6;
            moeda1.Text = "Dólar Americano (USD)";
            // 
            // moeda2
            // 
            moeda2.FormattingEnabled = true;
            moeda2.Items.AddRange(new object[] { "Real (BRL)", "Dólar Americano (USD)", "Euro (EUR)" });
            moeda2.Location = new Point(210, 171);
            moeda2.Name = "moeda2";
            moeda2.Size = new Size(121, 23);
            moeda2.TabIndex = 7;
            moeda2.Text = "Real (BRL)";
            // 
            // exibeResultado
            // 
            exibeResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            exibeResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exibeResultado.Location = new Point(59, 96);
            exibeResultado.Name = "exibeResultado";
            exibeResultado.Size = new Size(449, 15);
            exibeResultado.TabIndex = 8;
            exibeResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Wingdings 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label2.Location = new Point(351, 175);
            label2.Name = "label2";
            label2.Size = new Size(18, 13);
            label2.TabIndex = 9;
            label2.Text = "a";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(547, 305);
            Controls.Add(label2);
            Controls.Add(exibeResultado);
            Controls.Add(moeda2);
            Controls.Add(moeda1);
            Controls.Add(button1);
            Controls.Add(valor1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor de Moedas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox valor1;
        private Button button1;
        private ComboBox moeda1;
        private ComboBox moeda2;
        private Label exibeResultado;
        private Label label2;
    }
}
