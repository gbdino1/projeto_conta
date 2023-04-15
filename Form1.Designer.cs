
namespace atividade3_recuperacao_gabriel_nicolas
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
            this.lblCorrentista1 = new System.Windows.Forms.Label();
            this.lblCorrentista2 = new System.Windows.Forms.Label();
            this.lblSaldoCorrentista1 = new System.Windows.Forms.Label();
            this.lblSaldoCorrentista2 = new System.Windows.Forms.Label();
            this.btnVersSaldoC1 = new System.Windows.Forms.Button();
            this.btnVerSaldo2 = new System.Windows.Forms.Button();
            this.btnAddC1 = new System.Windows.Forms.Button();
            this.btnAddC2 = new System.Windows.Forms.Button();
            this.btnSubC1 = new System.Windows.Forms.Button();
            this.btnSubC2 = new System.Windows.Forms.Button();
            this.btnTranfC1ToC2 = new System.Windows.Forms.Button();
            this.lblNomeC1 = new System.Windows.Forms.Label();
            this.lblNomeC2 = new System.Windows.Forms.Label();
            this.lblContaC1 = new System.Windows.Forms.Label();
            this.lblContaC2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCorrentista1
            // 
            this.lblCorrentista1.AutoSize = true;
            this.lblCorrentista1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCorrentista1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorrentista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrentista1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCorrentista1.Location = new System.Drawing.Point(75, 27);
            this.lblCorrentista1.Name = "lblCorrentista1";
            this.lblCorrentista1.Size = new System.Drawing.Size(172, 33);
            this.lblCorrentista1.TabIndex = 0;
            this.lblCorrentista1.Text = "Correntista 1";
            // 
            // lblCorrentista2
            // 
            this.lblCorrentista2.AutoSize = true;
            this.lblCorrentista2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCorrentista2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorrentista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrentista2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCorrentista2.Location = new System.Drawing.Point(509, 27);
            this.lblCorrentista2.Name = "lblCorrentista2";
            this.lblCorrentista2.Size = new System.Drawing.Size(172, 33);
            this.lblCorrentista2.TabIndex = 1;
            this.lblCorrentista2.Text = "Correntista 2";
            // 
            // lblSaldoCorrentista1
            // 
            this.lblSaldoCorrentista1.AutoSize = true;
            this.lblSaldoCorrentista1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaldoCorrentista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCorrentista1.Location = new System.Drawing.Point(58, 229);
            this.lblSaldoCorrentista1.Name = "lblSaldoCorrentista1";
            this.lblSaldoCorrentista1.Size = new System.Drawing.Size(158, 31);
            this.lblSaldoCorrentista1.TabIndex = 2;
            this.lblSaldoCorrentista1.Text = "----------------";
            // 
            // lblSaldoCorrentista2
            // 
            this.lblSaldoCorrentista2.AutoSize = true;
            this.lblSaldoCorrentista2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaldoCorrentista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCorrentista2.Location = new System.Drawing.Point(509, 229);
            this.lblSaldoCorrentista2.Name = "lblSaldoCorrentista2";
            this.lblSaldoCorrentista2.Size = new System.Drawing.Size(158, 31);
            this.lblSaldoCorrentista2.TabIndex = 3;
            this.lblSaldoCorrentista2.Text = "----------------";
            // 
            // btnVersSaldoC1
            // 
            this.btnVersSaldoC1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVersSaldoC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVersSaldoC1.Location = new System.Drawing.Point(64, 275);
            this.btnVersSaldoC1.Name = "btnVersSaldoC1";
            this.btnVersSaldoC1.Size = new System.Drawing.Size(152, 37);
            this.btnVersSaldoC1.TabIndex = 4;
            this.btnVersSaldoC1.Text = "Ver Saldo";
            this.btnVersSaldoC1.UseVisualStyleBackColor = false;
            this.btnVersSaldoC1.Click += new System.EventHandler(this.btnVersSaldoC1_Click);
            // 
            // btnVerSaldo2
            // 
            this.btnVerSaldo2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerSaldo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSaldo2.Location = new System.Drawing.Point(510, 275);
            this.btnVerSaldo2.Name = "btnVerSaldo2";
            this.btnVerSaldo2.Size = new System.Drawing.Size(152, 37);
            this.btnVerSaldo2.TabIndex = 5;
            this.btnVerSaldo2.Text = "Ver Saldo";
            this.btnVerSaldo2.UseVisualStyleBackColor = false;
            this.btnVerSaldo2.Click += new System.EventHandler(this.btnVerSaldo2_Click);
            // 
            // btnAddC1
            // 
            this.btnAddC1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddC1.Location = new System.Drawing.Point(64, 318);
            this.btnAddC1.Name = "btnAddC1";
            this.btnAddC1.Size = new System.Drawing.Size(152, 37);
            this.btnAddC1.TabIndex = 6;
            this.btnAddC1.Text = "+ R$ 100";
            this.btnAddC1.UseVisualStyleBackColor = false;
            this.btnAddC1.Click += new System.EventHandler(this.btnAddC1_Click);
            // 
            // btnAddC2
            // 
            this.btnAddC2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddC2.Location = new System.Drawing.Point(510, 330);
            this.btnAddC2.Name = "btnAddC2";
            this.btnAddC2.Size = new System.Drawing.Size(152, 37);
            this.btnAddC2.TabIndex = 7;
            this.btnAddC2.Text = "+ R$ 100";
            this.btnAddC2.UseVisualStyleBackColor = false;
            this.btnAddC2.Click += new System.EventHandler(this.btnAddC2_Click);
            // 
            // btnSubC1
            // 
            this.btnSubC1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubC1.Location = new System.Drawing.Point(64, 371);
            this.btnSubC1.Name = "btnSubC1";
            this.btnSubC1.Size = new System.Drawing.Size(152, 37);
            this.btnSubC1.TabIndex = 8;
            this.btnSubC1.Text = "- R$ 100";
            this.btnSubC1.UseVisualStyleBackColor = false;
            this.btnSubC1.Click += new System.EventHandler(this.btnSubC1_Click);
            // 
            // btnSubC2
            // 
            this.btnSubC2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubC2.Location = new System.Drawing.Point(510, 373);
            this.btnSubC2.Name = "btnSubC2";
            this.btnSubC2.Size = new System.Drawing.Size(152, 37);
            this.btnSubC2.TabIndex = 9;
            this.btnSubC2.Text = "- R$ 100";
            this.btnSubC2.UseVisualStyleBackColor = false;
            this.btnSubC2.Click += new System.EventHandler(this.btnSubC2_Click);
            // 
            // btnTranfC1ToC2
            // 
            this.btnTranfC1ToC2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTranfC1ToC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranfC1ToC2.Location = new System.Drawing.Point(293, 229);
            this.btnTranfC1ToC2.Name = "btnTranfC1ToC2";
            this.btnTranfC1ToC2.Size = new System.Drawing.Size(152, 37);
            this.btnTranfC1ToC2.TabIndex = 10;
            this.btnTranfC1ToC2.Text = "> R$ 100";
            this.btnTranfC1ToC2.UseVisualStyleBackColor = false;
            this.btnTranfC1ToC2.Click += new System.EventHandler(this.btnTranfC1ToC2_Click);
            // 
            // lblNomeC1
            // 
            this.lblNomeC1.AutoSize = true;
            this.lblNomeC1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNomeC1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomeC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeC1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeC1.Location = new System.Drawing.Point(75, 87);
            this.lblNomeC1.Name = "lblNomeC1";
            this.lblNomeC1.Size = new System.Drawing.Size(106, 33);
            this.lblNomeC1.TabIndex = 11;
            this.lblNomeC1.Text = "----------";
            // 
            // lblNomeC2
            // 
            this.lblNomeC2.AutoSize = true;
            this.lblNomeC2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNomeC2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomeC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeC2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeC2.Location = new System.Drawing.Point(509, 87);
            this.lblNomeC2.Name = "lblNomeC2";
            this.lblNomeC2.Size = new System.Drawing.Size(79, 33);
            this.lblNomeC2.TabIndex = 12;
            this.lblNomeC2.Text = "-------";
            // 
            // lblContaC1
            // 
            this.lblContaC1.AutoSize = true;
            this.lblContaC1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContaC1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContaC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaC1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContaC1.Location = new System.Drawing.Point(75, 134);
            this.lblContaC1.Name = "lblContaC1";
            this.lblContaC1.Size = new System.Drawing.Size(106, 33);
            this.lblContaC1.TabIndex = 13;
            this.lblContaC1.Text = "----------";
            // 
            // lblContaC2
            // 
            this.lblContaC2.AutoSize = true;
            this.lblContaC2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContaC2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContaC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaC2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContaC2.Location = new System.Drawing.Point(509, 134);
            this.lblContaC2.Name = "lblContaC2";
            this.lblContaC2.Size = new System.Drawing.Size(133, 33);
            this.lblContaC2.TabIndex = 14;
            this.lblContaC2.Text = "-------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContaC2);
            this.Controls.Add(this.lblContaC1);
            this.Controls.Add(this.lblNomeC2);
            this.Controls.Add(this.lblNomeC1);
            this.Controls.Add(this.btnTranfC1ToC2);
            this.Controls.Add(this.btnSubC2);
            this.Controls.Add(this.btnSubC1);
            this.Controls.Add(this.btnAddC2);
            this.Controls.Add(this.btnAddC1);
            this.Controls.Add(this.btnVerSaldo2);
            this.Controls.Add(this.btnVersSaldoC1);
            this.Controls.Add(this.lblSaldoCorrentista2);
            this.Controls.Add(this.lblSaldoCorrentista1);
            this.Controls.Add(this.lblCorrentista2);
            this.Controls.Add(this.lblCorrentista1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorrentista1;
        private System.Windows.Forms.Label lblCorrentista2;
        private System.Windows.Forms.Label lblSaldoCorrentista1;
        private System.Windows.Forms.Label lblSaldoCorrentista2;
        private System.Windows.Forms.Button btnVersSaldoC1;
        private System.Windows.Forms.Button btnVerSaldo2;
        private System.Windows.Forms.Button btnAddC1;
        private System.Windows.Forms.Button btnAddC2;
        private System.Windows.Forms.Button btnSubC1;
        private System.Windows.Forms.Button btnSubC2;
        private System.Windows.Forms.Button btnTranfC1ToC2;
        private System.Windows.Forms.Label lblNomeC1;
        private System.Windows.Forms.Label lblNomeC2;
        private System.Windows.Forms.Label lblContaC1;
        private System.Windows.Forms.Label lblContaC2;
    }
}

