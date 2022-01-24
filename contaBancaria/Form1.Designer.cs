namespace contaBancaria
{
    partial class frmContaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContaBancaria));
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpOpcoes = new System.Windows.Forms.GroupBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.grpValorDeposito = new System.Windows.Forms.GroupBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.btnConfirmarDepósito = new System.Windows.Forms.Button();
            this.txtValorDepósito = new System.Windows.Forms.TextBox();
            this.grpSaudacao = new System.Windows.Forms.GroupBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblOlaCliente = new System.Windows.Forms.Label();
            this.grpValorSaque = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarSaque = new System.Windows.Forms.Button();
            this.txtValorSaque = new System.Windows.Forms.TextBox();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.grpLogin.SuspendLayout();
            this.grpOpcoes.SuspendLayout();
            this.grpValorDeposito.SuspendLayout();
            this.grpSaudacao.SuspendLayout();
            this.grpValorSaque.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            resources.ApplyResources(this.grpLogin, "grpLogin");
            this.grpLogin.Controls.Add(this.btnEntrar);
            this.grpLogin.Controls.Add(this.lblNome);
            this.grpLogin.Controls.Add(this.txtNome);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.TabStop = false;
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.Name = "lblNome";
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // grpOpcoes
            // 
            resources.ApplyResources(this.grpOpcoes, "grpOpcoes");
            this.grpOpcoes.Controls.Add(this.btnDepositar);
            this.grpOpcoes.Controls.Add(this.btnSacar);
            this.grpOpcoes.Controls.Add(this.btnTransferir);
            this.grpOpcoes.Name = "grpOpcoes";
            this.grpOpcoes.TabStop = false;
            // 
            // btnDepositar
            // 
            resources.ApplyResources(this.btnDepositar, "btnDepositar");
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            resources.ApplyResources(this.btnSacar, "btnSacar");
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click_1);
            // 
            // btnTransferir
            // 
            resources.ApplyResources(this.btnTransferir, "btnTransferir");
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            // 
            // grpValorDeposito
            // 
            resources.ApplyResources(this.grpValorDeposito, "grpValorDeposito");
            this.grpValorDeposito.Controls.Add(this.btnVoltar2);
            this.grpValorDeposito.Controls.Add(this.lblDep);
            this.grpValorDeposito.Controls.Add(this.btnConfirmarDepósito);
            this.grpValorDeposito.Controls.Add(this.txtValorDepósito);
            this.grpValorDeposito.Name = "grpValorDeposito";
            this.grpValorDeposito.TabStop = false;
            // 
            // lblDep
            // 
            resources.ApplyResources(this.lblDep, "lblDep");
            this.lblDep.Name = "lblDep";
            // 
            // btnConfirmarDepósito
            // 
            resources.ApplyResources(this.btnConfirmarDepósito, "btnConfirmarDepósito");
            this.btnConfirmarDepósito.Name = "btnConfirmarDepósito";
            this.btnConfirmarDepósito.UseVisualStyleBackColor = true;
            this.btnConfirmarDepósito.Click += new System.EventHandler(this.btnConfirmarDepósito_Click);
            // 
            // txtValorDepósito
            // 
            resources.ApplyResources(this.txtValorDepósito, "txtValorDepósito");
            this.txtValorDepósito.Name = "txtValorDepósito";
            // 
            // grpSaudacao
            // 
            resources.ApplyResources(this.grpSaudacao, "grpSaudacao");
            this.grpSaudacao.Controls.Add(this.txtNomeCliente);
            this.grpSaudacao.Controls.Add(this.lblSaldo);
            this.grpSaudacao.Controls.Add(this.txtSaldo);
            this.grpSaudacao.Controls.Add(this.lblOlaCliente);
            this.grpSaudacao.Name = "grpSaudacao";
            this.grpSaudacao.TabStop = false;
            // 
            // txtNomeCliente
            // 
            resources.ApplyResources(this.txtNomeCliente, "txtNomeCliente");
            this.txtNomeCliente.Name = "txtNomeCliente";
            // 
            // lblSaldo
            // 
            resources.ApplyResources(this.lblSaldo, "lblSaldo");
            this.lblSaldo.Name = "lblSaldo";
            // 
            // txtSaldo
            // 
            resources.ApplyResources(this.txtSaldo, "txtSaldo");
            this.txtSaldo.Name = "txtSaldo";
            // 
            // lblOlaCliente
            // 
            resources.ApplyResources(this.lblOlaCliente, "lblOlaCliente");
            this.lblOlaCliente.Name = "lblOlaCliente";
            // 
            // grpValorSaque
            // 
            resources.ApplyResources(this.grpValorSaque, "grpValorSaque");
            this.grpValorSaque.Controls.Add(this.btnVoltar);
            this.grpValorSaque.Controls.Add(this.label1);
            this.grpValorSaque.Controls.Add(this.btnConfirmarSaque);
            this.grpValorSaque.Controls.Add(this.txtValorSaque);
            this.grpValorSaque.Name = "grpValorSaque";
            this.grpValorSaque.TabStop = false;
            // 
            // btnVoltar
            // 
            resources.ApplyResources(this.btnVoltar, "btnVoltar");
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnConfirmarSaque
            // 
            resources.ApplyResources(this.btnConfirmarSaque, "btnConfirmarSaque");
            this.btnConfirmarSaque.Name = "btnConfirmarSaque";
            this.btnConfirmarSaque.UseVisualStyleBackColor = true;
            this.btnConfirmarSaque.Click += new System.EventHandler(this.btnConfirmarSaque_Click);
            // 
            // txtValorSaque
            // 
            resources.ApplyResources(this.txtValorSaque, "txtValorSaque");
            this.txtValorSaque.Name = "txtValorSaque";
            // 
            // btnVoltar2
            // 
            resources.ApplyResources(this.btnVoltar2, "btnVoltar2");
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // frmContaBancaria
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.grpValorSaque);
            this.Controls.Add(this.grpValorDeposito);
            this.Controls.Add(this.grpSaudacao);
            this.Controls.Add(this.grpOpcoes);
            this.Controls.Add(this.grpLogin);
            this.Name = "frmContaBancaria";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpOpcoes.ResumeLayout(false);
            this.grpValorDeposito.ResumeLayout(false);
            this.grpValorDeposito.PerformLayout();
            this.grpSaudacao.ResumeLayout(false);
            this.grpSaudacao.PerformLayout();
            this.grpValorSaque.ResumeLayout(false);
            this.grpValorSaque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grpOpcoes;
        private System.Windows.Forms.GroupBox grpSaudacao;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblOlaCliente;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox grpValorDeposito;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Button btnConfirmarDepósito;
        private System.Windows.Forms.TextBox txtValorDepósito;
        private System.Windows.Forms.GroupBox grpValorSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarSaque;
        private System.Windows.Forms.TextBox txtValorSaque;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnVoltar2;
    }
}

