namespace WindowsFormsApplicationCalc
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtOp = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.lblEq = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(22, 69);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click_1);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(12, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 1;
            // 
            // txtOp
            // 
            this.txtOp.Location = new System.Drawing.Point(146, 12);
            this.txtOp.Name = "txtOp";
            this.txtOp.Size = new System.Drawing.Size(31, 22);
            this.txtOp.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(220, 12);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 3;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(348, 12);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(100, 22);
            this.txtRes.TabIndex = 4;
            // 
            // lblEq
            // 
            this.lblEq.AutoSize = true;
            this.lblEq.Location = new System.Drawing.Point(326, 15);
            this.lblEq.Name = "lblEq";
            this.lblEq.Size = new System.Drawing.Size(16, 17);
            this.lblEq.TabIndex = 5;
            this.lblEq.Text = "=";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(50, 37);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 17);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "a";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(129, 37);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(62, 17);
            this.lblOp.TabIndex = 7;
            this.lblOp.Text = "operator";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(261, 37);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 17);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 107);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblEq);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtOp);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtOp;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label lblEq;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblB;
    }
}

