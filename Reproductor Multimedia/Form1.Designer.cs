namespace Reproductor_Multimedia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mpMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbListaArchivos = new System.Windows.Forms.ListBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mpMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // mpMediaPlayer
            // 
            this.mpMediaPlayer.Enabled = true;
            this.mpMediaPlayer.Location = new System.Drawing.Point(25, 24);
            this.mpMediaPlayer.Name = "mpMediaPlayer";
            this.mpMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpMediaPlayer.OcxState")));
            this.mpMediaPlayer.Size = new System.Drawing.Size(319, 390);
            this.mpMediaPlayer.TabIndex = 0;
            // 
            // lbListaArchivos
            // 
            this.lbListaArchivos.FormattingEnabled = true;
            this.lbListaArchivos.Location = new System.Drawing.Point(376, 24);
            this.lbListaArchivos.Name = "lbListaArchivos";
            this.lbListaArchivos.Size = new System.Drawing.Size(281, 342);
            this.lbListaArchivos.TabIndex = 1;
            this.lbListaArchivos.SelectedIndexChanged += new System.EventHandler(this.lbListaArchivos_SelectedIndexChanged);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(582, 391);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lbListaArchivos);
            this.Controls.Add(this.mpMediaPlayer);
            this.Name = "Form1";
            this.Text = "Mi Explorador Multimedia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mpMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mpMediaPlayer;
        private System.Windows.Forms.ListBox lbListaArchivos;
        private System.Windows.Forms.Button btnAbrir;
    }
}

