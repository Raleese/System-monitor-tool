namespace SystemMonitor
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
            this.components = new System.ComponentModel.Container();
            this.labelCpu = new System.Windows.Forms.Label();
            this.progressBarCpu = new System.Windows.Forms.ProgressBar();
            this.labelCpuValue = new System.Windows.Forms.Label();
            this.labelMemoryValue = new System.Windows.Forms.Label();
            this.labelMemory = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelCpu.Location = new System.Drawing.Point(12, 9);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(119, 25);
            this.labelCpu.TabIndex = 0;
            this.labelCpu.Text = "CPU usage:";
            // 
            // progressBarCpu
            // 
            this.progressBarCpu.Location = new System.Drawing.Point(196, 9);
            this.progressBarCpu.Name = "progressBarCpu";
            this.progressBarCpu.Size = new System.Drawing.Size(483, 23);
            this.progressBarCpu.TabIndex = 1;
            // 
            // labelCpuValue
            // 
            this.labelCpuValue.AutoSize = true;
            this.labelCpuValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelCpuValue.Location = new System.Drawing.Point(685, 7);
            this.labelCpuValue.Name = "labelCpuValue";
            this.labelCpuValue.Size = new System.Drawing.Size(41, 25);
            this.labelCpuValue.TabIndex = 2;
            this.labelCpuValue.Text = "0%";
            this.labelCpuValue.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelMemoryValue
            // 
            this.labelMemoryValue.AutoSize = true;
            this.labelMemoryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelMemoryValue.Location = new System.Drawing.Point(191, 38);
            this.labelMemoryValue.Name = "labelMemoryValue";
            this.labelMemoryValue.Size = new System.Drawing.Size(58, 25);
            this.labelMemoryValue.TabIndex = 5;
            this.labelMemoryValue.Text = "0 MB";
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelMemory.Location = new System.Drawing.Point(12, 38);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(173, 25);
            this.labelMemory.TabIndex = 3;
            this.labelMemory.Text = "Available memory:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMemoryValue);
            this.Controls.Add(this.labelMemory);
            this.Controls.Add(this.labelCpuValue);
            this.Controls.Add(this.progressBarCpu);
            this.Controls.Add(this.labelCpu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCpu;
        private System.Windows.Forms.ProgressBar progressBarCpu;
        private System.Windows.Forms.Label labelCpuValue;
        private System.Windows.Forms.Label labelMemoryValue;
        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.Timer timer1;
    }
}

