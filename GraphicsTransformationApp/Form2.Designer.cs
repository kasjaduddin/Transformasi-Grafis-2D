namespace GraphicsTransformationApp
{
    partial class Form2
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
            this.inptTranslationX = new System.Windows.Forms.TextBox();
            this.inptTranslationY = new System.Windows.Forms.TextBox();
            this.enterTranslation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Translasi terhadap sumbu-x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Translasi terhadap sumbu-y";
            // 
            // inptTranslationX
            // 
            this.inptTranslationX.Location = new System.Drawing.Point(43, 64);
            this.inptTranslationX.Name = "inptTranslationX";
            this.inptTranslationX.Size = new System.Drawing.Size(100, 26);
            this.inptTranslationX.TabIndex = 2;
            // 
            // inptTranslationY
            // 
            this.inptTranslationY.Location = new System.Drawing.Point(43, 138);
            this.inptTranslationY.Name = "inptTranslationY";
            this.inptTranslationY.Size = new System.Drawing.Size(100, 26);
            this.inptTranslationY.TabIndex = 3;
            // 
            // enterTranslation
            // 
            this.enterTranslation.Location = new System.Drawing.Point(353, 181);
            this.enterTranslation.Name = "enterTranslation";
            this.enterTranslation.Size = new System.Drawing.Size(75, 34);
            this.enterTranslation.TabIndex = 4;
            this.enterTranslation.Text = "Submit";
            this.enterTranslation.UseVisualStyleBackColor = true;
            this.enterTranslation.Click += new System.EventHandler(this.enterTranslation_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.enterTranslation);
            this.Controls.Add(this.inptTranslationY);
            this.Controls.Add(this.inptTranslationX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Translasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inptTranslationX;
        private System.Windows.Forms.TextBox inptTranslationY;
        private System.Windows.Forms.Button enterTranslation;
    }
}