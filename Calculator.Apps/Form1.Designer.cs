namespace Calculator.Apps
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnkurang = new System.Windows.Forms.Button();
            this.btnbagi = new System.Windows.Forms.Button();
            this.btnhasil = new System.Windows.Forms.Button();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.btnkali = new System.Windows.Forms.Button();
            this.btnkoma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 3);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(503, 51);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 72);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 52);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(96, 72);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(78, 52);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(180, 72);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(78, 52);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 130);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(78, 52);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(96, 130);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 52);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(180, 130);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(78, 52);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 188);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(78, 52);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(96, 188);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(78, 52);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(180, 188);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(78, 52);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(264, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(251, 52);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(264, 130);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(251, 52);
            this.button11.TabIndex = 11;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(12, 246);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(78, 52);
            this.btntambah.TabIndex = 12;
            this.btntambah.Text = "+";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnkurang
            // 
            this.btnkurang.Location = new System.Drawing.Point(96, 246);
            this.btnkurang.Name = "btnkurang";
            this.btnkurang.Size = new System.Drawing.Size(78, 52);
            this.btnkurang.TabIndex = 13;
            this.btnkurang.Text = "-";
            this.btnkurang.UseVisualStyleBackColor = true;
            this.btnkurang.Click += new System.EventHandler(this.btnkurang_Click);
            // 
            // btnbagi
            // 
            this.btnbagi.Location = new System.Drawing.Point(180, 246);
            this.btnbagi.Name = "btnbagi";
            this.btnbagi.Size = new System.Drawing.Size(78, 52);
            this.btnbagi.TabIndex = 14;
            this.btnbagi.Text = ":";
            this.btnbagi.UseVisualStyleBackColor = true;
            this.btnbagi.Click += new System.EventHandler(this.btnbagi_Click);
            // 
            // btnhasil
            // 
            this.btnhasil.Location = new System.Drawing.Point(348, 188);
            this.btnhasil.Name = "btnhasil";
            this.btnhasil.Size = new System.Drawing.Size(167, 110);
            this.btnhasil.TabIndex = 15;
            this.btnhasil.Text = "=";
            this.btnhasil.UseVisualStyleBackColor = true;
            this.btnhasil.Click += new System.EventHandler(this.btnhasil_Click);
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay2.Location = new System.Drawing.Point(22, 12);
            this.txtDisplay2.Multiline = true;
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(32, 31);
            this.txtDisplay2.TabIndex = 16;
            // 
            // btnkali
            // 
            this.btnkali.Location = new System.Drawing.Point(264, 188);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(78, 52);
            this.btnkali.TabIndex = 17;
            this.btnkali.Text = "x";
            this.btnkali.UseVisualStyleBackColor = true;
            this.btnkali.Click += new System.EventHandler(this.btnkali_Click);
            // 
            // btnkoma
            // 
            this.btnkoma.Location = new System.Drawing.Point(264, 246);
            this.btnkoma.Name = "btnkoma";
            this.btnkoma.Size = new System.Drawing.Size(78, 52);
            this.btnkoma.TabIndex = 18;
            this.btnkoma.Text = ",";
            this.btnkoma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 465);
            this.Controls.Add(this.btnkoma);
            this.Controls.Add(this.btnkali);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.btnhasil);
            this.Controls.Add(this.btnbagi);
            this.Controls.Add(this.btnkurang);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnkurang;
        private System.Windows.Forms.Button btnbagi;
        private System.Windows.Forms.Button btnhasil;
        private System.Windows.Forms.TextBox txtDisplay2;
        private System.Windows.Forms.Button btnkali;
        private System.Windows.Forms.Button btnkoma;
    }
}

