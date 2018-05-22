namespace Clipping_and_Filling
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawPol = new System.Windows.Forms.Button();
            this.p2line = new System.Windows.Forms.Label();
            this.p1line = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drawRec = new System.Windows.Forms.Button();
            this.p2label = new System.Windows.Forms.Label();
            this.p1label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lineButton = new System.Windows.Forms.Button();
            this.recButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.fillRB = new System.Windows.Forms.RadioButton();
            this.clipRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 538);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.drawPol);
            this.panel1.Controls.Add(this.p2line);
            this.panel1.Controls.Add(this.p1line);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.drawRec);
            this.panel1.Controls.Add(this.p2label);
            this.panel1.Controls.Add(this.p1label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lineButton);
            this.panel1.Controls.Add(this.recButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Controls.Add(this.fillRB);
            this.panel1.Controls.Add(this.clipRB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(810, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 534);
            this.panel1.TabIndex = 0;
            // 
            // drawPol
            // 
            this.drawPol.Location = new System.Drawing.Point(35, 336);
            this.drawPol.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.drawPol.Name = "drawPol";
            this.drawPol.Size = new System.Drawing.Size(75, 23);
            this.drawPol.TabIndex = 16;
            this.drawPol.Text = "Draw";
            this.drawPol.UseVisualStyleBackColor = true;
            this.drawPol.Click += new System.EventHandler(this.drawPol_Click);
            // 
            // p2line
            // 
            this.p2line.AutoSize = true;
            this.p2line.Location = new System.Drawing.Point(66, 246);
            this.p2line.Name = "p2line";
            this.p2line.Size = new System.Drawing.Size(0, 13);
            this.p2line.TabIndex = 15;
            // 
            // p1line
            // 
            this.p1line.AutoSize = true;
            this.p1line.Location = new System.Drawing.Point(66, 230);
            this.p1line.Name = "p1line";
            this.p1line.Size = new System.Drawing.Size(0, 13);
            this.p1line.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Point 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Point 1:";
            // 
            // drawRec
            // 
            this.drawRec.Location = new System.Drawing.Point(35, 160);
            this.drawRec.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.drawRec.Name = "drawRec";
            this.drawRec.Size = new System.Drawing.Size(75, 23);
            this.drawRec.TabIndex = 11;
            this.drawRec.Text = "Draw";
            this.drawRec.UseVisualStyleBackColor = true;
            this.drawRec.Click += new System.EventHandler(this.drawRec_Click);
            // 
            // p2label
            // 
            this.p2label.AutoSize = true;
            this.p2label.Location = new System.Drawing.Point(66, 139);
            this.p2label.Name = "p2label";
            this.p2label.Size = new System.Drawing.Size(0, 13);
            this.p2label.TabIndex = 10;
            // 
            // p1label
            // 
            this.p1label.AutoSize = true;
            this.p1label.Location = new System.Drawing.Point(66, 123);
            this.p1label.Name = "p1label";
            this.p1label.Size = new System.Drawing.Size(0, 13);
            this.p1label.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Point 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Point 1:";
            // 
            // lineButton
            // 
            this.lineButton.BackColor = System.Drawing.Color.Transparent;
            this.lineButton.Location = new System.Drawing.Point(10, 197);
            this.lineButton.Margin = new System.Windows.Forms.Padding(10);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(128, 23);
            this.lineButton.TabIndex = 6;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = false;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // recButton
            // 
            this.recButton.BackColor = System.Drawing.Color.Transparent;
            this.recButton.Location = new System.Drawing.Point(10, 90);
            this.recButton.Margin = new System.Windows.Forms.Padding(10);
            this.recButton.Name = "recButton";
            this.recButton.Size = new System.Drawing.Size(128, 23);
            this.recButton.TabIndex = 5;
            this.recButton.Text = "Rectangle";
            this.recButton.UseVisualStyleBackColor = false;
            this.recButton.Click += new System.EventHandler(this.recButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(10, 484);
            this.clearButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(128, 40);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(10, 434);
            this.applyButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(128, 40);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // fillRB
            // 
            this.fillRB.AutoSize = true;
            this.fillRB.Location = new System.Drawing.Point(20, 306);
            this.fillRB.Name = "fillRB";
            this.fillRB.Size = new System.Drawing.Size(51, 17);
            this.fillRB.TabIndex = 2;
            this.fillRB.TabStop = true;
            this.fillRB.Text = "Filling";
            this.fillRB.UseVisualStyleBackColor = true;
            this.fillRB.CheckedChanged += new System.EventHandler(this.fillRB_CheckedChanged);
            // 
            // clipRB
            // 
            this.clipRB.AutoSize = true;
            this.clipRB.Location = new System.Drawing.Point(20, 60);
            this.clipRB.Name = "clipRB";
            this.clipRB.Size = new System.Drawing.Size(62, 17);
            this.clipRB.TabIndex = 1;
            this.clipRB.TabStop = true;
            this.clipRB.Text = "Clipping";
            this.clipRB.UseVisualStyleBackColor = true;
            this.clipRB.CheckedChanged += new System.EventHandler(this.clipRB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 534);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 387);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "floodfill";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clipping and Filling";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.RadioButton fillRB;
        private System.Windows.Forms.RadioButton clipRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label p2label;
        private System.Windows.Forms.Label p1label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button recButton;
        private System.Windows.Forms.Label p2line;
        private System.Windows.Forms.Label p1line;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button drawRec;
        private System.Windows.Forms.Button drawPol;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

