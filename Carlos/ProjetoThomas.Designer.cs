namespace Carlos
{
    partial class ProjetoThomas
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
            this.components = new System.ComponentModel.Container();
            this.Botoes = new System.Windows.Forms.GroupBox();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnInc = new System.Windows.Forms.Button();
            this.Formulario = new System.Windows.Forms.GroupBox();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnSal = new System.Windows.Forms.Button();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.txtNivDor = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstInf = new System.Windows.Forms.ListView();
            this.projetoThomasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoThomasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projetoThomasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Botoes.SuspendLayout();
            this.Formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoThomasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoThomasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoThomasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Botoes
            // 
            this.Botoes.Controls.Add(this.btnExc);
            this.Botoes.Controls.Add(this.btnInc);
            this.Botoes.Location = new System.Drawing.Point(383, 12);
            this.Botoes.Name = "Botoes";
            this.Botoes.Size = new System.Drawing.Size(405, 51);
            this.Botoes.TabIndex = 1;
            this.Botoes.TabStop = false;
            // 
            // btnExc
            // 
            this.btnExc.Location = new System.Drawing.Point(124, 19);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(75, 23);
            this.btnExc.TabIndex = 1;
            this.btnExc.Text = "Excluir";
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.BtnExc_Click);
            // 
            // btnInc
            // 
            this.btnInc.Location = new System.Drawing.Point(6, 19);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(75, 23);
            this.btnInc.TabIndex = 0;
            this.btnInc.Text = "Incluir";
            this.btnInc.UseVisualStyleBackColor = true;
            this.btnInc.Click += new System.EventHandler(this.BtnInc_Click);
            // 
            // Formulario
            // 
            this.Formulario.Controls.Add(this.rbtSim);
            this.Formulario.Controls.Add(this.rbtNao);
            this.Formulario.Controls.Add(this.btnCanc);
            this.Formulario.Controls.Add(this.btnSal);
            this.Formulario.Controls.Add(this.txtCusto);
            this.Formulario.Controls.Add(this.txtDist);
            this.Formulario.Controls.Add(this.txtNivDor);
            this.Formulario.Controls.Add(this.txtData);
            this.Formulario.Controls.Add(this.label7);
            this.Formulario.Controls.Add(this.label6);
            this.Formulario.Controls.Add(this.label5);
            this.Formulario.Controls.Add(this.label3);
            this.Formulario.Controls.Add(this.label1);
            this.Formulario.Location = new System.Drawing.Point(383, 69);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(405, 288);
            this.Formulario.TabIndex = 2;
            this.Formulario.TabStop = false;
            // 
            // rbtSim
            // 
            this.rbtSim.AutoSize = true;
            this.rbtSim.Location = new System.Drawing.Point(243, 92);
            this.rbtSim.Name = "rbtSim";
            this.rbtSim.Size = new System.Drawing.Size(42, 17);
            this.rbtSim.TabIndex = 13;
            this.rbtSim.TabStop = true;
            this.rbtSim.Text = "Sim";
            this.rbtSim.UseVisualStyleBackColor = true;
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.Location = new System.Drawing.Point(124, 92);
            this.rbtNao.Name = "rbtNao";
            this.rbtNao.Size = new System.Drawing.Size(45, 17);
            this.rbtNao.TabIndex = 3;
            this.rbtNao.TabStop = true;
            this.rbtNao.Text = "Nao";
            this.rbtNao.UseVisualStyleBackColor = true;
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(168, 209);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 2;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.BtnCanc_Click);
            // 
            // btnSal
            // 
            this.btnSal.Location = new System.Drawing.Point(42, 209);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(75, 23);
            this.btnSal.TabIndex = 3;
            this.btnSal.Text = "Salvar";
            this.btnSal.UseVisualStyleBackColor = true;
            this.btnSal.Click += new System.EventHandler(this.BtnSal_Click);
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(124, 40);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(261, 20);
            this.txtCusto.TabIndex = 12;
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(124, 66);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(261, 20);
            this.txtDist.TabIndex = 11;
            // 
            // txtNivDor
            // 
            this.txtNivDor.Location = new System.Drawing.Point(124, 114);
            this.txtNivDor.Name = "txtNivDor";
            this.txtNivDor.Size = new System.Drawing.Size(261, 20);
            this.txtNivDor.TabIndex = 10;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(124, 13);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(261, 20);
            this.txtData.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Custo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Distancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Captura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nivel dor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data";
            // 
            // lstInf
            // 
            this.lstInf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstInf.FullRowSelect = true;
            this.lstInf.GridLines = true;
            this.lstInf.HideSelection = false;
            this.lstInf.Location = new System.Drawing.Point(14, 12);
            this.lstInf.MultiSelect = false;
            this.lstInf.Name = "lstInf";
            this.lstInf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstInf.Size = new System.Drawing.Size(349, 345);
            this.lstInf.TabIndex = 3;
            this.lstInf.UseCompatibleStateImageBehavior = false;
            this.lstInf.View = System.Windows.Forms.View.Details;
            this.lstInf.SelectedIndexChanged += new System.EventHandler(this.LstInf_SelectedIndexChanged);
            this.lstInf.DoubleClick += new System.EventHandler(this.LstInf_DoubleClick);
            // 
            // projetoThomasBindingSource
            // 
            this.projetoThomasBindingSource.DataSource = typeof(Carlos.ProjetoThomas);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Carlos.Program);
            // 
            // projetoThomasBindingSource1
            // 
            this.projetoThomasBindingSource1.DataSource = typeof(Carlos.ProjetoThomas);
            // 
            // projetoThomasBindingSource2
            // 
            this.projetoThomasBindingSource2.DataSource = typeof(Carlos.ProjetoThomas);
            // 
            // ProjetoThomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstInf);
            this.Controls.Add(this.Formulario);
            this.Controls.Add(this.Botoes);
            this.Name = "ProjetoThomas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Botoes.ResumeLayout(false);
            this.Formulario.ResumeLayout(false);
            this.Formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoThomasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoThomasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoThomasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Botoes;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnInc;
        private System.Windows.Forms.GroupBox Formulario;
        private System.Windows.Forms.RadioButton rbtSim;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnSal;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.TextBox txtNivDor;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource projetoThomasBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource projetoThomasBindingSource1;
        private System.Windows.Forms.BindingSource projetoThomasBindingSource2;
        public System.Windows.Forms.ListView lstInf;
    }
}

