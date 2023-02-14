namespace Conversor_Temperatura
{
    partial class frmConvertTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConvertTemp));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblValorConvert = new System.Windows.Forms.Label();
            this.lblConvertido = new System.Windows.Forms.Label();
            this.combocf = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Location = new System.Drawing.Point(116, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Conversor de temperatura";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValorConvert
            // 
            this.lblValorConvert.AutoSize = true;
            this.lblValorConvert.Location = new System.Drawing.Point(12, 99);
            this.lblValorConvert.Name = "lblValorConvert";
            this.lblValorConvert.Size = new System.Drawing.Size(181, 25);
            this.lblValorConvert.TabIndex = 1;
            this.lblValorConvert.Text = "Valor a converter:";
            // 
            // lblConvertido
            // 
            this.lblConvertido.AutoSize = true;
            this.lblConvertido.Location = new System.Drawing.Point(12, 240);
            this.lblConvertido.Name = "lblConvertido";
            this.lblConvertido.Size = new System.Drawing.Size(174, 25);
            this.lblConvertido.TabIndex = 2;
            this.lblConvertido.Text = "Valor convertido:";
            // 
            // combocf
            // 
            this.combocf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combocf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocf.FormattingEnabled = true;
            this.combocf.Items.AddRange(new object[] {
            "Celsius  -> Fahrenheit",
            "Fahrenheit -> Celsius"});
            this.combocf.Location = new System.Drawing.Point(17, 161);
            this.combocf.Name = "combocf";
            this.combocf.Size = new System.Drawing.Size(169, 26);
            this.combocf.TabIndex = 3;
            this.combocf.SelectedIndexChanged += new System.EventHandler(this.combocf_SelectedIndexChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(277, 161);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(141, 41);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(250, 96);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(194, 32);
            this.TxtValor.TabIndex = 5;
            this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // TxtFinal
            // 
            this.TxtFinal.AutoSize = true;
            this.TxtFinal.Location = new System.Drawing.Point(257, 240);
            this.TxtFinal.Name = "TxtFinal";
            this.TxtFinal.Size = new System.Drawing.Size(0, 25);
            this.TxtFinal.TabIndex = 7;
            // 
            // frmConvertTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 311);
            this.Controls.Add(this.TxtFinal);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.combocf);
            this.Controls.Add(this.lblConvertido);
            this.Controls.Add(this.lblValorConvert);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConvertTemp";
            this.Text = "Conversor de Temperatura";
            this.Load += new System.EventHandler(this.frmConvertTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblValorConvert;
        private System.Windows.Forms.Label lblConvertido;
        private System.Windows.Forms.ComboBox combocf;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label TxtFinal;
    }
}

