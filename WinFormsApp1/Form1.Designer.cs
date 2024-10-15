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
            txtData = new TextBox();
            lblData = new Label();
            lvDisplay = new ListView();
            btnAgg = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // txtData
            // 
            txtData.Location = new Point(283, 79);
            txtData.Name = "txtData";
            txtData.Size = new Size(125, 27);
            txtData.TabIndex = 8;
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
            // lvDisplay
            // 
            lvDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvDisplay.Location = new Point(12, 16);
            lvDisplay.Name = "lvDisplay";
            lvDisplay.Size = new Size(220, 213);
            lvDisplay.TabIndex = 12;
            lvDisplay.UseCompatibleStateImageBehavior = false;
            lvDisplay.View = View.Details;
            lvDisplay.Columns.Add("Posición", 100);
            lvDisplay.Columns.Add("Dato", 100);
            // 
            // btnAgg
            // 
            btnAgg.Location = new Point(283, 123);
            btnAgg.Name = "btnAgg";
            btnAgg.Size = new Size(94, 29);
            btnAgg.TabIndex = 13;
            btnAgg.Text = "Agg";
            btnAgg.UseVisualStyleBackColor = true;
            btnAgg.Click += btnAgg_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(283, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(283, 193);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 264);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAgg);
            Controls.Add(lvDisplay);
            Controls.Add(lblData);
            Controls.Add(txtData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtData;
        private Label lblData;
        private ListView lvDisplay;
        private Button btnAgg;
        private Button btnDelete;
        private Button btnSearch;
    }
}
