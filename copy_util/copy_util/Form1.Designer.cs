namespace copy_util
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
            this.FileName = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.TextBox();
            this.label_File = new System.Windows.Forms.Label();
            this.label_path = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(12, 60);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(268, 20);
            this.FileName.TabIndex = 0;
            this.FileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(355, 60);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(297, 20);
            this.Path.TabIndex = 1;
            this.Path.TextChanged += new System.EventHandler(this.Path_TextChanged);
            // 
            // label_File
            // 
            this.label_File.AutoSize = true;
            this.label_File.Location = new System.Drawing.Point(12, 44);
            this.label_File.Name = "label_File";
            this.label_File.Size = new System.Drawing.Size(36, 13);
            this.label_File.TabIndex = 2;
            this.label_File.Text = "Файл";
            this.label_File.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Location = new System.Drawing.Point(352, 44);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(31, 13);
            this.label_path.TabIndex = 3;
            this.label_path.Text = "Путь";
            this.label_path.Click += new System.EventHandler(this.label_path_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(577, 238);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(12, 86);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(91, 23);
            this.button_copy.TabIndex = 5;
            this.button_copy.Text = "Скопировать";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 273);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.label_File);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.FileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Label label_File;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_copy;
    }
}

