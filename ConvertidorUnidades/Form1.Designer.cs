namespace ConvertidorUnidades
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCantidadConvertir = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDe = new System.Windows.Forms.ListBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtCantidadConvertida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCantidadConvertir);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Location = new System.Drawing.Point(66, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 82);
            this.panel1.TabIndex = 0;
            // 
            // txtCantidadConvertir
            // 
            this.txtCantidadConvertir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadConvertir.Location = new System.Drawing.Point(135, 27);
            this.txtCantidadConvertir.Name = "txtCantidadConvertir";
            this.txtCantidadConvertir.Size = new System.Drawing.Size(239, 29);
            this.txtCantidadConvertir.TabIndex = 1;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(19, 35);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 21);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(66, 122);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 21);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(182, 119);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(281, 29);
            this.cboTipo.TabIndex = 2;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(305, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "A:";
            // 
            // lstDe
            // 
            this.lstDe.FormattingEnabled = true;
            this.lstDe.ItemHeight = 15;
            this.lstDe.Location = new System.Drawing.Point(66, 202);
            this.lstDe.Name = "lstDe";
            this.lstDe.Size = new System.Drawing.Size(158, 199);
            this.lstDe.TabIndex = 5;
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 15;
            this.lstA.Location = new System.Drawing.Point(305, 202);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(158, 199);
            this.lstA.TabIndex = 6;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertir.Location = new System.Drawing.Point(223, 425);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(87, 34);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtCantidadConvertida
            // 
            this.txtCantidadConvertida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadConvertida.Location = new System.Drawing.Point(189, 32);
            this.txtCantidadConvertida.Name = "txtCantidadConvertida";
            this.txtCantidadConvertida.Size = new System.Drawing.Size(185, 29);
            this.txtCantidadConvertida.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad Convertida";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCantidadConvertida);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(66, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 82);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lstA);
            this.Controls.Add(this.lstDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox txtCantidadConvertir;
        private Label lblCantidad;
        private Label lblTipo;
        private ComboBox cboTipo;
        private Label label1;
        private Label label2;
        private ListBox lstDe;
        private ListBox lstA;
        private Button btnConvertir;
        private TextBox txtCantidadConvertida;
        private Label label3;
        private Panel panel2;
    }
}