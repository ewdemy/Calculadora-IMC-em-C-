namespace Calculadora_IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.BoxPeso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxAltura = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pbBaixoPeso = new System.Windows.Forms.PictureBox();
            this.pbNormal = new System.Windows.Forms.PictureBox();
            this.pbSobrepeso = new System.Windows.Forms.PictureBox();
            this.pbObesidade = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaixoPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSobrepeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObesidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Green;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(21, 212);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(232, 34);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(21, 244);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 34);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // BoxPeso
            // 
            this.BoxPeso.AccessibleDescription = "";
            this.BoxPeso.AccessibleName = "";
            this.BoxPeso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPeso.ForeColor = System.Drawing.Color.Gray;
            this.BoxPeso.FormattingEnabled = true;
            this.BoxPeso.Items.AddRange(new object[] {
            "10 ",
            "11 ",
            "12 ",
            "13 ",
            "14 ",
            "15 ",
            "16 ",
            "17 ",
            "18 ",
            "19 ",
            "20 ",
            "21 ",
            "22 ",
            "23 ",
            "24 ",
            "25 ",
            "26 ",
            "27 ",
            "28 ",
            "29 ",
            "30 ",
            "31 ",
            "32 ",
            "33 ",
            "34 ",
            "35 ",
            "36 ",
            "37 ",
            "38 ",
            "39 ",
            "40 ",
            "41 ",
            "42 ",
            "43 ",
            "44 ",
            "45 ",
            "46 ",
            "47 ",
            "48 ",
            "49 ",
            "50 ",
            "51 ",
            "52 ",
            "53 ",
            "54 ",
            "55 ",
            "56 ",
            "57 ",
            "58 ",
            "59 ",
            "60 ",
            "61 ",
            "62 ",
            "63 ",
            "64 ",
            "65 ",
            "66 ",
            "67 ",
            "68 ",
            "69 ",
            "70 ",
            "71 ",
            "72 ",
            "73 ",
            "74 ",
            "75 ",
            "76 ",
            "77 ",
            "78 ",
            "79 ",
            "80 ",
            "81 ",
            "82 ",
            "83 ",
            "84 ",
            "85 ",
            "86 ",
            "87 ",
            "88 ",
            "89 ",
            "90 ",
            "91 ",
            "92 ",
            "93 ",
            "94 ",
            "95 ",
            "96 ",
            "97 ",
            "98 ",
            "99 ",
            "100 ",
            "101 ",
            "102 ",
            "103 ",
            "104 ",
            "105 ",
            "106 ",
            "107 ",
            "108 ",
            "109 ",
            "110 ",
            "111 ",
            "112 ",
            "113 ",
            "114 ",
            "115 ",
            "116 ",
            "117 ",
            "118 ",
            "119 ",
            "120 ",
            "121 ",
            "122 ",
            "123 ",
            "124 ",
            "125 ",
            "126 ",
            "127 ",
            "128 ",
            "129 ",
            "130 ",
            "131 ",
            "132 ",
            "133 ",
            "134 ",
            "135 ",
            "136 ",
            "137 ",
            "138 ",
            "139 ",
            "140 ",
            "141 ",
            "142 ",
            "143 ",
            "144 ",
            "145 ",
            "146 ",
            "147 ",
            "148 ",
            "149 ",
            "150 "});
            this.BoxPeso.Location = new System.Drawing.Point(21, 90);
            this.BoxPeso.Name = "BoxPeso";
            this.BoxPeso.Size = new System.Drawing.Size(190, 20);
            this.BoxPeso.TabIndex = 5;
            this.BoxPeso.Text = "Selecione seu Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cm";
            // 
            // BoxAltura
            // 
            this.BoxAltura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAltura.ForeColor = System.Drawing.Color.Gray;
            this.BoxAltura.FormattingEnabled = true;
            this.BoxAltura.Items.AddRange(new object[] {
            "50 ",
            "51 ",
            "52 ",
            "53 ",
            "54 ",
            "55 ",
            "56 ",
            "57 ",
            "58 ",
            "59 ",
            "60 ",
            "61 ",
            "62 ",
            "63 ",
            "64 ",
            "65 ",
            "66 ",
            "67 ",
            "68 ",
            "69 ",
            "70 ",
            "71 ",
            "72 ",
            "73 ",
            "74 ",
            "75 ",
            "76 ",
            "77 ",
            "78 ",
            "79 ",
            "80 ",
            "81 ",
            "82 ",
            "83 ",
            "84 ",
            "85 ",
            "86 ",
            "87 ",
            "88 ",
            "89 ",
            "90 ",
            "91 ",
            "92 ",
            "93 ",
            "94 ",
            "95 ",
            "96 ",
            "97 ",
            "98 ",
            "99 ",
            "100 ",
            "101 ",
            "102 ",
            "103 ",
            "104 ",
            "105 ",
            "106 ",
            "107 ",
            "108 ",
            "109 ",
            "110 ",
            "111 ",
            "112 ",
            "113 ",
            "114 ",
            "115 ",
            "116 ",
            "117 ",
            "118 ",
            "119 ",
            "120 ",
            "121 ",
            "122 ",
            "123 ",
            "124 ",
            "125 ",
            "126 ",
            "127 ",
            "128 ",
            "129 ",
            "130 ",
            "131 ",
            "132 ",
            "133 ",
            "134 ",
            "135 ",
            "136 ",
            "137 ",
            "138 ",
            "139 ",
            "140 ",
            "141 ",
            "142 ",
            "143 ",
            "144 ",
            "145 ",
            "146 ",
            "147 ",
            "148 ",
            "149 ",
            "150 ",
            "151 ",
            "152 ",
            "153 ",
            "154 ",
            "155 ",
            "156 ",
            "157 ",
            "158 ",
            "159 ",
            "160 ",
            "161 ",
            "162 ",
            "163 ",
            "164 ",
            "165 ",
            "166 ",
            "167 ",
            "168 ",
            "169 ",
            "170 ",
            "171 ",
            "172 ",
            "173 ",
            "174 ",
            "175 ",
            "176 ",
            "177 ",
            "178 ",
            "179 ",
            "180 ",
            "181 ",
            "182 ",
            "183 ",
            "184 ",
            "185 ",
            "186 ",
            "187 ",
            "188 ",
            "189 ",
            "190 ",
            "191 ",
            "192 ",
            "193 ",
            "194 ",
            "195 ",
            "196 ",
            "197 ",
            "198 ",
            "199 ",
            "200",
            "201 ",
            "202 ",
            "203 ",
            "204 ",
            "205 ",
            "206 ",
            "207 ",
            "208 ",
            "209 ",
            "210 ",
            "211 ",
            "212 ",
            "213 ",
            "214 ",
            "215 ",
            "216 ",
            "217 ",
            "218 ",
            "219 ",
            "220 ",
            "221 ",
            "222 ",
            "223 ",
            "224 ",
            "225 ",
            "226 ",
            "227 ",
            "228 ",
            "229 ",
            "230 "});
            this.BoxAltura.Location = new System.Drawing.Point(21, 137);
            this.BoxAltura.Name = "BoxAltura";
            this.BoxAltura.Size = new System.Drawing.Size(186, 20);
            this.BoxAltura.TabIndex = 8;
            this.BoxAltura.Text = "Selecione sua Altura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "IMC:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(138, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.Color.Red;
            this.lbResultado.Location = new System.Drawing.Point(64, 158);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 24);
            this.lbResultado.TabIndex = 13;
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Black;
            this.lbResult.Location = new System.Drawing.Point(94, 183);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 22);
            this.lbResult.TabIndex = 14;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResult.Click += new System.EventHandler(this.lbResult_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "STATUS:";
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(276, 22);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(156, 250);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 16;
            this.pb1.TabStop = false;
            // 
            // pbBaixoPeso
            // 
            this.pbBaixoPeso.Image = ((System.Drawing.Image)(resources.GetObject("pbBaixoPeso.Image")));
            this.pbBaixoPeso.Location = new System.Drawing.Point(312, 22);
            this.pbBaixoPeso.Name = "pbBaixoPeso";
            this.pbBaixoPeso.Size = new System.Drawing.Size(93, 250);
            this.pbBaixoPeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBaixoPeso.TabIndex = 17;
            this.pbBaixoPeso.TabStop = false;
            this.pbBaixoPeso.Visible = false;
            // 
            // pbNormal
            // 
            this.pbNormal.Image = ((System.Drawing.Image)(resources.GetObject("pbNormal.Image")));
            this.pbNormal.Location = new System.Drawing.Point(276, 22);
            this.pbNormal.Name = "pbNormal";
            this.pbNormal.Size = new System.Drawing.Size(139, 250);
            this.pbNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNormal.TabIndex = 18;
            this.pbNormal.TabStop = false;
            this.pbNormal.Visible = false;
            // 
            // pbSobrepeso
            // 
            this.pbSobrepeso.Image = ((System.Drawing.Image)(resources.GetObject("pbSobrepeso.Image")));
            this.pbSobrepeso.Location = new System.Drawing.Point(276, 22);
            this.pbSobrepeso.Name = "pbSobrepeso";
            this.pbSobrepeso.Size = new System.Drawing.Size(156, 250);
            this.pbSobrepeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSobrepeso.TabIndex = 19;
            this.pbSobrepeso.TabStop = false;
            this.pbSobrepeso.Visible = false;
            // 
            // pbObesidade
            // 
            this.pbObesidade.Image = ((System.Drawing.Image)(resources.GetObject("pbObesidade.Image")));
            this.pbObesidade.Location = new System.Drawing.Point(259, 23);
            this.pbObesidade.Name = "pbObesidade";
            this.pbObesidade.Size = new System.Drawing.Size(181, 250);
            this.pbObesidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbObesidade.TabIndex = 20;
            this.pbObesidade.TabStop = false;
            this.pbObesidade.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 285);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BoxAltura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxPeso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pbObesidade);
            this.Controls.Add(this.pbSobrepeso);
            this.Controls.Add(this.pbBaixoPeso);
            this.Controls.Add(this.pbNormal);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaixoPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSobrepeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObesidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox BoxPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BoxAltura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pbBaixoPeso;
        private System.Windows.Forms.PictureBox pbNormal;
        private System.Windows.Forms.PictureBox pbSobrepeso;
        private System.Windows.Forms.PictureBox pbObesidade;
    }
}

