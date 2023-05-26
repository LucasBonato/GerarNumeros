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
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipos de números";
            // 
            // txtBoxQuantidade
            // 
            this.txtBoxQuantidade.Location = new System.Drawing.Point(304, 71);
            this.txtBoxQuantidade.Name = "txtBoxQuantidade";
            this.txtBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQuantidade.TabIndex = 2;
            // 
            // txtBoxMultiOf
            // 
            this.txtBoxMultiOf.Location = new System.Drawing.Point(452, 71);
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
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(131, 369);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 80);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            this.txtBoxPartirNum.Location = new System.Drawing.Point(603, 71);
            this.txtBoxPartirNum.Name = "txtBoxPartirNum";
            this.txtBoxPartirNum.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPartirNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Multiplo De";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "A partir do número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxRadio);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtBoxMultiOf);
            this.Controls.Add(this.txtBoxPartirNum);
            this.Controls.Add(this.txtBoxQuantidade);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

