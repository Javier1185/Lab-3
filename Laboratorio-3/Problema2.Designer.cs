namespace Laboratorio_3
{
    partial class Problema2
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
            this.btmIngresarNum = new System.Windows.Forms.Button();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.btmAletorio = new System.Windows.Forms.Button();
            this.dgvNum = new System.Windows.Forms.DataGridView();
            this.textNum = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btmIngresarNum
            // 
            this.btmIngresarNum.BackColor = System.Drawing.Color.DarkRed;
            this.btmIngresarNum.Location = new System.Drawing.Point(82, 111);
            this.btmIngresarNum.Name = "btmIngresarNum";
            this.btmIngresarNum.Size = new System.Drawing.Size(149, 58);
            this.btmIngresarNum.TabIndex = 0;
            this.btmIngresarNum.Text = "Ingresar";
            this.btmIngresarNum.UseVisualStyleBackColor = false;
            // 
            // btmEliminar
            // 
            this.btmEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btmEliminar.Location = new System.Drawing.Point(82, 218);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(149, 43);
            this.btmEliminar.TabIndex = 1;
            this.btmEliminar.Text = "Eliminar";
            this.btmEliminar.UseVisualStyleBackColor = false;
            // 
            // btmAletorio
            // 
            this.btmAletorio.BackColor = System.Drawing.Color.DarkRed;
            this.btmAletorio.Location = new System.Drawing.Point(82, 276);
            this.btmAletorio.Name = "btmAletorio";
            this.btmAletorio.Size = new System.Drawing.Size(149, 47);
            this.btmAletorio.TabIndex = 2;
            this.btmAletorio.Text = "Aleatorio";
            this.btmAletorio.UseVisualStyleBackColor = false;
            // 
            // dgvNum
            // 
            this.dgvNum.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNum.Location = new System.Drawing.Point(326, 146);
            this.dgvNum.Name = "dgvNum";
            this.dgvNum.Size = new System.Drawing.Size(240, 150);
            this.dgvNum.TabIndex = 3;
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(88, 175);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(143, 20);
            this.textNum.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(195, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(466, 64);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Cuadro de Calculo";
            // 
            // Problema2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.dgvNum);
            this.Controls.Add(this.btmAletorio);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.btmIngresarNum);
            this.Name = "Problema2";
            this.Text = "Problema2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmIngresarNum;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Button btmAletorio;
        private System.Windows.Forms.DataGridView dgvNum;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label lblTitulo;
    }
}