namespace Convertor
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
            this.Hexadecimal_txtBox_Input = new System.Windows.Forms.TextBox();
            this.ASCII_txtBox_Input = new System.Windows.Forms.TextBox();
            this.IterHex_txtBox_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ConvertTo_ASCII = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ConvertTo_Hex = new System.Windows.Forms.Button();
            this.btn_ConvertTo_IterHex = new System.Windows.Forms.Button();
            this.numericUpDown_Iterations_Hex = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iterations_Hex)).BeginInit();
            this.SuspendLayout();
            // 
            // Hexadecimal_txtBox_Input
            // 
            this.Hexadecimal_txtBox_Input.Location = new System.Drawing.Point(140, 81);
            this.Hexadecimal_txtBox_Input.Name = "Hexadecimal_txtBox_Input";
            this.Hexadecimal_txtBox_Input.Size = new System.Drawing.Size(214, 20);
            this.Hexadecimal_txtBox_Input.TabIndex = 4;
            // 
            // ASCII_txtBox_Input
            // 
            this.ASCII_txtBox_Input.Location = new System.Drawing.Point(140, 30);
            this.ASCII_txtBox_Input.Name = "ASCII_txtBox_Input";
            this.ASCII_txtBox_Input.Size = new System.Drawing.Size(214, 20);
            this.ASCII_txtBox_Input.TabIndex = 5;
            // 
            // IterHex_txtBox_Input
            // 
            this.IterHex_txtBox_Input.Location = new System.Drawing.Point(140, 141);
            this.IterHex_txtBox_Input.Multiline = true;
            this.IterHex_txtBox_Input.Name = "IterHex_txtBox_Input";
            this.IterHex_txtBox_Input.Size = new System.Drawing.Size(214, 49);
            this.IterHex_txtBox_Input.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ASCII:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hexadecimal:";
            // 
            // btn_ConvertTo_ASCII
            // 
            this.btn_ConvertTo_ASCII.AccessibleName = "";
            this.btn_ConvertTo_ASCII.Location = new System.Drawing.Point(31, 28);
            this.btn_ConvertTo_ASCII.Name = "btn_ConvertTo_ASCII";
            this.btn_ConvertTo_ASCII.Size = new System.Drawing.Size(103, 23);
            this.btn_ConvertTo_ASCII.TabIndex = 9;
            this.btn_ConvertTo_ASCII.Text = "convert to ASCII";
            this.btn_ConvertTo_ASCII.UseVisualStyleBackColor = true;
            this.btn_ConvertTo_ASCII.Click += new System.EventHandler(this.btn_ConvertTo_ASCII_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Iterated Hexadecimal";
            // 
            // btn_ConvertTo_Hex
            // 
            this.btn_ConvertTo_Hex.AccessibleName = "";
            this.btn_ConvertTo_Hex.Location = new System.Drawing.Point(31, 74);
            this.btn_ConvertTo_Hex.Name = "btn_ConvertTo_Hex";
            this.btn_ConvertTo_Hex.Size = new System.Drawing.Size(103, 27);
            this.btn_ConvertTo_Hex.TabIndex = 11;
            this.btn_ConvertTo_Hex.Text = "convert to Hex";
            this.btn_ConvertTo_Hex.UseVisualStyleBackColor = true;
            this.btn_ConvertTo_Hex.Click += new System.EventHandler(this.btn_ConvertTo_Hex_Click);
            // 
            // btn_ConvertTo_IterHex
            // 
            this.btn_ConvertTo_IterHex.AccessibleName = "";
            this.btn_ConvertTo_IterHex.Location = new System.Drawing.Point(31, 144);
            this.btn_ConvertTo_IterHex.Name = "btn_ConvertTo_IterHex";
            this.btn_ConvertTo_IterHex.Size = new System.Drawing.Size(103, 25);
            this.btn_ConvertTo_IterHex.TabIndex = 12;
            this.btn_ConvertTo_IterHex.Text = "convert to Hex";
            this.btn_ConvertTo_IterHex.UseVisualStyleBackColor = true;
            this.btn_ConvertTo_IterHex.Click += new System.EventHandler(this.btn_ConvertTo_IteratedHex_Click);
            // 
            // numericUpDown_Iterations_Hex
            // 
            this.numericUpDown_Iterations_Hex.Location = new System.Drawing.Point(106, 170);
            this.numericUpDown_Iterations_Hex.Name = "numericUpDown_Iterations_Hex";
            this.numericUpDown_Iterations_Hex.Size = new System.Drawing.Size(28, 20);
            this.numericUpDown_Iterations_Hex.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Iterations:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 205);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_Iterations_Hex);
            this.Controls.Add(this.btn_ConvertTo_IterHex);
            this.Controls.Add(this.btn_ConvertTo_Hex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ConvertTo_ASCII);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IterHex_txtBox_Input);
            this.Controls.Add(this.ASCII_txtBox_Input);
            this.Controls.Add(this.Hexadecimal_txtBox_Input);
            this.Name = "Form1";
            this.Text = "Converter VTG TE17 William martens";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iterations_Hex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hexadecimal_txtBox_Input;
        private System.Windows.Forms.TextBox ASCII_txtBox_Input;
        private System.Windows.Forms.TextBox IterHex_txtBox_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ConvertTo_ASCII;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ConvertTo_Hex;
        private System.Windows.Forms.Button btn_ConvertTo_IterHex;
        private System.Windows.Forms.NumericUpDown numericUpDown_Iterations_Hex;
        private System.Windows.Forms.Label label4;
    }
}

