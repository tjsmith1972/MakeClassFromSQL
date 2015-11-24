namespace MakeClassFromSQL
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmdGenerateClass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.chkQuickProperties = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(682, 20);
            this.textBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox1, "Enter a valid SQL Connection String");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 32);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(682, 149);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 250);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(682, 322);
            this.textBox3.TabIndex = 2;
            // 
            // cmdGenerateClass
            // 
            this.cmdGenerateClass.Location = new System.Drawing.Point(566, 186);
            this.cmdGenerateClass.Margin = new System.Windows.Forms.Padding(2);
            this.cmdGenerateClass.Name = "cmdGenerateClass";
            this.cmdGenerateClass.Size = new System.Drawing.Size(124, 21);
            this.cmdGenerateClass.TabIndex = 3;
            this.cmdGenerateClass.Text = "Generate Class";
            this.cmdGenerateClass.UseVisualStyleBackColor = true;
            this.cmdGenerateClass.Click += new System.EventHandler(this.cmdGenerateClass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVB);
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Location = new System.Drawing.Point(9, 186);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(96, 41);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // rbVB
            // 
            this.rbVB.AutoSize = true;
            this.rbVB.Location = new System.Drawing.Point(54, 17);
            this.rbVB.Margin = new System.Windows.Forms.Padding(2);
            this.rbVB.Name = "rbVB";
            this.rbVB.Size = new System.Drawing.Size(39, 17);
            this.rbVB.TabIndex = 1;
            this.rbVB.Text = "VB";
            this.rbVB.UseVisualStyleBackColor = true;
            this.rbVB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Checked = true;
            this.rbC.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbC.Location = new System.Drawing.Point(15, 17);
            this.rbC.Margin = new System.Windows.Forms.Padding(2);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(39, 17);
            this.rbC.TabIndex = 0;
            this.rbC.TabStop = true;
            this.rbC.Text = "C#";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // chkQuickProperties
            // 
            this.chkQuickProperties.AutoSize = true;
            this.chkQuickProperties.Location = new System.Drawing.Point(118, 203);
            this.chkQuickProperties.Margin = new System.Windows.Forms.Padding(2);
            this.chkQuickProperties.Name = "chkQuickProperties";
            this.chkQuickProperties.Size = new System.Drawing.Size(126, 17);
            this.chkQuickProperties.TabIndex = 5;
            this.chkQuickProperties.Text = "Use Quick Properties";
            this.chkQuickProperties.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Copy Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkQuickProperties);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdGenerateClass);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Make Class From SQL Query";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cmdGenerateClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.CheckBox chkQuickProperties;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

