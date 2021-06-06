
namespace Email
{
    partial class Email
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
            this.toBox = new System.Windows.Forms.TextBox();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.bodyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toBox
            // 
            this.toBox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.toBox.Location = new System.Drawing.Point(113, 46);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(262, 22);
            this.toBox.TabIndex = 0;
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(113, 90);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(265, 22);
            this.fromBox.TabIndex = 1;
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(113, 141);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(392, 22);
            this.subjectBox.TabIndex = 2;
            // 
            // bodyBox
            // 
            this.bodyBox.Location = new System.Drawing.Point(113, 216);
            this.bodyBox.Multiline = true;
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.bodyBox.Size = new System.Drawing.Size(391, 241);
            this.bodyBox.TabIndex = 3;
            this.bodyBox.TextChanged += new System.EventHandler(this.bodyBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Body";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(589, 46);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(203, 62);
            this.Send.TabIndex = 8;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 562);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.toBox);
            this.Name = "Email";
            this.Text = "Email Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.TextBox bodyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Send;
    }
}

