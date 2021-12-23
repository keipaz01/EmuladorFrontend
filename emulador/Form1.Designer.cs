namespace emulador
{
    partial class frmLista
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
            this.dgvRoms = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lvlVistaPrevia = new System.Windows.Forms.Label();
            this.picJuegos = new System.Windows.Forms.PictureBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoms
            // 
            this.dgvRoms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoms.Location = new System.Drawing.Point(202, 38);
            this.dgvRoms.Name = "dgvRoms";
            this.dgvRoms.Size = new System.Drawing.Size(433, 382);
            this.dgvRoms.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(202, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(372, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lvlVistaPrevia
            // 
            this.lvlVistaPrevia.AutoSize = true;
            this.lvlVistaPrevia.Location = new System.Drawing.Point(13, 73);
            this.lvlVistaPrevia.Name = "lvlVistaPrevia";
            this.lvlVistaPrevia.Size = new System.Drawing.Size(65, 13);
            this.lvlVistaPrevia.TabIndex = 1;
            this.lvlVistaPrevia.Text = "Vista previa:";
            // 
            // picJuegos
            // 
            this.picJuegos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picJuegos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picJuegos.Location = new System.Drawing.Point(16, 114);
            this.picJuegos.Name = "picJuegos";
            this.picJuegos.Size = new System.Drawing.Size(167, 167);
            this.picJuegos.TabIndex = 2;
            this.picJuegos.TabStop = false;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(16, 12);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(164, 38);
            this.btnEjecutar.TabIndex = 3;
            this.btnEjecutar.Text = "Ejemplo de como ejecutar otro programa";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 432);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.picJuegos);
            this.Controls.Add(this.lvlVistaPrevia);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvRoms);
            this.Name = "frmLista";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoms;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lvlVistaPrevia;
        private System.Windows.Forms.PictureBox picJuegos;
        private System.Windows.Forms.Button btnEjecutar;
    }
}

