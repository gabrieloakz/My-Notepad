namespace My_Notepad
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuFicheiro = new System.Windows.Forms.ToolStripSplitButton();
            this.menuEditar = new System.Windows.Forms.ToolStripSplitButton();
            this.menuFormatar = new System.Windows.Forms.ToolStripSplitButton();
            this.menuFicheiroNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarSelecionar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarProcurar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarCores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarCoresLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarCoresFundo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFormatarAlinhamentoEsquerda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamentoCentro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamentoDireita = new System.Windows.Forms.ToolStripMenuItem();
            this.rbTexto = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheiro,
            this.menuEditar,
            this.menuFormatar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuFicheiro
            // 
            this.menuFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheiroNovo,
            this.menuFicheiroAbrir,
            this.menuFicheiroGuardar,
            this.toolStripMenuItem1,
            this.menuFicheiroSair});
            this.menuFicheiro.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiro.Image")));
            this.menuFicheiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFicheiro.Name = "menuFicheiro";
            this.menuFicheiro.Size = new System.Drawing.Size(95, 34);
            this.menuFicheiro.Text = "Ficheiro";
            // 
            // menuEditar
            // 
            this.menuEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditarCortar,
            this.menuEditarCopiar,
            this.menuEditarColar,
            this.toolStripMenuItem2,
            this.menuEditarSelecionar,
            this.menuEditarProcurar});
            this.menuEditar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditar.Image")));
            this.menuEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditar.Name = "menuEditar";
            this.menuEditar.Size = new System.Drawing.Size(83, 34);
            this.menuEditar.Text = "Editar";
            // 
            // menuFormatar
            // 
            this.menuFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarLetra,
            this.menuFormatarCores,
            this.menuFormatarAlinhamento});
            this.menuFormatar.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatar.Image")));
            this.menuFormatar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFormatar.Name = "menuFormatar";
            this.menuFormatar.Size = new System.Drawing.Size(101, 34);
            this.menuFormatar.Text = "Formatar";
            // 
            // menuFicheiroNovo
            // 
            this.menuFicheiroNovo.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiroNovo.Image")));
            this.menuFicheiroNovo.Name = "menuFicheiroNovo";
            this.menuFicheiroNovo.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroNovo.Text = "Novo";
            this.menuFicheiroNovo.Click += new System.EventHandler(this.menuFicheiroNovo_Click);
            // 
            // menuFicheiroAbrir
            // 
            this.menuFicheiroAbrir.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiroAbrir.Image")));
            this.menuFicheiroAbrir.Name = "menuFicheiroAbrir";
            this.menuFicheiroAbrir.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroAbrir.Text = "Abrir";
            // 
            // menuFicheiroGuardar
            // 
            this.menuFicheiroGuardar.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiroGuardar.Image")));
            this.menuFicheiroGuardar.Name = "menuFicheiroGuardar";
            this.menuFicheiroGuardar.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroGuardar.Text = "Guardar";
            // 
            // menuFicheiroSair
            // 
            this.menuFicheiroSair.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiroSair.Image")));
            this.menuFicheiroSair.Name = "menuFicheiroSair";
            this.menuFicheiroSair.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroSair.Text = "Sair";
            // 
            // menuEditarCortar
            // 
            this.menuEditarCortar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarCortar.Image")));
            this.menuEditarCortar.Name = "menuEditarCortar";
            this.menuEditarCortar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarCortar.Text = "Cortar";
            // 
            // menuEditarCopiar
            // 
            this.menuEditarCopiar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarCopiar.Image")));
            this.menuEditarCopiar.Name = "menuEditarCopiar";
            this.menuEditarCopiar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarCopiar.Text = "Copiar";
            // 
            // menuEditarColar
            // 
            this.menuEditarColar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarColar.Image")));
            this.menuEditarColar.Name = "menuEditarColar";
            this.menuEditarColar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarColar.Text = "Colar";
            // 
            // menuEditarSelecionar
            // 
            this.menuEditarSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarSelecionar.Image")));
            this.menuEditarSelecionar.Name = "menuEditarSelecionar";
            this.menuEditarSelecionar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarSelecionar.Text = "Selecionar tudo";
            // 
            // menuEditarProcurar
            // 
            this.menuEditarProcurar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarProcurar.Image")));
            this.menuEditarProcurar.Name = "menuEditarProcurar";
            this.menuEditarProcurar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarProcurar.Text = "Procurar";
            // 
            // menuFormatarLetra
            // 
            this.menuFormatarLetra.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarLetra.Image")));
            this.menuFormatarLetra.Name = "menuFormatarLetra";
            this.menuFormatarLetra.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarLetra.Text = "Letra";
            // 
            // menuFormatarCores
            // 
            this.menuFormatarCores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarCoresLetra,
            this.menuFormatarCoresFundo});
            this.menuFormatarCores.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarCores.Image")));
            this.menuFormatarCores.Name = "menuFormatarCores";
            this.menuFormatarCores.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarCores.Text = "Cores";
            // 
            // menuFormatarAlinhamento
            // 
            this.menuFormatarAlinhamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarAlinhamentoEsquerda,
            this.menuFormatarAlinhamentoCentro,
            this.menuFormatarAlinhamentoDireita});
            this.menuFormatarAlinhamento.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarAlinhamento.Image")));
            this.menuFormatarAlinhamento.Name = "menuFormatarAlinhamento";
            this.menuFormatarAlinhamento.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarAlinhamento.Text = "Alinhamento";
            // 
            // menuFormatarCoresLetra
            // 
            this.menuFormatarCoresLetra.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarCoresLetra.Image")));
            this.menuFormatarCoresLetra.Name = "menuFormatarCoresLetra";
            this.menuFormatarCoresLetra.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarCoresLetra.Text = "Letra";
            // 
            // menuFormatarCoresFundo
            // 
            this.menuFormatarCoresFundo.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarCoresFundo.Image")));
            this.menuFormatarCoresFundo.Name = "menuFormatarCoresFundo";
            this.menuFormatarCoresFundo.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarCoresFundo.Text = "Fundo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
            // 
            // menuFormatarAlinhamentoEsquerda
            // 
            this.menuFormatarAlinhamentoEsquerda.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarAlinhamentoEsquerda.Image")));
            this.menuFormatarAlinhamentoEsquerda.Name = "menuFormatarAlinhamentoEsquerda";
            this.menuFormatarAlinhamentoEsquerda.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarAlinhamentoEsquerda.Text = "Esquerda";
            // 
            // menuFormatarAlinhamentoCentro
            // 
            this.menuFormatarAlinhamentoCentro.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarAlinhamentoCentro.Image")));
            this.menuFormatarAlinhamentoCentro.Name = "menuFormatarAlinhamentoCentro";
            this.menuFormatarAlinhamentoCentro.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarAlinhamentoCentro.Text = "Centro";
            // 
            // menuFormatarAlinhamentoDireita
            // 
            this.menuFormatarAlinhamentoDireita.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarAlinhamentoDireita.Image")));
            this.menuFormatarAlinhamentoDireita.Name = "menuFormatarAlinhamentoDireita";
            this.menuFormatarAlinhamentoDireita.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarAlinhamentoDireita.Text = "Direita";
            // 
            // rbTexto
            // 
            this.rbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTexto.Location = new System.Drawing.Point(0, 37);
            this.rbTexto.Name = "rbTexto";
            this.rbTexto.Size = new System.Drawing.Size(784, 704);
            this.rbTexto.TabIndex = 1;
            this.rbTexto.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rbTexto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "My Notepad.";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton menuFicheiro;
        private System.Windows.Forms.ToolStripSplitButton menuEditar;
        private System.Windows.Forms.ToolStripSplitButton menuFormatar;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroNovo;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroAbrir;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroGuardar;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroSair;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCortar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarColar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarSelecionar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarProcurar;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarLetra;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarCores;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamento;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarCoresLetra;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarCoresFundo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamentoEsquerda;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamentoCentro;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamentoDireita;
        private System.Windows.Forms.RichTextBox rbTexto;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

