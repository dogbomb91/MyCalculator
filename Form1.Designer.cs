namespace MyCalculator
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
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttonmultiply = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.buttondivide = new System.Windows.Forms.Button();
            this.buttonclearentry = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.buttonequal = new System.Windows.Forms.Button();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttondot = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.preview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonminus
            // 
            this.buttonminus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonminus.Location = new System.Drawing.Point(165, 181);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(45, 45);
            this.buttonminus.TabIndex = 0;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.OperationClick);
            // 
            // buttonmultiply
            // 
            this.buttonmultiply.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmultiply.Location = new System.Drawing.Point(165, 130);
            this.buttonmultiply.Name = "buttonmultiply";
            this.buttonmultiply.Size = new System.Drawing.Size(45, 45);
            this.buttonmultiply.TabIndex = 1;
            this.buttonmultiply.Text = "*";
            this.buttonmultiply.UseVisualStyleBackColor = true;
            this.buttonmultiply.Click += new System.EventHandler(this.OperationClick);
            // 
            // number9
            // 
            this.number9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number9.Location = new System.Drawing.Point(114, 79);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(45, 45);
            this.number9.TabIndex = 2;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttondivide
            // 
            this.buttondivide.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondivide.Location = new System.Drawing.Point(165, 79);
            this.buttondivide.Name = "buttondivide";
            this.buttondivide.Size = new System.Drawing.Size(45, 45);
            this.buttondivide.TabIndex = 3;
            this.buttondivide.Text = "/";
            this.buttondivide.UseVisualStyleBackColor = true;
            this.buttondivide.Click += new System.EventHandler(this.OperationClick);
            // 
            // buttonclearentry
            // 
            this.buttonclearentry.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclearentry.Location = new System.Drawing.Point(216, 79);
            this.buttonclearentry.Name = "buttonclearentry";
            this.buttonclearentry.Size = new System.Drawing.Size(54, 45);
            this.buttonclearentry.TabIndex = 4;
            this.buttonclearentry.Text = "CE";
            this.buttonclearentry.UseVisualStyleBackColor = true;
            this.buttonclearentry.Click += new System.EventHandler(this.ButtonclearEntryClick);
            // 
            // buttonclear
            // 
            this.buttonclear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.Location = new System.Drawing.Point(216, 130);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(54, 45);
            this.buttonclear.TabIndex = 9;
            this.buttonclear.Text = "C";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // number8
            // 
            this.number8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number8.Location = new System.Drawing.Point(63, 79);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(45, 45);
            this.number8.TabIndex = 8;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // number6
            // 
            this.number6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number6.Location = new System.Drawing.Point(114, 130);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(45, 45);
            this.number6.TabIndex = 6;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // number5
            // 
            this.number5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5.Location = new System.Drawing.Point(63, 130);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(45, 45);
            this.number5.TabIndex = 5;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // number4
            // 
            this.number4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4.Location = new System.Drawing.Point(12, 130);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(45, 45);
            this.number4.TabIndex = 13;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3.Location = new System.Drawing.Point(114, 181);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(45, 45);
            this.number3.TabIndex = 12;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2.Location = new System.Drawing.Point(63, 181);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(45, 45);
            this.number2.TabIndex = 11;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(12, 181);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(45, 45);
            this.button14.TabIndex = 10;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonequal
            // 
            this.buttonequal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonequal.Location = new System.Drawing.Point(216, 181);
            this.buttonequal.Name = "buttonequal";
            this.buttonequal.Size = new System.Drawing.Size(54, 96);
            this.buttonequal.TabIndex = 19;
            this.buttonequal.Text = "=";
            this.buttonequal.UseVisualStyleBackColor = true;
            this.buttonequal.Click += new System.EventHandler(this.ButtonEqualClick);
            // 
            // buttonplus
            // 
            this.buttonplus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonplus.Location = new System.Drawing.Point(165, 232);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(45, 45);
            this.buttonplus.TabIndex = 18;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.OperationClick);
            // 
            // buttondot
            // 
            this.buttondot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondot.Location = new System.Drawing.Point(114, 232);
            this.buttondot.Name = "buttondot";
            this.buttondot.Size = new System.Drawing.Size(45, 45);
            this.buttondot.TabIndex = 17;
            this.buttondot.Text = ".";
            this.buttondot.UseVisualStyleBackColor = true;
            this.buttondot.Click += new System.EventHandler(this.ButtonClick);
            // 
            // number0
            // 
            this.number0.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number0.Location = new System.Drawing.Point(12, 232);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(96, 45);
            this.number0.TabIndex = 15;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 31);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // preview
            // 
            this.preview.AutoSize = true;
            this.preview.BackColor = System.Drawing.SystemColors.Control;
            this.preview.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.preview.Location = new System.Drawing.Point(12, 14);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(20, 23);
            this.preview.TabIndex = 21;
            this.preview.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 303);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonequal);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.buttondot);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.buttonclearentry);
            this.Controls.Add(this.buttondivide);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.buttonmultiply);
            this.Controls.Add(this.buttonminus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Awesome Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttonmultiply;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button buttondivide;
        private System.Windows.Forms.Button buttonclearentry;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button buttonequal;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttondot;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label preview;
    }
}

