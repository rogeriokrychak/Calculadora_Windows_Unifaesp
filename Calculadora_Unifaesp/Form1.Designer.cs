
namespace Calculadora_Unifaesp
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.visor = new System.Windows.Forms.TextBox();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultipl = new System.Windows.Forms.Button();
            this.btnSubtr = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(62, 367);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 72);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(143, 367);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 72);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(224, 367);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 72);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(305, 445);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 72);
            this.btnResultado.TabIndex = 3;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(62, 289);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 72);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(143, 289);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 72);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(224, 289);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 72);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(305, 133);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 72);
            this.btnDivisao.TabIndex = 7;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(62, 211);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 72);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(143, 211);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 72);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // visor
            // 
            this.visor.Enabled = false;
            this.visor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visor.Location = new System.Drawing.Point(62, 78);
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(318, 49);
            this.visor.TabIndex = 10;
            this.visor.Text = "0";
            this.visor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(224, 211);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 72);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnMultipl
            // 
            this.btnMultipl.Location = new System.Drawing.Point(305, 211);
            this.btnMultipl.Name = "btnMultipl";
            this.btnMultipl.Size = new System.Drawing.Size(75, 72);
            this.btnMultipl.TabIndex = 12;
            this.btnMultipl.Text = "*";
            this.btnMultipl.UseVisualStyleBackColor = true;
            this.btnMultipl.Click += new System.EventHandler(this.btnMultipl_Click);
            // 
            // btnSubtr
            // 
            this.btnSubtr.Location = new System.Drawing.Point(305, 289);
            this.btnSubtr.Name = "btnSubtr";
            this.btnSubtr.Size = new System.Drawing.Size(75, 72);
            this.btnSubtr.TabIndex = 13;
            this.btnSubtr.Text = "-";
            this.btnSubtr.UseVisualStyleBackColor = true;
            this.btnSubtr.Click += new System.EventHandler(this.btnSubtr_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(305, 367);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 72);
            this.btnSoma.TabIndex = 14;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(224, 445);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 72);
            this.button15.TabIndex = 15;
            this.button15.Text = ",";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(62, 445);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 72);
            this.button16.TabIndex = 16;
            this.button16.Text = "+-";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(143, 445);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 72);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(224, 133);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 72);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 529);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnSubtr);
            this.Controls.Add(this.btnMultipl);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.visor);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.TextBox visor;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultipl;
        private System.Windows.Forms.Button btnSubtr;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
    }
}

