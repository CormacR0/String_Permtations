namespace String_Permtations
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
            this.TitleTxt = new System.Windows.Forms.Label();
            this.X_Textbx = new System.Windows.Forms.TextBox();
            this.Y_Textbx = new System.Windows.Forms.TextBox();
            this.String_X_Lbl = new System.Windows.Forms.Label();
            this.String_Y_Lbl = new System.Windows.Forms.Label();
            this.Cal_But = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleTxt
            // 
            this.TitleTxt.AutoSize = true;
            this.TitleTxt.BackColor = System.Drawing.Color.Tomato;
            this.TitleTxt.Location = new System.Drawing.Point(366, 61);
            this.TitleTxt.MaximumSize = new System.Drawing.Size(100, 100);
            this.TitleTxt.MinimumSize = new System.Drawing.Size(100, 100);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(100, 100);
            this.TitleTxt.TabIndex = 1;
            this.TitleTxt.Text = "String comparer";
            // 
            // X_Textbx
            // 
            this.X_Textbx.Location = new System.Drawing.Point(347, 180);
            this.X_Textbx.Name = "X_Textbx";
            this.X_Textbx.Size = new System.Drawing.Size(100, 20);
            this.X_Textbx.TabIndex = 2;
            this.X_Textbx.TextChanged += new System.EventHandler(this.X_Textbx_TextChanged);
            // 
            // Y_Textbx
            // 
            this.Y_Textbx.Location = new System.Drawing.Point(347, 249);
            this.Y_Textbx.Name = "Y_Textbx";
            this.Y_Textbx.Size = new System.Drawing.Size(100, 20);
            this.Y_Textbx.TabIndex = 3;
            this.Y_Textbx.TextChanged += new System.EventHandler(this.Y_Textbx_TextChanged);
            // 
            // String_X_Lbl
            // 
            this.String_X_Lbl.AutoSize = true;
            this.String_X_Lbl.Location = new System.Drawing.Point(273, 183);
            this.String_X_Lbl.Name = "String_X_Lbl";
            this.String_X_Lbl.Size = new System.Drawing.Size(44, 13);
            this.String_X_Lbl.TabIndex = 4;
            this.String_X_Lbl.Text = "String X";
            // 
            // String_Y_Lbl
            // 
            this.String_Y_Lbl.AutoSize = true;
            this.String_Y_Lbl.Location = new System.Drawing.Point(273, 249);
            this.String_Y_Lbl.Name = "String_Y_Lbl";
            this.String_Y_Lbl.Size = new System.Drawing.Size(44, 13);
            this.String_Y_Lbl.TabIndex = 5;
            this.String_Y_Lbl.Text = "String Y";
            // 
            // Cal_But
            // 
            this.Cal_But.Location = new System.Drawing.Point(350, 315);
            this.Cal_But.Name = "Cal_But";
            this.Cal_But.Size = new System.Drawing.Size(75, 23);
            this.Cal_But.TabIndex = 6;
            this.Cal_But.Text = "Calculate";
            this.Cal_But.UseVisualStyleBackColor = true;
            this.Cal_But.Click += new System.EventHandler(this.Cal_But_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cal_But);
            this.Controls.Add(this.String_Y_Lbl);
            this.Controls.Add(this.String_X_Lbl);
            this.Controls.Add(this.Y_Textbx);
            this.Controls.Add(this.X_Textbx);
            this.Controls.Add(this.TitleTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleTxt;
        private System.Windows.Forms.TextBox X_Textbx;
        private System.Windows.Forms.TextBox Y_Textbx;
        private System.Windows.Forms.Label String_X_Lbl;
        private System.Windows.Forms.Label String_Y_Lbl;
        private System.Windows.Forms.Button Cal_But;
    }
}

