namespace MLonen_WF
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
            this.lbWorkers = new System.Windows.Forms.ListBox();
            this.btLoonBrief = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWorkers
            // 
            this.lbWorkers.FormattingEnabled = true;
            this.lbWorkers.ItemHeight = 16;
            this.lbWorkers.Location = new System.Drawing.Point(72, 38);
            this.lbWorkers.Name = "lbWorkers";
            this.lbWorkers.Size = new System.Drawing.Size(120, 84);
            this.lbWorkers.TabIndex = 0;
            this.lbWorkers.SelectedIndexChanged += new System.EventHandler(this.lbWorkers_SelectedIndexChanged);
            // 
            // btLoonBrief
            // 
            this.btLoonBrief.Location = new System.Drawing.Point(335, 69);
            this.btLoonBrief.Name = "btLoonBrief";
            this.btLoonBrief.Size = new System.Drawing.Size(75, 23);
            this.btLoonBrief.TabIndex = 1;
            this.btLoonBrief.Text = "Print";
            this.btLoonBrief.UseVisualStyleBackColor = true;
            this.btLoonBrief.Click += new System.EventHandler(this.btLoonBrief_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLoonBrief);
            this.Controls.Add(this.lbWorkers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbWorkers;
        private System.Windows.Forms.Button btLoonBrief;
    }
}

