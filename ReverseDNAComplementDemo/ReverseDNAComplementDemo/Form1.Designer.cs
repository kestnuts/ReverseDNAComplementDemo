namespace ReverseDNAComplementDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dnaStringTextbox = new System.Windows.Forms.TextBox();
            this.reversedDNATextBox = new System.Windows.Forms.TextBox();
            this.reverseComplementTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userDNATextbox = new System.Windows.Forms.TextBox();
            this.stringLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stringLengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "RUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNA String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNA String - Reversed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reverse Complement";
            // 
            // dnaStringTextbox
            // 
            this.dnaStringTextbox.Location = new System.Drawing.Point(182, 43);
            this.dnaStringTextbox.Multiline = true;
            this.dnaStringTextbox.Name = "dnaStringTextbox";
            this.dnaStringTextbox.ReadOnly = true;
            this.dnaStringTextbox.Size = new System.Drawing.Size(125, 65);
            this.dnaStringTextbox.TabIndex = 4;
            // 
            // reversedDNATextBox
            // 
            this.reversedDNATextBox.Location = new System.Drawing.Point(182, 121);
            this.reversedDNATextBox.Multiline = true;
            this.reversedDNATextBox.Name = "reversedDNATextBox";
            this.reversedDNATextBox.ReadOnly = true;
            this.reversedDNATextBox.Size = new System.Drawing.Size(125, 65);
            this.reversedDNATextBox.TabIndex = 5;
            // 
            // reverseComplementTextBox
            // 
            this.reverseComplementTextBox.Location = new System.Drawing.Point(182, 198);
            this.reverseComplementTextBox.Multiline = true;
            this.reverseComplementTextBox.Name = "reverseComplementTextBox";
            this.reverseComplementTextBox.ReadOnly = true;
            this.reverseComplementTextBox.Size = new System.Drawing.Size(125, 65);
            this.reverseComplementTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Write Your Own Dna String \r\n(Min 8 characters)";
            // 
            // userDNATextbox
            // 
            this.userDNATextbox.Location = new System.Drawing.Point(573, 46);
            this.userDNATextbox.Multiline = true;
            this.userDNATextbox.Name = "userDNATextbox";
            this.userDNATextbox.Size = new System.Drawing.Size(125, 65);
            this.userDNATextbox.TabIndex = 8;
            this.userDNATextbox.TextChanged += new System.EventHandler(this.userDNATextbox_TextChanged);
            // 
            // stringLengthUpDown
            // 
            this.stringLengthUpDown.Location = new System.Drawing.Point(573, 163);
            this.stringLengthUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.stringLengthUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.stringLengthUpDown.Name = "stringLengthUpDown";
            this.stringLengthUpDown.Size = new System.Drawing.Size(120, 22);
            this.stringLengthUpDown.TabIndex = 9;
            this.stringLengthUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "String Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stringLengthUpDown);
            this.Controls.Add(this.userDNATextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reverseComplementTextBox);
            this.Controls.Add(this.reversedDNATextBox);
            this.Controls.Add(this.dnaStringTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stringLengthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dnaStringTextbox;
        private System.Windows.Forms.TextBox reversedDNATextBox;
        private System.Windows.Forms.TextBox reverseComplementTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userDNATextbox;
        private System.Windows.Forms.NumericUpDown stringLengthUpDown;
        private System.Windows.Forms.Label label5;
    }
}

