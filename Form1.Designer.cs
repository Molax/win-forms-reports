﻿namespace Relatorios
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
            this.btnRelSetor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRelSetor
            // 
            this.btnRelSetor.Location = new System.Drawing.Point(128, 60);
            this.btnRelSetor.Name = "btnRelSetor";
            this.btnRelSetor.Size = new System.Drawing.Size(75, 23);
            this.btnRelSetor.TabIndex = 0;
            this.btnRelSetor.Text = "button1";
            this.btnRelSetor.UseVisualStyleBackColor = true;
            this.btnRelSetor.Click += new System.EventHandler(this.btnRelSetor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 339);
            this.Controls.Add(this.btnRelSetor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelSetor;
    }
}

