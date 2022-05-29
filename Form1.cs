using System.IO;
using System.Drawing;

namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void Novo_Click(object sender, EventArgs e)//button new file
        {

            //nao terminado
            richTextBox1.Clear();
            richTextBox1.Focus();
        }//FALTA COISA -----------
        private void Salvar_Click(object sender, EventArgs e)//button save file
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new(saveFileDialog1.FileName,FileMode.OpenOrCreate,FileAccess.Write);
                    StreamWriter streamWriter = new(arquivo);
                    streamWriter.Flush();
                    streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    streamWriter.Write(this.richTextBox1.Text);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message,"Erro ao Gravar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }//FALTA COISA --------
        private void Abrir_Click(object sender,EventArgs e)//button open file
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "(*.txts)|*.txts";
            openFileDialog1.FileName = "";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                    StreamReader streamReader = new(arquivo);
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = streamReader.ReadLine();
                    while(linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = streamReader.ReadLine();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//FALTA COISA ----------
        private void Imprimir_Click(object sender,EventArgs e)//button print file
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }


        }//FALTA COISA ------
        private void CCR_Click(object sender, EventArgs e)//single button copy paste and cut
        {
            var tsb = (dynamic)sender;
            int x = Convert.ToInt16(tsb.Tag.ToString());
            switch (x)
            {
                case 0:
                    if (richTextBox1.SelectionLength > 0) richTextBox1.Copy();
                    break;
                case 1:
                    richTextBox1.Paste();
                    break;
                case 2:
                    if (richTextBox1.SelectionLength > 0) richTextBox1.Cut();
                    break;
            }
        }
        private void NIS_Click(object sender,EventArgs e)//single button text fontstyle
        {
            //get type of button
            var tsb = (dynamic)sender;
            //setting variables
            FontStyle[] fs = new FontStyle[3]{ FontStyle.Bold,FontStyle.Italic,FontStyle.Underline};
            var rtb = richTextBox1.SelectionFont;
            int x = Convert.ToInt16(tsb.Tag.ToString());
            bool[] nis = new bool[3] {rtb.Bold,rtb.Italic,rtb.Underline};
            string nomefonte = richTextBox1.Font.Name;
            float tamanho_fonte = richTextBox1.Font.Size;

            rtb = new(nomefonte, tamanho_fonte, FontStyle.Regular);

            if (nis[x] == false)
            {
                if (nis[(x + 1) % nis.Length] == true & nis[(x + 2) % nis.Length] == true) rtb = new(nomefonte, tamanho_fonte, fs[x] | fs[(x + 1) % fs.Length] | fs[(x + 2) % fs.Length]);
                else if (nis[(x + 1) % nis.Length] == false & nis[(x + 2) % nis.Length] == true) rtb = new(nomefonte, tamanho_fonte, fs[x] | fs[(x + 2) % fs.Length]);
                else if (nis[(x + 1) % nis.Length] == true & nis[(x + 2) % nis.Length] == false) rtb = new(nomefonte, tamanho_fonte, fs[x] | fs[(x + 1) % fs.Length]);
                else if (nis[(x + 1) % nis.Length] == false & nis[(x + 2) % nis.Length] == false) rtb = new(nomefonte, tamanho_fonte, fs[x]);
            }
            else
            {
                if (nis[(x + 1) % nis.Length] == true & nis[(x + 2) % nis.Length] == true) rtb = new(nomefonte, tamanho_fonte, fs[(x + 1) % fs.Length] | fs[(x + 2) % fs.Length]);
                else if (nis[(x + 1) % nis.Length] == false & nis[(x + 2) % nis.Length] == true) rtb = new(nomefonte, tamanho_fonte, fs[(x + 2) % fs.Length]);
                else if (nis[(x + 1) % nis.Length] == true & nis[(x + 2) % nis.Length] == false) rtb = new(nomefonte, tamanho_fonte, fs[(x + 1) % fs.Length]);
            }
            
            richTextBox1.SelectionFont = rtb;
        }
        private void Align_Click(object sender, EventArgs e)//single button text alignment
        {
            var tsb = (dynamic)sender;

            HorizontalAlignment[] ha = new HorizontalAlignment[3] {HorizontalAlignment.Left , HorizontalAlignment.Center, HorizontalAlignment.Right};
            richTextBox1.SelectionAlignment = ha[Convert.ToInt16(tsb.Tag.ToString())];
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string linha = null;
            float linhasPagina = 0;
            float PosY = 0;
            int cont = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;
            if (margemEsquerda < 5) margemEsquerda = 20;
            if (margemSuperior < 5) margemSuperior = 20;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new(Color.Black);
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while(cont < linhasPagina)
            {
                PosY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, PosY, new StringFormat());
                cont += 1;
                linha = leitura.ReadLine();
            }
            if (linha != null) e.HasMorePages = true;
            else e.HasMorePages = false;
            pincel.Dispose();
        }
    }
}






/* backup for NIS
 * 
 * //get type of button
            var tsb = (dynamic)sender;
            //setting variables
            FontStyle[] fs = new FontStyle[3]{ FontStyle.Bold,FontStyle.Italic,FontStyle.Underline};
            var rtb = richTextBox1.SelectionFont;
            string[] tag = new string[3] {"bold","italic","underline"};
            bool[] nis = new bool[3] {rtb.Bold,rtb.Italic,rtb.Underline};

            string nomefonte = richTextBox1.Font.Name;
            float tamanho_fonte = richTextBox1.Font.Size;

            rtb = new(nomefonte, tamanho_fonte, FontStyle.Regular);
            for(int x = 0; x <= 2; x++)
            {
                if (tsb.Tag.ToString() == tag[x] & nis[x] == false)
                {
                    if (nis[(x + 1) % nis.Length] == true & nis[(x + 2) % nis.Length] == true) rtb = new(nomefonte, tamanho_fonte, fs[x] | fs[(x + 1) % fs.Length] | fs[(x + 2) % fs.Length]);
                    else if (nis[(x + 1) % nis.Length] == false & nis[(x + 2) % nis.Length] == true) rtb = new(nomefonte, tamanho_fonte, fs[x] | fs[(x + 2) % fs.Length]);
                    else if (nis[(x + 1) % nis.Length] == true & nis[(x + 2) % nis.Length] == false) rtb = new(nomefonte, tamanho_fonte, fs[x] | fs[(x + 1) % fs.Length]);
                    else if (nis[(x + 1) % nis.Length] == false & nis[(x + 2) % nis.Length] == false) rtb = new(nomefonte, tamanho_fonte, fs[x]);
                }else if (tsb.Tag.ToString() == tag[x])
                {
                    if (nis[(x + 1) % nis.Length] == true & nis[(x + 2) % nis.Length] == true) rtb = new(nomefonte, tamanho_fonte,fs[(x + 1) % fs.Length] | fs[(x + 2) % fs.Length]);
                    else if (nis[(x + 1) % nis.Length] == false & nis[(x + 2) % nis.Length] == true) rtb = new(nomefonte, tamanho_fonte,fs[(x + 2) % fs.Length]);
                    else if (nis[(x + 1) % nis.Length] == true & nis[(x + 2) % nis.Length] == false) rtb = new(nomefonte, tamanho_fonte,fs[(x + 1) % fs.Length]);
                }
            }
            richTextBox1.SelectionFont = rtb;

*/