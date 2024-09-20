namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInsertStart = new Button();
            btnInsertMiddle = new Button();
            btnInsertEnd = new Button();
            btnDeleteStart = new Button();
            btnDeleteMiddle = new Button();
            btnDeleteEnd = new Button();
            txtData = new TextBox();
            txtPosition = new TextBox();
            lblData = new Label();
            lblPosition = new Label();
            lvDisplay = new ListView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnInsertStart
            // 
            btnInsertStart.Location = new Point(23, 61);
            btnInsertStart.Name = "btnInsertStart";
            btnInsertStart.Size = new Size(120, 43);
            btnInsertStart.TabIndex = 0;
            btnInsertStart.Text = "Start";
            btnInsertStart.UseVisualStyleBackColor = true;
            btnInsertStart.Click += btnInsertStart_Click;
            // 
            // btnInsertMiddle
            // 
            btnInsertMiddle.Location = new Point(23, 110);
            btnInsertMiddle.Name = "btnInsertMiddle";
            btnInsertMiddle.Size = new Size(120, 44);
            btnInsertMiddle.TabIndex = 1;
            btnInsertMiddle.Text = "Middle";
            btnInsertMiddle.UseVisualStyleBackColor = true;
            btnInsertMiddle.Click += btnInsertMiddle_Click;
            // 
            // btnInsertEnd
            // 
            btnInsertEnd.Location = new Point(23, 160);
            btnInsertEnd.Name = "btnInsertEnd";
            btnInsertEnd.Size = new Size(120, 49);
            btnInsertEnd.TabIndex = 2;
            btnInsertEnd.Text = "End";
            btnInsertEnd.UseVisualStyleBackColor = true;
            btnInsertEnd.Click += btnInsertEnd_Click;
            // 
            // btnDeleteStart
            // 
            btnDeleteStart.Location = new Point(22, 61);
            btnDeleteStart.Name = "btnDeleteStart";
            btnDeleteStart.Size = new Size(120, 43);
            btnDeleteStart.TabIndex = 3;
            btnDeleteStart.Text = "Start";
            btnDeleteStart.UseVisualStyleBackColor = true;
            btnDeleteStart.Click += btnDeleteStart_Click;
            // 
            // btnDeleteMiddle
            // 
            btnDeleteMiddle.Location = new Point(22, 110);
            btnDeleteMiddle.Name = "btnDeleteMiddle";
            btnDeleteMiddle.Size = new Size(120, 44);
            btnDeleteMiddle.TabIndex = 4;
            btnDeleteMiddle.Text = "Middle";
            btnDeleteMiddle.UseVisualStyleBackColor = true;
            btnDeleteMiddle.Click += btnDeleteMiddle_Click;
            // 
            // btnDeleteEnd
            // 
            btnDeleteEnd.Location = new Point(22, 160);
            btnDeleteEnd.Name = "btnDeleteEnd";
            btnDeleteEnd.Size = new Size(120, 49);
            btnDeleteEnd.TabIndex = 5;
            btnDeleteEnd.Text = "End";
            btnDeleteEnd.UseVisualStyleBackColor = true;
            btnDeleteEnd.Click += btnDeleteEnd_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(283, 79);
            txtData.Name = "txtData";
            txtData.Size = new Size(125, 27);
            txtData.TabIndex = 8;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(459, 79);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(125, 27);
            txtPosition.TabIndex = 9;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(283, 26);
            lblData.Name = "lblData";
            lblData.Size = new Size(79, 38);
            lblData.TabIndex = 10;
            lblData.Text = "Data";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblPosition.Location = new Point(459, 26);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(123, 38);
            lblPosition.TabIndex = 11;
            lblPosition.Text = "Position";
            // 
            // lvDisplay
            // 
            lvDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvDisplay.Location = new Point(12, 16);
            lvDisplay.Name = "lvDisplay";
            lvDisplay.Size = new Size(220, 496);
            lvDisplay.TabIndex = 12;
            lvDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInsertStart);
            groupBox1.Controls.Add(btnInsertMiddle);
            groupBox1.Controls.Add(btnInsertEnd);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            groupBox1.Location = new Point(283, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 254);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDeleteStart);
            groupBox2.Controls.Add(btnDeleteMiddle);
            groupBox2.Controls.Add(btnDeleteEnd);
            groupBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            groupBox2.Location = new Point(480, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 254);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 524);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lvDisplay);
            Controls.Add(lblPosition);
            Controls.Add(lblData);
            Controls.Add(txtPosition);
            Controls.Add(txtData);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertStart;
        private Button btnInsertMiddle;
        private Button btnInsertEnd;
        private Button btnDeleteStart;
        private Button btnDeleteMiddle;
        private Button btnDeleteEnd;
        private TextBox txtData;
        private TextBox txtPosition;
        private Label lblData;
        private Label lblPosition;
        private ListView lvDisplay;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
