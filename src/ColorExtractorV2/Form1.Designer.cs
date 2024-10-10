namespace ColorExtractorV2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button2 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 0;
            button1.Text = "Abrir Imagem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(137, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 229);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.No;
            textBox1.Location = new Point(12, 218);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(12, 158);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 9;
            button2.Text = "Salvar HEX";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Cursor = Cursors.No;
            panel1.Location = new Point(12, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 23);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 249);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Color Extractor V2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button2;
        private Panel panel1; // Novo painel para exibir a cor selecionada
    }
}
