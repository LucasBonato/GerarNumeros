namespace GerarNumero
{
    partial class Form1
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
            this.comBoxChoise = new System.Windows.Forms.ComboBox();
            this.lblTypeNum = new System.Windows.Forms.Label();
            this.txtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.txtBoxMultiOf = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.radioBtnTen = new System.Windows.Forms.RadioButton();
            this.radioBtnFive = new System.Windows.Forms.RadioButton();
            this.radioBtnOne = new System.Windows.Forms.RadioButton();
            this.txtBoxPartirNum = new System.Windows.Forms.TextBox();
            this.lblQntd = new System.Windows.Forms.Label();
            this.lblMultiOf = new System.Windows.Forms.Label();
            this.lblAPartir = new System.Windows.Forms.Label();
            this.groupBoxRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // comBoxChoise
            // 
            this.comBoxChoise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxChoise.FormattingEnabled = true;
            this.comBoxChoise.Items.AddRange(new object[] {
            "Números Pares",
            "Números ímpares",
            "Números Multiplos",
            "Lista anterior"});
            this.comBoxChoise.Location = new System.Drawing.Point(131, 71);
            this.comBoxChoise.Name = "comBoxChoise";
            this.comBoxChoise.Size = new System.Drawing.Size(120, 21);
            this.comBoxChoise.TabIndex = 0;
            // 
            // lblTypeNum
            // 
            this.lblTypeNum.AutoSize = true;
            this.lblTypeNum.Location = new System.Drawing.Point(144, 55);
            this.lblTypeNum.Name = "lblTypeNum";
            this.lblTypeNum.Size = new System.Drawing.Size(91, 13);
            this.lblTypeNum.TabIndex = 1;
            this.lblTypeNum.Text = "Tipos de números";
            // 
            // txtBoxQuantidade
            // 
            this.txtBoxQuantidade.Location = new System.Drawing.Point(322, 72);
            this.txtBoxQuantidade.Name = "txtBoxQuantidade";
            this.txtBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQuantidade.TabIndex = 2;
            // 
            // txtBoxMultiOf
            // 
            this.txtBoxMultiOf.Location = new System.Drawing.Point(703, 72);
            this.txtBoxMultiOf.Name = "txtBoxMultiOf";
            this.txtBoxMultiOf.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMultiOf.TabIndex = 4;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(648, 130);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(200, 80);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(131, 216);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(717, 147);
            this.listBox.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(648, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 80);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(131, 369);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 80);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.Controls.Add(this.radioBtnTen);
            this.groupBoxRadio.Controls.Add(this.radioBtnFive);
            this.groupBoxRadio.Controls.Add(this.radioBtnOne);
            this.groupBoxRadio.Location = new System.Drawing.Point(131, 162);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(200, 48);
            this.groupBoxRadio.TabIndex = 9;
            this.groupBoxRadio.TabStop = false;
            this.groupBoxRadio.Text = "Qntd. por linha";
            // 
            // radioBtnTen
            // 
            this.radioBtnTen.AutoSize = true;
            this.radioBtnTen.Checked = true;
            this.radioBtnTen.Location = new System.Drawing.Point(148, 19);
            this.radioBtnTen.Name = "radioBtnTen";
            this.radioBtnTen.Size = new System.Drawing.Size(37, 17);
            this.radioBtnTen.TabIndex = 2;
            this.radioBtnTen.TabStop = true;
            this.radioBtnTen.Text = "10";
            this.radioBtnTen.UseVisualStyleBackColor = true;
            // 
            // radioBtnFive
            // 
            this.radioBtnFive.AutoSize = true;
            this.radioBtnFive.Location = new System.Drawing.Point(80, 19);
            this.radioBtnFive.Name = "radioBtnFive";
            this.radioBtnFive.Size = new System.Drawing.Size(31, 17);
            this.radioBtnFive.TabIndex = 1;
            this.radioBtnFive.Text = "5";
            this.radioBtnFive.UseVisualStyleBackColor = true;
            // 
            // radioBtnOne
            // 
            this.radioBtnOne.AutoSize = true;
            this.radioBtnOne.Location = new System.Drawing.Point(6, 19);
            this.radioBtnOne.Name = "radioBtnOne";
            this.radioBtnOne.Size = new System.Drawing.Size(31, 17);
            this.radioBtnOne.TabIndex = 0;
            this.radioBtnOne.Text = "1";
            this.radioBtnOne.UseVisualStyleBackColor = true;
            // 
            // txtBoxPartirNum
            // 
            this.txtBoxPartirNum.Location = new System.Drawing.Point(509, 72);
            this.txtBoxPartirNum.Name = "txtBoxPartirNum";
            this.txtBoxPartirNum.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPartirNum.TabIndex = 3;
            // 
            // lblQntd
            // 
            this.lblQntd.AutoSize = true;
            this.lblQntd.Location = new System.Drawing.Point(344, 56);
            this.lblQntd.Name = "lblQntd";
            this.lblQntd.Size = new System.Drawing.Size(62, 13);
            this.lblQntd.TabIndex = 10;
            this.lblQntd.Text = "Quantidade";
            // 
            // lblMultiOf
            // 
            this.lblMultiOf.AutoSize = true;
            this.lblMultiOf.Location = new System.Drawing.Point(727, 56);
            this.lblMultiOf.Name = "lblMultiOf";
            this.lblMultiOf.Size = new System.Drawing.Size(60, 13);
            this.lblMultiOf.TabIndex = 11;
            this.lblMultiOf.Text = "Multiplo De";
            // 
            // lblAPartir
            // 
            this.lblAPartir.AutoSize = true;
            this.lblAPartir.Location = new System.Drawing.Point(513, 56);
            this.lblAPartir.Name = "lblAPartir";
            this.lblAPartir.Size = new System.Drawing.Size(93, 13);
            this.lblAPartir.TabIndex = 12;
            this.lblAPartir.Text = "A partir do número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.lblAPartir);
            this.Controls.Add(this.lblMultiOf);
            this.Controls.Add(this.lblQntd);
            this.Controls.Add(this.groupBoxRadio);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtBoxMultiOf);
            this.Controls.Add(this.txtBoxPartirNum);
            this.Controls.Add(this.txtBoxQuantidade);
            this.Controls.Add(this.lblTypeNum);
            this.Controls.Add(this.comBoxChoise);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Números";
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxChoise;
        private System.Windows.Forms.Label lblTypeNum;
        private System.Windows.Forms.TextBox txtBoxQuantidade;
        private System.Windows.Forms.TextBox txtBoxMultiOf;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.RadioButton radioBtnTen;
        private System.Windows.Forms.RadioButton radioBtnFive;
        private System.Windows.Forms.RadioButton radioBtnOne;
        private System.Windows.Forms.TextBox txtBoxPartirNum;
        private System.Windows.Forms.Label lblQntd;
        private System.Windows.Forms.Label lblMultiOf;
        private System.Windows.Forms.Label lblAPartir;
    }
}

