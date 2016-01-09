namespace PDP_11_GUI
{
    partial class EmulatorWindow
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
            this.runButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.stepButton = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.PictureBox();
            this.InstructionStream = new System.Windows.Forms.ListView();
            this.RegistersState = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(119, 479);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(261, 479);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(408, 479);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 2;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Display
            // 
            this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Display.BackColor = System.Drawing.SystemColors.Desktop;
            this.Display.Location = new System.Drawing.Point(45, 39);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(520, 312);
            this.Display.TabIndex = 3;
            this.Display.TabStop = false;
            // 
            // InstructionStream
            // 
            this.InstructionStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstructionStream.Location = new System.Drawing.Point(617, 39);
            this.InstructionStream.Name = "InstructionStream";
            this.InstructionStream.Size = new System.Drawing.Size(494, 312);
            this.InstructionStream.TabIndex = 4;
            this.InstructionStream.UseCompatibleStateImageBehavior = false;
            // 
            // RegistersState
            // 
            this.RegistersState.Location = new System.Drawing.Point(617, 381);
            this.RegistersState.Name = "RegistersState";
            this.RegistersState.Size = new System.Drawing.Size(494, 212);
            this.RegistersState.TabIndex = 5;
            this.RegistersState.UseCompatibleStateImageBehavior = false;
            // 
            // EmulatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 635);
            this.Controls.Add(this.RegistersState);
            this.Controls.Add(this.InstructionStream);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.runButton);
            this.Name = "EmulatorWindow";
            this.Text = "PDP 11 Emulator";
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.PictureBox Display;
        private System.Windows.Forms.ListView InstructionStream;
        private System.Windows.Forms.ListView RegistersState;
    }
}

