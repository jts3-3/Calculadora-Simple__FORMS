namespace Treino
{
    partial class TelaCalcular
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCalcular));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.numeroum = new System.Windows.Forms.NumericUpDown();
            this.numerodois = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Cbopaçao = new System.Windows.Forms.ComboBox();
            this.pctCalculadora = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbresultado = new System.Windows.Forms.ListBox();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.BtnCreditos = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numeroum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerodois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCalculadora)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.toolTip1.SetToolTip(this.printPreviewDialog1, resources.GetString("printPreviewDialog1.ToolTip"));
            // 
            // numeroum
            // 
            resources.ApplyResources(this.numeroum, "numeroum");
            this.numeroum.Name = "numeroum";
            this.toolTip1.SetToolTip(this.numeroum, resources.GetString("numeroum.ToolTip"));
            this.numeroum.ValueChanged += new System.EventHandler(this.numeroum_ValueChanged);
            // 
            // numerodois
            // 
            resources.ApplyResources(this.numerodois, "numerodois");
            this.numerodois.Name = "numerodois";
            this.toolTip1.SetToolTip(this.numerodois, resources.GetString("numerodois.ToolTip"));
            // 
            // Cbopaçao
            // 
            resources.ApplyResources(this.Cbopaçao, "Cbopaçao");
            this.Cbopaçao.FormattingEnabled = true;
            this.Cbopaçao.Items.AddRange(new object[] {
            resources.GetString("Cbopaçao.Items"),
            resources.GetString("Cbopaçao.Items1"),
            resources.GetString("Cbopaçao.Items2"),
            resources.GetString("Cbopaçao.Items3")});
            this.Cbopaçao.Name = "Cbopaçao";
            this.toolTip1.SetToolTip(this.Cbopaçao, resources.GetString("Cbopaçao.ToolTip"));
            // 
            // pctCalculadora
            // 
            resources.ApplyResources(this.pctCalculadora, "pctCalculadora");
            this.pctCalculadora.Name = "pctCalculadora";
            this.pctCalculadora.TabStop = false;
            this.toolTip1.SetToolTip(this.pctCalculadora, resources.GetString("pctCalculadora.ToolTip"));
            this.pctCalculadora.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbresultado);
            this.groupBox1.Controls.Add(this.btnResetar);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numeroum);
            this.groupBox1.Controls.Add(this.Cbopaçao);
            this.groupBox1.Controls.Add(this.numerodois);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // lbresultado
            // 
            resources.ApplyResources(this.lbresultado, "lbresultado");
            this.lbresultado.FormattingEnabled = true;
            this.lbresultado.Items.AddRange(new object[] {
            resources.GetString("lbresultado.Items")});
            this.lbresultado.Name = "lbresultado";
            this.toolTip1.SetToolTip(this.lbresultado, resources.GetString("lbresultado.ToolTip"));
            this.lbresultado.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnResetar
            // 
            resources.ApplyResources(this.btnResetar, "btnResetar");
            this.btnResetar.Name = "btnResetar";
            this.toolTip1.SetToolTip(this.btnResetar, resources.GetString("btnResetar.ToolTip"));
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCalcular
            // 
            resources.ApplyResources(this.btnCalcular, "btnCalcular");
            this.btnCalcular.Name = "btnCalcular";
            this.toolTip1.SetToolTip(this.btnCalcular, resources.GetString("btnCalcular.ToolTip"));
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.toolTip1.SetToolTip(this.btnSair, resources.GetString("btnSair.ToolTip"));
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCreditos
            // 
            resources.ApplyResources(this.BtnCreditos, "BtnCreditos");
            this.BtnCreditos.Name = "BtnCreditos";
            this.toolTip1.SetToolTip(this.BtnCreditos, resources.GetString("BtnCreditos.ToolTip"));
            this.BtnCreditos.UseVisualStyleBackColor = true;
            this.BtnCreditos.Click += new System.EventHandler(this.button4_Click);
            // 
            // TelaCalcular
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.BtnCreditos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pctCalculadora);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaCalcular";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeroum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerodois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCalculadora)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private ToolTip toolTip1;
        private NumericUpDown numeroum;
        private NumericUpDown numerodois;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox Cbopaçao;
        private PictureBox pctCalculadora;
        private GroupBox groupBox1;
        private Button btnResetar;
        private Button btnCalcular;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSair;
        private Button BtnCreditos;
        private ListBox lbresultado;
        private Label label4;
    }
}