
namespace copy_and_move
{
    partial class Main_display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_display));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Target = new System.Windows.Forms.Button();
            this.Txt_Target = new System.Windows.Forms.TextBox();
            this.Lbl_Target = new System.Windows.Forms.Label();
            this.Lbl_Source = new System.Windows.Forms.Label();
            this.Txt_Source = new System.Windows.Forms.TextBox();
            this.Btn_Source = new System.Windows.Forms.Button();
            this.Clb_Source = new System.Windows.Forms.CheckedListBox();
            this.Lb_Target = new System.Windows.Forms.ListBox();
            this.Btn_Copy = new System.Windows.Forms.Button();
            this.Btn_Move = new System.Windows.Forms.Button();
            this.Btn_Dashboard = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Target, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Target, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_Target, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_Source, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Source, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Source, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Clb_Source, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Lb_Target, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Copy, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Move, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Dashboard, 5, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Target
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Btn_Target, 2);
            this.Btn_Target.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Target.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Target.Image")));
            this.Btn_Target.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Target.Location = new System.Drawing.Point(353, 53);
            this.Btn_Target.Name = "Btn_Target";
            this.Btn_Target.Size = new System.Drawing.Size(94, 44);
            this.Btn_Target.TabIndex = 5;
            this.Btn_Target.Text = "select";
            this.Btn_Target.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Target.UseVisualStyleBackColor = true;
            this.Btn_Target.Click += new System.EventHandler(this.Btn_Target_Click);
            // 
            // Txt_Target
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Txt_Target, 3);
            this.Txt_Target.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Target.Location = new System.Drawing.Point(103, 53);
            this.Txt_Target.Multiline = true;
            this.Txt_Target.Name = "Txt_Target";
            this.Txt_Target.Size = new System.Drawing.Size(244, 44);
            this.Txt_Target.TabIndex = 3;
            // 
            // Lbl_Target
            // 
            this.Lbl_Target.AutoSize = true;
            this.Lbl_Target.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Target.Location = new System.Drawing.Point(3, 50);
            this.Lbl_Target.Name = "Lbl_Target";
            this.Lbl_Target.Padding = new System.Windows.Forms.Padding(1);
            this.Lbl_Target.Size = new System.Drawing.Size(94, 50);
            this.Lbl_Target.TabIndex = 1;
            this.Lbl_Target.Text = "Target path: ";
            this.Lbl_Target.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Source
            // 
            this.Lbl_Source.AutoSize = true;
            this.Lbl_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Source.Location = new System.Drawing.Point(3, 0);
            this.Lbl_Source.Name = "Lbl_Source";
            this.Lbl_Source.Padding = new System.Windows.Forms.Padding(1);
            this.Lbl_Source.Size = new System.Drawing.Size(94, 50);
            this.Lbl_Source.TabIndex = 0;
            this.Lbl_Source.Text = "Source path: ";
            this.Lbl_Source.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Source
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Txt_Source, 3);
            this.Txt_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Source.Location = new System.Drawing.Point(103, 3);
            this.Txt_Source.Multiline = true;
            this.Txt_Source.Name = "Txt_Source";
            this.Txt_Source.Size = new System.Drawing.Size(244, 44);
            this.Txt_Source.TabIndex = 2;
            // 
            // Btn_Source
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Btn_Source, 2);
            this.Btn_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Source.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Source.Image")));
            this.Btn_Source.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Source.Location = new System.Drawing.Point(353, 3);
            this.Btn_Source.Name = "Btn_Source";
            this.Btn_Source.Size = new System.Drawing.Size(94, 44);
            this.Btn_Source.TabIndex = 4;
            this.Btn_Source.Text = "select";
            this.Btn_Source.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Source.UseVisualStyleBackColor = true;
            this.Btn_Source.Click += new System.EventHandler(this.Btn_Source_Click);
            // 
            // Clb_Source
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Clb_Source, 2);
            this.Clb_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clb_Source.FormattingEnabled = true;
            this.Clb_Source.Location = new System.Drawing.Point(3, 133);
            this.Clb_Source.Name = "Clb_Source";
            this.tableLayoutPanel1.SetRowSpan(this.Clb_Source, 2);
            this.Clb_Source.Size = new System.Drawing.Size(194, 294);
            this.Clb_Source.TabIndex = 6;
            // 
            // Lb_Target
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Lb_Target, 3);
            this.Lb_Target.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Target.FormattingEnabled = true;
            this.Lb_Target.ItemHeight = 20;
            this.Lb_Target.Location = new System.Drawing.Point(253, 133);
            this.Lb_Target.Name = "Lb_Target";
            this.tableLayoutPanel1.SetRowSpan(this.Lb_Target, 2);
            this.Lb_Target.Size = new System.Drawing.Size(194, 294);
            this.Lb_Target.TabIndex = 7;
            // 
            // Btn_Copy
            // 
            this.Btn_Copy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Copy.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_Copy.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Copy.Image")));
            this.Btn_Copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Copy.Location = new System.Drawing.Point(103, 453);
            this.Btn_Copy.Name = "Btn_Copy";
            this.Btn_Copy.Size = new System.Drawing.Size(94, 44);
            this.Btn_Copy.TabIndex = 8;
            this.Btn_Copy.Text = "Copy";
            this.Btn_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Copy.UseVisualStyleBackColor = true;
            this.Btn_Copy.Click += new System.EventHandler(this.Btn_Copy_Click);
            // 
            // Btn_Move
            // 
            this.Btn_Move.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Move.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Move.Image")));
            this.Btn_Move.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Move.Location = new System.Drawing.Point(253, 453);
            this.Btn_Move.Name = "Btn_Move";
            this.Btn_Move.Size = new System.Drawing.Size(94, 44);
            this.Btn_Move.TabIndex = 9;
            this.Btn_Move.Text = "move";
            this.Btn_Move.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Move.UseVisualStyleBackColor = true;
            this.Btn_Move.Click += new System.EventHandler(this.Btn_Move_Click);
            // 
            // Btn_Dashboard
            // 
            this.Btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Dashboard.Image = global::copy_and_move.Properties.Resources.dahboard;
            this.Btn_Dashboard.Location = new System.Drawing.Point(403, 453);
            this.Btn_Dashboard.Name = "Btn_Dashboard";
            this.Btn_Dashboard.Padding = new System.Windows.Forms.Padding(15);
            this.Btn_Dashboard.Size = new System.Drawing.Size(44, 44);
            this.Btn_Dashboard.TabIndex = 10;
            this.Btn_Dashboard.Text = "---";
            this.Btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_Dashboard.UseVisualStyleBackColor = false;
            this.Btn_Dashboard.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            // 
            // Main_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(458, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "copy and move";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lbl_Source;
        private System.Windows.Forms.TextBox Txt_Target;
        private System.Windows.Forms.Label Lbl_Target;
        private System.Windows.Forms.TextBox Txt_Source;
        private System.Windows.Forms.Button Btn_Target;
        private System.Windows.Forms.Button Btn_Source;
        private System.Windows.Forms.CheckedListBox Clb_Source;
        private System.Windows.Forms.ListBox Lb_Target;
        private System.Windows.Forms.Button Btn_Copy;
        private System.Windows.Forms.Button Btn_Move;
        private System.Windows.Forms.Button Btn_Dashboard;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

