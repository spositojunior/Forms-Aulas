namespace Editor_de_Texto
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_novo = new System.Windows.Forms.ToolStripButton();
            this.btn_abrir = new System.Windows.Forms.ToolStripButton();
            this.btn_salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_copiar = new System.Windows.Forms.ToolStripButton();
            this.btn_colar = new System.Windows.Forms.ToolStripButton();
            this.btn_recortar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_negrito = new System.Windows.Forms.ToolStripButton();
            this.btn_italico = new System.Windows.Forms.ToolStripButton();
            this.btn_sublinhado = new System.Windows.Forms.ToolStripButton();
            this.btn_fonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_esquerda = new System.Windows.Forms.ToolStripButton();
            this.btn_meio = new System.Windows.Forms.ToolStripButton();
            this.btn_direita = new System.Windows.Forms.ToolStripButton();
            this.btn_justificar = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(606, 511);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.abrirToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.toolStripMenuItem2,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem1});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.novoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Image = global::Editor_de_Texto.Properties.Resources.NewDocument;
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.novoToolStripMenuItem1.Text = "Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.Novo_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.OpenFile;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.Save;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sairToolStripMenuItem.Text = "Salvar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.Print;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Image = global::Editor_de_Texto.Properties.Resources.Exit;
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem,
            this.toolStripMenuItem3,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.recortarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.Undo;
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.Redo;
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(156, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.Copy;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.copiarToolStripMenuItem.Tag = "0";
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.CCR_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.Paste;
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.colarToolStripMenuItem.Tag = "1";
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.CCR_Click);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.Cut;
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.recortarToolStripMenuItem.Tag = "2";
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.CCR_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.italicoToolStripMenuItem,
            this.sublinadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.Bold;
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Tag = "0";
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.NIS_Click);
            // 
            // italicoToolStripMenuItem
            // 
            this.italicoToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.Italic;
            this.italicoToolStripMenuItem.Name = "italicoToolStripMenuItem";
            this.italicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.italicoToolStripMenuItem.Tag = "1";
            this.italicoToolStripMenuItem.Text = "Italico";
            this.italicoToolStripMenuItem.Click += new System.EventHandler(this.NIS_Click);
            // 
            // sublinadoToolStripMenuItem
            // 
            this.sublinadoToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.Underline;
            this.sublinadoToolStripMenuItem.Name = "sublinadoToolStripMenuItem";
            this.sublinadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinadoToolStripMenuItem.Tag = "2";
            this.sublinadoToolStripMenuItem.Text = "Sublinado";
            this.sublinadoToolStripMenuItem.Click += new System.EventHandler(this.NIS_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esquerdaToolStripMenuItem,
            this.centralizarToolStripMenuItem,
            this.direitaToolStripMenuItem,
            this.justificarToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.TextFile;
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.TextLeft;
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Tag = "0";
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.Align_Click);
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.TextCenter;
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Tag = "1";
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.Align_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.TextRight;
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Tag = "2";
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.Align_Click);
            // 
            // justificarToolStripMenuItem
            // 
            this.justificarToolStripMenuItem.Image = global::Editor_de_Texto.Properties.Resources.TextJustify;
            this.justificarToolStripMenuItem.Name = "justificarToolStripMenuItem";
            this.justificarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.justificarToolStripMenuItem.Text = "Justificar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_novo,
            this.btn_abrir,
            this.btn_salvar,
            this.toolStripSeparator1,
            this.btn_copiar,
            this.btn_colar,
            this.btn_recortar,
            this.toolStripSeparator2,
            this.btn_negrito,
            this.btn_italico,
            this.btn_sublinhado,
            this.btn_fonte,
            this.toolStripSeparator3,
            this.btn_esquerda,
            this.btn_meio,
            this.btn_direita,
            this.btn_justificar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(606, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_novo
            // 
            this.btn_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_novo.Image = global::Editor_de_Texto.Properties.Resources.NewDocument;
            this.btn_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(23, 22);
            this.btn_novo.Text = "Novo";
            this.btn_novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // btn_abrir
            // 
            this.btn_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_abrir.Image = global::Editor_de_Texto.Properties.Resources.OpenFile;
            this.btn_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(23, 22);
            this.btn_abrir.Text = "Abrir";
            this.btn_abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salvar.Image = global::Editor_de_Texto.Properties.Resources.Save;
            this.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(23, 22);
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_copiar
            // 
            this.btn_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_copiar.Image = global::Editor_de_Texto.Properties.Resources.Copy;
            this.btn_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_copiar.Name = "btn_copiar";
            this.btn_copiar.Size = new System.Drawing.Size(23, 22);
            this.btn_copiar.Tag = "0";
            this.btn_copiar.Text = "Copiar";
            this.btn_copiar.Click += new System.EventHandler(this.CCR_Click);
            // 
            // btn_colar
            // 
            this.btn_colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_colar.Image = global::Editor_de_Texto.Properties.Resources.Paste;
            this.btn_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_colar.Name = "btn_colar";
            this.btn_colar.Size = new System.Drawing.Size(23, 22);
            this.btn_colar.Tag = "1";
            this.btn_colar.Text = "Colar";
            this.btn_colar.Click += new System.EventHandler(this.CCR_Click);
            // 
            // btn_recortar
            // 
            this.btn_recortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_recortar.Image = global::Editor_de_Texto.Properties.Resources.Cut;
            this.btn_recortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_recortar.Name = "btn_recortar";
            this.btn_recortar.Size = new System.Drawing.Size(23, 22);
            this.btn_recortar.Tag = "2";
            this.btn_recortar.Text = "Recortar";
            this.btn_recortar.Click += new System.EventHandler(this.CCR_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_negrito
            // 
            this.btn_negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_negrito.Image = global::Editor_de_Texto.Properties.Resources.Bold;
            this.btn_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_negrito.Name = "btn_negrito";
            this.btn_negrito.Size = new System.Drawing.Size(23, 22);
            this.btn_negrito.Tag = "0";
            this.btn_negrito.Text = "Negrito";
            this.btn_negrito.Click += new System.EventHandler(this.NIS_Click);
            // 
            // btn_italico
            // 
            this.btn_italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_italico.Image = global::Editor_de_Texto.Properties.Resources.Italic;
            this.btn_italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_italico.Name = "btn_italico";
            this.btn_italico.Size = new System.Drawing.Size(23, 22);
            this.btn_italico.Tag = "1";
            this.btn_italico.Text = "Italico";
            this.btn_italico.Click += new System.EventHandler(this.NIS_Click);
            // 
            // btn_sublinhado
            // 
            this.btn_sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_sublinhado.Image = global::Editor_de_Texto.Properties.Resources.Underline;
            this.btn_sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sublinhado.Name = "btn_sublinhado";
            this.btn_sublinhado.Size = new System.Drawing.Size(23, 22);
            this.btn_sublinhado.Tag = "2";
            this.btn_sublinhado.Text = "Sublinhado";
            this.btn_sublinhado.Click += new System.EventHandler(this.NIS_Click);
            // 
            // btn_fonte
            // 
            this.btn_fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_fonte.Image = global::Editor_de_Texto.Properties.Resources.Font;
            this.btn_fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_fonte.Name = "btn_fonte";
            this.btn_fonte.Size = new System.Drawing.Size(23, 22);
            this.btn_fonte.Text = "Fonte";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_esquerda
            // 
            this.btn_esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_esquerda.Image = global::Editor_de_Texto.Properties.Resources.TextLeft;
            this.btn_esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_esquerda.Name = "btn_esquerda";
            this.btn_esquerda.Size = new System.Drawing.Size(23, 22);
            this.btn_esquerda.Tag = "0";
            this.btn_esquerda.Text = "Esquerda";
            this.btn_esquerda.Click += new System.EventHandler(this.Align_Click);
            // 
            // btn_meio
            // 
            this.btn_meio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_meio.Image = global::Editor_de_Texto.Properties.Resources.TextCenter;
            this.btn_meio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_meio.Name = "btn_meio";
            this.btn_meio.Size = new System.Drawing.Size(23, 22);
            this.btn_meio.Tag = "1";
            this.btn_meio.Text = "Meio";
            this.btn_meio.Click += new System.EventHandler(this.Align_Click);
            // 
            // btn_direita
            // 
            this.btn_direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_direita.Image = global::Editor_de_Texto.Properties.Resources.TextRight;
            this.btn_direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_direita.Name = "btn_direita";
            this.btn_direita.Size = new System.Drawing.Size(23, 22);
            this.btn_direita.Tag = "2";
            this.btn_direita.Text = "Direita";
            this.btn_direita.Click += new System.EventHandler(this.Align_Click);
            // 
            // btn_justificar
            // 
            this.btn_justificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_justificar.Image = global::Editor_de_Texto.Properties.Resources.TextJustify;
            this.btn_justificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_justificar.Name = "btn_justificar";
            this.btn_justificar.Size = new System.Drawing.Size(23, 22);
            this.btn_justificar.Text = "Justificar";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txts";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.txts)|*.txts";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 560);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de Texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem1;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem italicoToolStripMenuItem;
        private ToolStripMenuItem sublinadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private ToolStripMenuItem justificarToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btn_novo;
        private ToolStripButton btn_abrir;
        private ToolStripButton btn_salvar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_copiar;
        private ToolStripButton btn_colar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_negrito;
        private ToolStripButton btn_italico;
        private ToolStripButton btn_sublinhado;
        private ToolStripButton btn_fonte;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_esquerda;
        private ToolStripButton btn_meio;
        private ToolStripButton btn_direita;
        private ToolStripButton btn_justificar;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripButton btn_recortar;
        private ToolStripMenuItem recortarToolStripMenuItem;
    }
}