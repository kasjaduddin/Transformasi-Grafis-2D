namespace GraphicsTransformationApp
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.inptScaleX = new System.Windows.Forms.TextBox();
            this.inptScaleY = new System.Windows.Forms.TextBox();
            this.enterScale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scale terhadap sumbu-x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scale terhadap sumbu-y";
            // 
            // inptScaleX
            // 
            this.inptScaleX.Location = new System.Drawing.Point(43, 64);
            this.inptScaleX.Name = "inptScaleX";
            this.inptScaleX.Size = new System.Drawing.Size(100, 26);
            this.inptScaleX.TabIndex = 3;
            // 
            // inptScaleY
            // 
            this.inptScaleY.Location = new System.Drawing.Point(43, 138);
            this.inptScaleY.Name = "inptScaleY";
            this.inptScaleY.Size = new System.Drawing.Size(100, 26);
            this.inptScaleY.TabIndex = 4;
            // 
            // enterScale
            // 
            this.enterScale.Location = new System.Drawing.Point(353, 181);
            this.enterScale.Name = "enterScale";
            this.enterScale.Size = new System.Drawing.Size(75, 34);
            this.enterScale.TabIndex = 5;
            this.enterScale.Text = "Submit";
            this.enterScale.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.enterScale);
            this.Controls.Add(this.inptScaleY);
            this.Controls.Add(this.inptScaleX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Scale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inptScaleX;
        private System.Windows.Forms.TextBox inptScaleY;
        private System.Windows.Forms.Button enterScale;
    }
}