using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Office.Core;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop;
using System.Drawing.Imaging;
using System.Security;

namespace ConversorImagens
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregaImagem_Click(object sender, EventArgs e)
        {

            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 3;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;
            
            ofd1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.gif|*.gif|*.png|*.png|*.icon|*.icon";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picImagem.Image = Image.FromFile(ofd1.FileName);
                    AjustaRadioButtons(true);
                    btnConverterImagem.Enabled = true;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Erro .\n\n" + "Mensagem : " + ex.Message + "\n\n" +
                                    "Verificar Imagem:\n\n" + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não é possível exibir a imagem : " + ofd1.FileName + ". Você pode não ter permissão para ler o arquivo , ou " +
                                   " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                }
            }
        }

        private string filtroAtribuicaoExtensao()
        {
            if (rdbJPG.Checked) return "*.jpg|*.jpg";
            if (rdbGIF.Checked) return "*.gif|*.gif";
            if (rdbPNG.Checked) return "*.png|*.png";
            if (rdbBMP.Checked) return "*.bmp|*.bmp";
            if (rdbICON.Checked) return "*.ico|*.ico";
            if (rdbEXIF.Checked) return "*.exif|*.exif";

            return string.Empty;
        }

        private void btnConverterImagem_Click(object sender, EventArgs e)
        {
            String msg = "";
            Image imagemConvertida = picImagem.Image;
            sfd1.Filter = filtroAtribuicaoExtensao();
            if (sfd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (rdbJPG.Checked)
                    {
                        imagemConvertida.Save(sfd1.FileName, ImageFormat.Jpeg);
                        msg = "Conversão para JPEG, realizada com sucesso";
                    }
                    else if (rdbGIF.Checked)
                    {
                        imagemConvertida.Save(sfd1.FileName, ImageFormat.Gif);
                        msg = "Conversão para GIF, realizada com sucesso";
                    }
                    else if (rdbPNG.Checked)
                    {
                        imagemConvertida.Save(sfd1.FileName, ImageFormat.Png);
                        msg = "Conversão para PNG, realizada com sucesso";
                    }
                    else if (rdbBMP.Checked)
                    {
                        imagemConvertida.Save(sfd1.FileName, ImageFormat.Bmp);
                        msg = "Conversão para BMP, realizada com sucesso";
                    }
                    else if (rdbICON.Checked)
                    {
                        imagemConvertida.Save(sfd1.FileName, ImageFormat.Icon);
                        msg = "Conversão para ICON,realizada com sucesso";
                    }
                    else if (rdbEXIF.Checked)
                    {
                        imagemConvertida.Save(sfd1.FileName, ImageFormat.Exif);
                        msg = "Conversão para EXIF, realizada com sucesso.";
                    }
                    MessageBox.Show(msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não é possivel converter a imagem : " + ofd1.FileName + System.Environment.NewLine + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("A imagem não é válida");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AjustaRadioButtons(false);
            btnConverterImagem.Enabled = false;
        }

        private void AjustaRadioButtons(bool flag)
        {
            foreach (Control cntrl in Controls)
            {
                if (cntrl.GetType() == typeof(RadioButton))
                {
                    cntrl.Enabled = flag;
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wParam, int lParam, int v);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnMinimizar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        object formato_doc;
        private void btnProcurarOrigem_Click(object sender, EventArgs e)
        {
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecione o arquivo de Origem";
            ofd1.InitialDirectory = @"C:\Dados\";

            ofd1.Filter = "Arquivos (*.RTF;*.TXT) |*.RTF;*.TXT|" + "Todos (*.*)|*.*"; 
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 3;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult resultado = ofd1.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                txtOrigem.Text = ofd1.FileName;
            }
            else
            {
                txtOrigem.Text = " ";
            }
        }

        private void btnProcurarDestino_Click(object sender, EventArgs e)
        {
            fbd1.Description = "Selecione uma pasta de destino";
            fbd1.SelectedPath = @"C:\Dados\PDF\";
            fbd1.ShowNewFolderButton = true;

            DialogResult resultado = fbd1.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                txtDestino.Text = fbd1.SelectedPath + "\\" + Path.GetFileNameWithoutExtension(txtOrigem.Text) + "pdf";
            }
            else
            {
                txtDestino.Text = "";
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtOrigem.Text)|| string.IsNullOrEmpty(txtDestino.Text))
            {
                MessageBox.Show("Informe o arquivo Origem e o arquivo Destino");
                return;
            }
        }
    }
}
