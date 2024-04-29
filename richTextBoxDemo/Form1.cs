namespace richTextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = "Program naèten!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Modrá")
            {
                richTextBox1.SelectionColor = Color.Blue;
                toolStripStatusLabel2.Text = "Vybráná: modrá";
            }
            else if (comboBox1.SelectedItem.ToString() == "Zelená")
            {
                richTextBox1.SelectionColor = Color.Green;
                toolStripStatusLabel2.Text = "Vybráná: zelená";
            }
            else if (comboBox1.SelectedItem.ToString() == "Žlutá")
            {
                richTextBox1.SelectionColor = Color.Yellow;
                toolStripStatusLabel2.Text = "Vybráná: žlutá";
            }
            else if (comboBox1.SelectedItem.ToString() == "Èervená")
            {
                richTextBox1.SelectionColor = Color.Red;
                toolStripStatusLabel2.Text = "Vybráná: èervená";
            }
            else if (comboBox1.SelectedItem.ToString() == "Èerná")
            {
                richTextBox1.SelectionColor = Color.Black;
                toolStripStatusLabel2.Text = "Vybráná: èerná";
            }
            else if (comboBox1.SelectedItem.ToString() == "Rùžová")
            {
                richTextBox1.SelectionColor = Color.Pink;
                toolStripStatusLabel2.Text = "Vybráná: rùžová";
            }
            else if (comboBox1.SelectedItem.ToString() == "Modrá")
            {
                richTextBox1.SelectionColor = Color.Blue;
                toolStripStatusLabel2.Text = "Vybráná: modrá";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Modrá")
            {
                richTextBox1.SelectionBackColor = Color.Blue;
                toolStripStatusLabel2.Text = "Vybráná: modrá";
            }
            else if (comboBox2.SelectedItem.ToString() == "Zelená")
            {
                richTextBox1.SelectionBackColor = Color.Green;
                toolStripStatusLabel2.Text = "Vybráná: zelená";
            }
            else if (comboBox2.SelectedItem.ToString() == "Žlutá")
            {
                richTextBox1.SelectionBackColor = Color.Yellow;
                toolStripStatusLabel2.Text = "Vybráná: žlutá";
            }
            else if (comboBox2.SelectedItem.ToString() == "Èervená")
            {
                richTextBox1.SelectionBackColor = Color.Red;
                toolStripStatusLabel2.Text = "Vybráná: èervená";
            }
            else if (comboBox2.SelectedItem.ToString() == "Rùžová")
            {
                richTextBox1.SelectionBackColor = Color.Pink;
                toolStripStatusLabel2.Text = "Vybráná: rùžová";
            }
            else if (comboBox2.SelectedItem.ToString() == "Modrá")
            {
                richTextBox1.SelectionBackColor = Color.Blue;
                toolStripStatusLabel2.Text = "Vybráná: modrá";
            }
            else if (comboBox2.SelectedItem.ToString() == "Žádná")
            {
                richTextBox1.SelectionBackColor = Color.White;
                toolStripStatusLabel2.Text = "Vybráná: žádná";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "8")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 8, richTextBox1.Font.Style);
                toolStripStatusLabel2.Text = "Velikost: 8";
            }
            else if (comboBox3.SelectedItem.ToString() == "12")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
                toolStripStatusLabel2.Text = "Velikost: 12";
            }
            else if (comboBox3.SelectedItem.ToString() == "16")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 16, richTextBox1.Font.Style);
                toolStripStatusLabel2.Text = "Velikost: 16";
            }
            else if (comboBox3.SelectedItem.ToString() == "20")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 20, richTextBox1.Font.Style);
                toolStripStatusLabel2.Text = "Velikost: 20";
            }
            else if (comboBox3.SelectedItem.ToString() == "24")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 24, richTextBox1.Font.Style);
                toolStripStatusLabel2.Text = "Velikost: 24";
            }
            else if (comboBox3.SelectedItem.ToString() == "32")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 32, richTextBox1.Font.Style);
                toolStripStatusLabel2.Text = "Velikost: 32";
            }
            else if (comboBox3.SelectedItem.ToString() == "48")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 48, richTextBox1.Font.Style);
                toolStripStatusLabel2.Text = "Velikost: 48";
            }
            else if (comboBox3.SelectedItem.ToString() == "64")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 64, richTextBox1.Font.Style);
                toolStripStatusLabel2.Text = "Velikost: 64";
            }
            else if (comboBox3.SelectedItem.ToString() == "72")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 72, richTextBox1.Font.Style);
                toolStripStatusLabel2.Text = "Velikost: 72";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Font vyberfont = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(vyberfont, FontStyle.Bold);
            toolStripStatusLabel2.Text = "Vybráno tuèné písmo";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Font vyberfont = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(vyberfont, FontStyle.Italic);
            toolStripStatusLabel2.Text = "Vybrána kurzíva";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font vyberfont = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(vyberfont, FontStyle.Underline);
            toolStripStatusLabel2.Text = "Vybráno podtržené písmo";
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Vybírání lokace k uložení souboru...";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel2.Text = "Ukládám soubor...";
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                toolStripStatusLabel2.Text = "Soubor uložen!";
            }
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Otvírání souboru...";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel2.Text = "Naèítám soubor...";
                richTextBox1.LoadFile(openFileDialog1.FileName);
                toolStripStatusLabel2.Text = "Soubor naèten!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Spouštím jiné možnosti...";
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                toolStripStatusLabel2.Text = "Možnosti uloženy!";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                richTextBox1.SelectionBullet = true;
                toolStripStatusLabel2.Text = "Zaškrtnut list!";
            }
            else
            {
                richTextBox1.SelectionBullet = false;
                toolStripStatusLabel2.Text = "Odškrtnut list!";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
