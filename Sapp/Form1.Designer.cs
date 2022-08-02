
namespace Sapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dbListView = new System.Windows.Forms.ListView();
            this.remoteListView = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbListView
            // 
            this.dbListView.HideSelection = false;
            this.dbListView.Location = new System.Drawing.Point(12, 12);
            this.dbListView.Name = "dbListView";
            this.dbListView.Size = new System.Drawing.Size(173, 202);
            this.dbListView.TabIndex = 1;
            this.dbListView.UseCompatibleStateImageBehavior = false;
            this.dbListView.View = System.Windows.Forms.View.List;
            // 
            // remoteListView
            // 
            this.remoteListView.HideSelection = false;
            this.remoteListView.Location = new System.Drawing.Point(615, 12);
            this.remoteListView.Name = "remoteListView";
            this.remoteListView.Size = new System.Drawing.Size(173, 202);
            this.remoteListView.TabIndex = 2;
            this.remoteListView.UseCompatibleStateImageBehavior = false;
            this.remoteListView.View = System.Windows.Forms.View.List;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.remoteListView);
            this.Controls.Add(this.dbListView);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView dbListView;
        private System.Windows.Forms.ListView remoteListView;
        private System.Windows.Forms.Button button2;
    }
}

