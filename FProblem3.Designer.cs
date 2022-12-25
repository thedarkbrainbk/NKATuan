namespace MultiThreadGUI
{
    partial class FProblem3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textEnterN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.laOutput = new System.Windows.Forms.Label();
            this.laInput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.latimeofmulthread = new System.Windows.Forms.Label();
            this.latimeofsingthread = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số lượng phần tử của dãy: ";
            // 
            // textEnterN
            // 
            this.textEnterN.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEnterN.Location = new System.Drawing.Point(293, 13);
            this.textEnterN.Name = "textEnterN";
            this.textEnterN.Size = new System.Drawing.Size(256, 32);
            this.textEnterN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(577, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời gian chạy đơn luồng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian chạy đa luồng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laOutput);
            this.panel1.Controls.Add(this.laInput);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.latimeofmulthread);
            this.panel1.Controls.Add(this.latimeofsingthread);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 367);
            this.panel1.TabIndex = 5;
            // 
            // laOutput
            // 
            this.laOutput.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laOutput.Location = new System.Drawing.Point(73, 154);
            this.laOutput.Name = "laOutput";
            this.laOutput.Size = new System.Drawing.Size(693, 99);
            this.laOutput.TabIndex = 10;
            // 
            // laInput
            // 
            this.laInput.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laInput.Location = new System.Drawing.Point(73, 9);
            this.laInput.Name = "laInput";
            this.laInput.Size = new System.Drawing.Size(693, 122);
            this.laInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input:";
            // 
            // latimeofmulthread
            // 
            this.latimeofmulthread.AutoSize = true;
            this.latimeofmulthread.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latimeofmulthread.Location = new System.Drawing.Point(260, 331);
            this.latimeofmulthread.Name = "latimeofmulthread";
            this.latimeofmulthread.Size = new System.Drawing.Size(34, 23);
            this.latimeofmulthread.TabIndex = 6;
            this.latimeofmulthread.Text = "ms";
            // 
            // latimeofsingthread
            // 
            this.latimeofsingthread.AutoSize = true;
            this.latimeofsingthread.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latimeofsingthread.Location = new System.Drawing.Point(260, 292);
            this.latimeofsingthread.Name = "latimeofsingthread";
            this.latimeofsingthread.Size = new System.Drawing.Size(34, 23);
            this.latimeofsingthread.TabIndex = 5;
            this.latimeofsingthread.Text = "ms";
            // 
            // FProblem3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEnterN);
            this.Controls.Add(this.label1);
            this.Name = "FProblem3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài toán 3: Biến đổi dãy số đã cho thành dãy số chỉ chứa số nguyên tố";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEnterN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label latimeofmulthread;
        private System.Windows.Forms.Label latimeofsingthread;
        private System.Windows.Forms.Label laOutput;
        private System.Windows.Forms.Label laInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}