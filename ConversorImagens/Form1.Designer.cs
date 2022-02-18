namespace ConversorImagens
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnConverterDoc = new System.Windows.Forms.Button();
            this.btnConverterImagem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd2 = new System.Windows.Forms.OpenFileDialog();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnProcurarOrigem = new System.Windows.Forms.Button();
            this.btnProcurarDestino = new System.Windows.Forms.Button();
            this.rdbEXIF = new System.Windows.Forms.RadioButton();
            this.rdbGIF = new System.Windows.Forms.RadioButton();
            this.rdbICON = new System.Windows.Forms.RadioButton();
            this.rdbBMP = new System.Windows.Forms.RadioButton();
            this.rdbJPG = new System.Windows.Forms.RadioButton();
            this.rdbPNG = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbDOC = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picImagem.Location = new System.Drawing.Point(177, 84);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(328, 282);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // btnConverterDoc
            // 
            this.btnConverterDoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConverterDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverterDoc.Location = new System.Drawing.Point(21, 84);
            this.btnConverterDoc.Name = "btnConverterDoc";
            this.btnConverterDoc.Size = new System.Drawing.Size(131, 73);
            this.btnConverterDoc.TabIndex = 1;
            this.btnConverterDoc.Text = "Carregar Imagem";
            this.btnConverterDoc.UseVisualStyleBackColor = false;
            this.btnConverterDoc.Click += new System.EventHandler(this.btnCarregaImagem_Click);
            // 
            // btnConverterImagem
            // 
            this.btnConverterImagem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConverterImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverterImagem.Location = new System.Drawing.Point(21, 294);
            this.btnConverterImagem.Name = "btnConverterImagem";
            this.btnConverterImagem.Size = new System.Drawing.Size(131, 72);
            this.btnConverterImagem.TabIndex = 1;
            this.btnConverterImagem.Text = "Converter Imagem";
            this.btnConverterImagem.UseVisualStyleBackColor = false;
            this.btnConverterImagem.Click += new System.EventHandler(this.btnConverterImagem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(175, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conversor de Imagens";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // ofd2
            // 
            this.ofd2.FileName = "openFileDialog1";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOrigem.Location = new System.Drawing.Point(21, 410);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(439, 29);
            this.txtOrigem.TabIndex = 4;
            this.txtOrigem.Text = "(Informe o Arquivo para Converter)";
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDestino.Location = new System.Drawing.Point(21, 473);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(439, 29);
            this.txtDestino.TabIndex = 5;
            this.txtDestino.Text = "(Informe o Local de Destino)";
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(21, 527);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(128, 52);
            this.btnConverter.TabIndex = 6;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnProcurarOrigem
            // 
            this.btnProcurarOrigem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcurarOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarOrigem.Location = new System.Drawing.Point(466, 410);
            this.btnProcurarOrigem.Name = "btnProcurarOrigem";
            this.btnProcurarOrigem.Size = new System.Drawing.Size(39, 30);
            this.btnProcurarOrigem.TabIndex = 7;
            this.btnProcurarOrigem.Text = "...";
            this.btnProcurarOrigem.UseVisualStyleBackColor = false;
            this.btnProcurarOrigem.Click += new System.EventHandler(this.btnProcurarOrigem_Click);
            // 
            // btnProcurarDestino
            // 
            this.btnProcurarDestino.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcurarDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarDestino.Location = new System.Drawing.Point(466, 473);
            this.btnProcurarDestino.Name = "btnProcurarDestino";
            this.btnProcurarDestino.Size = new System.Drawing.Size(39, 30);
            this.btnProcurarDestino.TabIndex = 8;
            this.btnProcurarDestino.Text = "...";
            this.btnProcurarDestino.UseVisualStyleBackColor = false;
            this.btnProcurarDestino.Click += new System.EventHandler(this.btnProcurarDestino_Click);
            // 
            // rdbEXIF
            // 
            this.rdbEXIF.AutoSize = true;
            this.rdbEXIF.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEXIF.Location = new System.Drawing.Point(96, 209);
            this.rdbEXIF.Name = "rdbEXIF";
            this.rdbEXIF.Size = new System.Drawing.Size(59, 20);
            this.rdbEXIF.TabIndex = 2;
            this.rdbEXIF.TabStop = true;
            this.rdbEXIF.Text = "EXIF";
            this.rdbEXIF.UseVisualStyleBackColor = true;
            // 
            // rdbGIF
            // 
            this.rdbGIF.AutoSize = true;
            this.rdbGIF.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGIF.Location = new System.Drawing.Point(96, 235);
            this.rdbGIF.Name = "rdbGIF";
            this.rdbGIF.Size = new System.Drawing.Size(49, 20);
            this.rdbGIF.TabIndex = 2;
            this.rdbGIF.TabStop = true;
            this.rdbGIF.Text = "GIF";
            this.rdbGIF.UseVisualStyleBackColor = true;
            // 
            // rdbICON
            // 
            this.rdbICON.AutoSize = true;
            this.rdbICON.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbICON.Location = new System.Drawing.Point(21, 235);
            this.rdbICON.Name = "rdbICON";
            this.rdbICON.Size = new System.Drawing.Size(62, 20);
            this.rdbICON.TabIndex = 2;
            this.rdbICON.TabStop = true;
            this.rdbICON.Text = "ICON";
            this.rdbICON.UseVisualStyleBackColor = true;
            // 
            // rdbBMP
            // 
            this.rdbBMP.AutoSize = true;
            this.rdbBMP.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBMP.Location = new System.Drawing.Point(21, 209);
            this.rdbBMP.Name = "rdbBMP";
            this.rdbBMP.Size = new System.Drawing.Size(55, 20);
            this.rdbBMP.TabIndex = 2;
            this.rdbBMP.TabStop = true;
            this.rdbBMP.Text = "BMP";
            this.rdbBMP.UseVisualStyleBackColor = true;
            // 
            // rdbJPG
            // 
            this.rdbJPG.AutoSize = true;
            this.rdbJPG.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbJPG.Location = new System.Drawing.Point(21, 182);
            this.rdbJPG.Name = "rdbJPG";
            this.rdbJPG.Size = new System.Drawing.Size(52, 21);
            this.rdbJPG.TabIndex = 2;
            this.rdbJPG.TabStop = true;
            this.rdbJPG.Text = "JPG";
            this.rdbJPG.UseVisualStyleBackColor = true;
            // 
            // rdbPNG
            // 
            this.rdbPNG.AutoSize = true;
            this.rdbPNG.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPNG.Location = new System.Drawing.Point(96, 183);
            this.rdbPNG.Name = "rdbPNG";
            this.rdbPNG.Size = new System.Drawing.Size(55, 20);
            this.rdbPNG.TabIndex = 2;
            this.rdbPNG.TabStop = true;
            this.rdbPNG.Text = "PNG";
            this.rdbPNG.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(155, 552);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 22);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Formato PDF";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbDOC
            // 
            this.rdbDOC.AutoSize = true;
            this.rdbDOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDOC.Location = new System.Drawing.Point(155, 527);
            this.rdbDOC.Name = "rdbDOC";
            this.rdbDOC.Size = new System.Drawing.Size(121, 22);
            this.rdbDOC.TabIndex = 10;
            this.rdbDOC.TabStop = true;
            this.rdbDOC.Text = "Formato DOC";
            this.rdbDOC.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(282, 527);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(136, 22);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Formato EXCEL";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(282, 552);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(109, 22);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Formato ZIP";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(424, 527);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(116, 22);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Formato PPT";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(425, 552);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(115, 22);
            this.radioButton6.TabIndex = 14;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Formato TXT";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(543, 28);
            this.BarraTitulo.TabIndex = 15;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(494, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 18);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(520, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(543, 591);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.rdbDOC);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdbICON);
            this.Controls.Add(this.rdbBMP);
            this.Controls.Add(this.rdbJPG);
            this.Controls.Add(this.rdbPNG);
            this.Controls.Add(this.btnProcurarDestino);
            this.Controls.Add(this.rdbEXIF);
            this.Controls.Add(this.rdbGIF);
            this.Controls.Add(this.btnProcurarOrigem);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConverterImagem);
            this.Controls.Add(this.btnConverterDoc);
            this.Controls.Add(this.picImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btnConverterDoc;
        private System.Windows.Forms.Button btnConverterImagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.OpenFileDialog ofd2;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnProcurarOrigem;
        private System.Windows.Forms.Button btnProcurarDestino;
        private System.Windows.Forms.RadioButton rdbEXIF;
        private System.Windows.Forms.RadioButton rdbGIF;
        private System.Windows.Forms.RadioButton rdbICON;
        private System.Windows.Forms.RadioButton rdbBMP;
        private System.Windows.Forms.RadioButton rdbJPG;
        private System.Windows.Forms.RadioButton rdbPNG;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdbDOC;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}

