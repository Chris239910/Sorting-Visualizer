namespace DataSctructures_SortingAlgorithms
{
    partial class SortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_RunTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Time
            // 
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Image = ((System.Drawing.Image)(resources.GetObject("label_Time.Image")));
            this.label_Time.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Time.Location = new System.Drawing.Point(391, 20);
            this.label_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(109, 94);
            this.label_Time.TabIndex = 3;
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_RunTime
            // 
            this.label_RunTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RunTime.ForeColor = System.Drawing.Color.DarkRed;
            this.label_RunTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_RunTime.Location = new System.Drawing.Point(508, 20);
            this.label_RunTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RunTime.Name = "label_RunTime";
            this.label_RunTime.Size = new System.Drawing.Size(399, 94);
            this.label_RunTime.TabIndex = 5;
            this.label_RunTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 906);
            this.Controls.Add(this.label_RunTime);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SortForm";
            this.Text = "Sorting Algorithms";
            this.Load += new System.EventHandler(this.SortForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SortForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_RunTime;
    }
}

