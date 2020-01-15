namespace Marionettes
{
    partial class MainForm
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
            this.completeTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.completeTaskResultInput = new System.Windows.Forms.NumericUpDown();
            this.completeTaskLabel = new System.Windows.Forms.Label();
            this.completeTaskFaultButton = new System.Windows.Forms.Button();
            this.completeTaskButton = new System.Windows.Forms.Button();
            this.consumeTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.consumeTaskLabel = new System.Windows.Forms.Label();
            this.consumeTaskButton = new System.Windows.Forms.Button();
            this.completeTaskGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.completeTaskResultInput)).BeginInit();
            this.consumeTaskGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // completeTaskGroupBox
            // 
            this.completeTaskGroupBox.Controls.Add(this.completeTaskResultInput);
            this.completeTaskGroupBox.Controls.Add(this.completeTaskLabel);
            this.completeTaskGroupBox.Controls.Add(this.completeTaskFaultButton);
            this.completeTaskGroupBox.Controls.Add(this.completeTaskButton);
            this.completeTaskGroupBox.Location = new System.Drawing.Point(12, 12);
            this.completeTaskGroupBox.Name = "completeTaskGroupBox";
            this.completeTaskGroupBox.Size = new System.Drawing.Size(297, 417);
            this.completeTaskGroupBox.TabIndex = 0;
            this.completeTaskGroupBox.TabStop = false;
            this.completeTaskGroupBox.Text = "Complete Task";
            // 
            // completeTaskResultInput
            // 
            this.completeTaskResultInput.Enabled = false;
            this.completeTaskResultInput.Location = new System.Drawing.Point(6, 359);
            this.completeTaskResultInput.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.completeTaskResultInput.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.completeTaskResultInput.Name = "completeTaskResultInput";
            this.completeTaskResultInput.Size = new System.Drawing.Size(285, 23);
            this.completeTaskResultInput.TabIndex = 3;
            this.completeTaskResultInput.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            // 
            // completeTaskLabel
            // 
            this.completeTaskLabel.Location = new System.Drawing.Point(6, 19);
            this.completeTaskLabel.Name = "completeTaskLabel";
            this.completeTaskLabel.Size = new System.Drawing.Size(285, 337);
            this.completeTaskLabel.TabIndex = 2;
            this.completeTaskLabel.Text = "No task has been initiated yet.";
            // 
            // completeTaskFaultButton
            // 
            this.completeTaskFaultButton.Enabled = false;
            this.completeTaskFaultButton.Location = new System.Drawing.Point(216, 388);
            this.completeTaskFaultButton.Name = "completeTaskFaultButton";
            this.completeTaskFaultButton.Size = new System.Drawing.Size(75, 23);
            this.completeTaskFaultButton.TabIndex = 1;
            this.completeTaskFaultButton.Text = "Fault";
            this.completeTaskFaultButton.UseVisualStyleBackColor = true;
            this.completeTaskFaultButton.Click += new System.EventHandler(this.completeTaskFaultButton_Click);
            // 
            // completeTaskButton
            // 
            this.completeTaskButton.Enabled = false;
            this.completeTaskButton.Location = new System.Drawing.Point(6, 388);
            this.completeTaskButton.Name = "completeTaskButton";
            this.completeTaskButton.Size = new System.Drawing.Size(204, 23);
            this.completeTaskButton.TabIndex = 0;
            this.completeTaskButton.Text = "Complete Task";
            this.completeTaskButton.UseVisualStyleBackColor = true;
            this.completeTaskButton.Click += new System.EventHandler(this.completeTaskButton_Click);
            // 
            // consumeTaskGroupBox
            // 
            this.consumeTaskGroupBox.Controls.Add(this.consumeTaskLabel);
            this.consumeTaskGroupBox.Controls.Add(this.consumeTaskButton);
            this.consumeTaskGroupBox.Location = new System.Drawing.Point(315, 12);
            this.consumeTaskGroupBox.Name = "consumeTaskGroupBox";
            this.consumeTaskGroupBox.Size = new System.Drawing.Size(297, 417);
            this.consumeTaskGroupBox.TabIndex = 1;
            this.consumeTaskGroupBox.TabStop = false;
            this.consumeTaskGroupBox.Text = "Consume Task";
            // 
            // consumeTaskLabel
            // 
            this.consumeTaskLabel.Location = new System.Drawing.Point(6, 19);
            this.consumeTaskLabel.Name = "consumeTaskLabel";
            this.consumeTaskLabel.Size = new System.Drawing.Size(285, 366);
            this.consumeTaskLabel.TabIndex = 2;
            this.consumeTaskLabel.Text = "You have never initiated any task.";
            // 
            // consumeTaskButton
            // 
            this.consumeTaskButton.Location = new System.Drawing.Point(6, 388);
            this.consumeTaskButton.Name = "consumeTaskButton";
            this.consumeTaskButton.Size = new System.Drawing.Size(285, 23);
            this.consumeTaskButton.TabIndex = 0;
            this.consumeTaskButton.Text = "Initiate Task";
            this.consumeTaskButton.UseVisualStyleBackColor = true;
            this.consumeTaskButton.Click += new System.EventHandler(this.consumeTaskButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.consumeTaskGroupBox);
            this.Controls.Add(this.completeTaskGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Marionettes";
            this.completeTaskGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.completeTaskResultInput)).EndInit();
            this.consumeTaskGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox completeTaskGroupBox;
        private System.Windows.Forms.Label completeTaskLabel;
        private System.Windows.Forms.Button completeTaskFaultButton;
        private System.Windows.Forms.Button completeTaskButton;
        private System.Windows.Forms.GroupBox consumeTaskGroupBox;
        private System.Windows.Forms.Label consumeTaskLabel;
        private System.Windows.Forms.Button consumeTaskButton;
        private System.Windows.Forms.NumericUpDown completeTaskResultInput;
    }
}

