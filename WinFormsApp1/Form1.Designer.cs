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
            lblInsert = new Label();
            lblDelete = new Label();
            txtData = new TextBox();
            txtPosition = new TextBox();
            lblData = new Label();
            lblPosition = new Label();
            lvDisplay = new ListView();
            SuspendLayout();
            // 
            // btnInsertStart
            // 
            btnInsertStart.Location = new Point(168, 39);
            btnInsertStart.Name = "btnInsertStart";
            btnInsertStart.Size = new Size(94, 29);
            btnInsertStart.TabIndex = 0;
            btnInsertStart.Text = "Start";
            btnInsertStart.UseVisualStyleBackColor = true;
            btnInsertStart.Click += btnInsertStart_Click;
            // 
            // btnInsertMiddle
            // 
            btnInsertMiddle.Location = new Point(168, 88);
            btnInsertMiddle.Name = "btnInsertMiddle";
            btnInsertMiddle.Size = new Size(94, 29);
            btnInsertMiddle.TabIndex = 1;
            btnInsertMiddle.Text = "Middle";
            btnInsertMiddle.UseVisualStyleBackColor = true;
            btnInsertMiddle.Click += btnInsertMiddle_Click;
            // 
            // btnInsertEnd
            // 
            btnInsertEnd.Location = new Point(168, 138);
            btnInsertEnd.Name = "btnInsertEnd";
            btnInsertEnd.Size = new Size(94, 29);
            btnInsertEnd.TabIndex = 2;
            btnInsertEnd.Text = "End";
            btnInsertEnd.UseVisualStyleBackColor = true;
            btnInsertEnd.Click += btnInsertEnd_Click;
            // 
            // btnDeleteStart
            // 
            btnDeleteStart.Location = new Point(316, 39);
            btnDeleteStart.Name = "btnDeleteStart";
            btnDeleteStart.Size = new Size(94, 29);
            btnDeleteStart.TabIndex = 3;
            btnDeleteStart.Text = "Start";
            btnDeleteStart.UseVisualStyleBackColor = true;
            btnDeleteStart.Click += btnDeleteStart_Click;
            // 
            // btnDeleteMiddle
            // 
            btnDeleteMiddle.Location = new Point(316, 88);
            btnDeleteMiddle.Name = "btnDeleteMiddle";
            btnDeleteMiddle.Size = new Size(94, 29);
            btnDeleteMiddle.TabIndex = 4;
            btnDeleteMiddle.Text = "Middle";
            btnDeleteMiddle.UseVisualStyleBackColor = true;
            btnDeleteMiddle.Click += btnDeleteMiddle_Click;
            // 
            // btnDeleteEnd
            // 
            btnDeleteEnd.Location = new Point(316, 138);
            btnDeleteEnd.Name = "btnDeleteEnd";
            btnDeleteEnd.Size = new Size(94, 29);
            btnDeleteEnd.TabIndex = 5;
            btnDeleteEnd.Text = "End";
            btnDeleteEnd.UseVisualStyleBackColor = true;
            btnDeleteEnd.Click += btnDeleteEnd_Click;
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Location = new Point(187, 13);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(45, 20);
            lblInsert.TabIndex = 6;
            lblInsert.Text = "Insert";
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Location = new Point(340, 13);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(53, 20);
            lblDelete.TabIndex = 7;
            lblDelete.Text = "Delete";
            // 
            // txtData
            // 
            txtData.Location = new Point(12, 41);
            txtData.Name = "txtData";
            txtData.Size = new Size(125, 27);
            txtData.TabIndex = 8;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(12, 113);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(125, 27);
            txtPosition.TabIndex = 9;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(12, 15);
            lblData.Name = "lblData";
            lblData.Size = new Size(41, 20);
            lblData.TabIndex = 10;
            lblData.Text = "Data";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(12, 90);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(61, 20);
            lblPosition.TabIndex = 11;
            lblPosition.Text = "Position";
            // 
            // lvDisplay
            // 
            lvDisplay.Location = new Point(12, 191);
            lvDisplay.Name = "lvDisplay";
            lvDisplay.Size = new Size(398, 121);
            lvDisplay.TabIndex = 12;
            lvDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 348);
            Controls.Add(lvDisplay);
            Controls.Add(lblPosition);
            Controls.Add(lblData);
            Controls.Add(txtPosition);
            Controls.Add(txtData);
            Controls.Add(lblDelete);
            Controls.Add(lblInsert);
            Controls.Add(btnDeleteEnd);
            Controls.Add(btnDeleteMiddle);
            Controls.Add(btnDeleteStart);
            Controls.Add(btnInsertEnd);
            Controls.Add(btnInsertMiddle);
            Controls.Add(btnInsertStart);
            Name = "Form1";
            Text = "Form1";
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
        private Label lblInsert;
        private Label lblDelete;
        private TextBox txtData;
        private TextBox txtPosition;
        private Label lblData;
        private Label lblPosition;
        private ListView lvDisplay;
    }
}
