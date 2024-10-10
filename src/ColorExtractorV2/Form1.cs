namespace ColorExtractorV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para abrir o explorador de arquivos e selecionar a imagem
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(filePath);
                textBox1.Text = Path.GetFileName(filePath);

                // Extrai os códigos de cores da imagem
                ExtractColorsFromImage(filePath);
            }
        }

        // Método para extrair os códigos HEX de uma imagem
        private void ExtractColorsFromImage(string filePath)
        {
            Bitmap bitmap = new Bitmap(filePath);
            HashSet<string> hexColors = new HashSet<string>();

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    string hex = $"#{pixelColor.R:X2}{pixelColor.G:X2}{pixelColor.B:X2}";
                    hexColors.Add(hex);
                }
            }

            listBox1.Items.Clear();
            foreach (string hex in hexColors)
            {
                listBox1.Items.Add(hex);
            }
        }

        // Evento para salvar a lista de HEX em um arquivo de texto
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(textBox1.Text) + "HEXlist.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }
        }

        // Evento para exibir a cor selecionada no painel e copiar o código HEX para a área de transferência
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string hexColor = listBox1.SelectedItem.ToString();
                panel1.BackColor = ColorTranslator.FromHtml(hexColor);

                // Copiar o código HEX para a área de transferência
                Clipboard.SetText(hexColor);
            }
        }
    }
}
