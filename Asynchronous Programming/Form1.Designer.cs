namespace Asynchronous_Programming
{
    partial class Menu
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
            this.SyncOption = new System.Windows.Forms.Button();
            this.AsyncOption = new System.Windows.Forms.Button();
            this.ParallelAsyncOption = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SyncOption
            // 
            this.SyncOption.BackColor = System.Drawing.Color.DimGray;
            this.SyncOption.Font = new System.Drawing.Font("Roboto", 16F);
            this.SyncOption.Location = new System.Drawing.Point(67, 67);
            this.SyncOption.Name = "SyncOption";
            this.SyncOption.Size = new System.Drawing.Size(200, 100);
            this.SyncOption.TabIndex = 0;
            this.SyncOption.Text = "Sync";
            this.SyncOption.UseVisualStyleBackColor = false;
            this.SyncOption.Click += new System.EventHandler(this.SyncOption_Click);
            // 
            // AsyncOption
            // 
            this.AsyncOption.BackColor = System.Drawing.Color.DimGray;
            this.AsyncOption.Font = new System.Drawing.Font("Roboto", 16F);
            this.AsyncOption.Location = new System.Drawing.Point(400, 67);
            this.AsyncOption.Name = "AsyncOption";
            this.AsyncOption.Size = new System.Drawing.Size(200, 100);
            this.AsyncOption.TabIndex = 1;
            this.AsyncOption.Text = "Async";
            this.AsyncOption.UseVisualStyleBackColor = false;
            this.AsyncOption.Click += new System.EventHandler(this.AsyncOption_Click);
            // 
            // ParallelAsyncOption
            // 
            this.ParallelAsyncOption.BackColor = System.Drawing.Color.DimGray;
            this.ParallelAsyncOption.Font = new System.Drawing.Font("Roboto", 16F);
            this.ParallelAsyncOption.Location = new System.Drawing.Point(733, 67);
            this.ParallelAsyncOption.Name = "ParallelAsyncOption";
            this.ParallelAsyncOption.Size = new System.Drawing.Size(200, 100);
            this.ParallelAsyncOption.TabIndex = 2;
            this.ParallelAsyncOption.Text = "Parallel Async";
            this.ParallelAsyncOption.UseVisualStyleBackColor = false;
            this.ParallelAsyncOption.Click += new System.EventHandler(this.ParallelAsyncOption_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Roboto", 10F);
            this.Output.Location = new System.Drawing.Point(67, 234);
            this.Output.Name = "Output";
            this.Output.Padding = new System.Windows.Forms.Padding(0, 0, 0, 67);
            this.Output.Size = new System.Drawing.Size(0, 87);
            this.Output.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.ParallelAsyncOption);
            this.Controls.Add(this.AsyncOption);
            this.Controls.Add(this.SyncOption);
            this.Font = new System.Drawing.Font("Roboto", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Menu";
            this.Text = "Asynchronous Programming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SyncOption;
        private System.Windows.Forms.Button AsyncOption;
        private System.Windows.Forms.Button ParallelAsyncOption;
        private System.Windows.Forms.Label Output;
    }
}