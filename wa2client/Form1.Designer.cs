namespace wa2client
{
    partial class frmclient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmclient));
            this.tbtext = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.tbip = new System.Windows.Forms.TextBox();
            this.tbport = new System.Windows.Forms.TextBox();
            this.btnconectar = new System.Windows.Forms.Button();
            this.tbchat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbtext
            // 
            this.tbtext.Location = new System.Drawing.Point(396, 386);
            this.tbtext.Name = "tbtext";
            this.tbtext.Size = new System.Drawing.Size(328, 20);
            this.tbtext.TabIndex = 0;
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(737, 386);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(51, 22);
            this.btnenviar.TabIndex = 1;
            this.btnenviar.Text = "enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // tbip
            // 
            this.tbip.Location = new System.Drawing.Point(35, 71);
            this.tbip.Name = "tbip";
            this.tbip.Size = new System.Drawing.Size(167, 20);
            this.tbip.TabIndex = 2;
            this.tbip.Text = "ip";
            // 
            // tbport
            // 
            this.tbport.Location = new System.Drawing.Point(35, 108);
            this.tbport.Name = "tbport";
            this.tbport.Size = new System.Drawing.Size(167, 20);
            this.tbport.TabIndex = 2;
            this.tbport.Text = "porta";
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(225, 86);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(82, 27);
            this.btnconectar.TabIndex = 3;
            this.btnconectar.Text = "conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // tbchat
            // 
            this.tbchat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbchat.Location = new System.Drawing.Point(396, 12);
            this.tbchat.Multiline = true;
            this.tbchat.Name = "tbchat";
            this.tbchat.Size = new System.Drawing.Size(392, 357);
            this.tbchat.TabIndex = 4;
            // 
            // frmclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbchat);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.tbport);
            this.Controls.Add(this.tbip);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.tbtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmclient";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmclient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbtext;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.TextBox tbip;
        private System.Windows.Forms.TextBox tbport;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.TextBox tbchat;
    }
}

