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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.PictureBox();
            this.InstructionStream = new System.Windows.Forms.ListView();
            this.RegistersState = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Step";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.Desktop;
            this.Display.Location = new System.Drawing.Point(45, 39);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(520, 312);
            this.Display.TabIndex = 3;
            this.Display.TabStop = false;
            // 
            // InstructionStream
            // 
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EmulatorWindow";
            this.Text = "PDP 11 Emulator";
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox Display;
        private System.Windows.Forms.ListView InstructionStream;
        private System.Windows.Forms.ListView RegistersState;
    }
}

