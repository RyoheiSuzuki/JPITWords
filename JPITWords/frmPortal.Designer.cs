namespace JPITWords
{
    partial class frmPortal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_act2 = new System.Windows.Forms.Label();
            this.lbl_act1 = new System.Windows.Forms.Label();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.lbl_greetings = new System.Windows.Forms.Label();
            this.grd_listTest = new System.Windows.Forms.DataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExplanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_act2
            // 
            this.lbl_act2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_act2.AutoSize = true;
            this.lbl_act2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.lbl_act2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_act2.Location = new System.Drawing.Point(879, 0);
            this.lbl_act2.Name = "lbl_act2";
            this.lbl_act2.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_act2.Size = new System.Drawing.Size(111, 46);
            this.lbl_act2.TabIndex = 2;
            this.lbl_act2.Text = "Sign Up";
            // 
            // lbl_act1
            // 
            this.lbl_act1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_act1.AutoSize = true;
            this.lbl_act1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.lbl_act1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_act1.Location = new System.Drawing.Point(768, 0);
            this.lbl_act1.Name = "lbl_act1";
            this.lbl_act1.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_act1.Size = new System.Drawing.Size(105, 46);
            this.lbl_act1.TabIndex = 1;
            this.lbl_act1.Text = "Sign In";
            // 
            // pic_home
            // 
            this.pic_home.Image = global::JPITWords.Properties.Resources.home;
            this.pic_home.Location = new System.Drawing.Point(1, 0);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(50, 50);
            this.pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_home.TabIndex = 2;
            this.pic_home.TabStop = false;
            // 
            // lbl_greetings
            // 
            this.lbl_greetings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_greetings.AutoSize = true;
            this.lbl_greetings.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_greetings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_greetings.Location = new System.Drawing.Point(362, 0);
            this.lbl_greetings.Name = "lbl_greetings";
            this.lbl_greetings.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_greetings.Size = new System.Drawing.Size(20, 55);
            this.lbl_greetings.TabIndex = 1;
            this.lbl_greetings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grd_listTest
            // 
            this.grd_listTest.AllowUserToAddRows = false;
            this.grd_listTest.AllowUserToDeleteRows = false;
            this.grd_listTest.AllowUserToOrderColumns = true;
            this.grd_listTest.AllowUserToResizeColumns = false;
            this.grd_listTest.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.grd_listTest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_listTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_listTest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grd_listTest.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grd_listTest.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_listTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_listTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_listTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colDate,
            this.colTitle,
            this.colScore,
            this.colExplanation});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_listTest.DefaultCellStyle = dataGridViewCellStyle8;
            this.grd_listTest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grd_listTest.Enabled = false;
            this.grd_listTest.Location = new System.Drawing.Point(30, 80);
            this.grd_listTest.MultiSelect = false;
            this.grd_listTest.Name = "grd_listTest";
            this.grd_listTest.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_listTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_listTest.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grd_listTest.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.grd_listTest.RowTemplate.Height = 48;
            this.grd_listTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_listTest.Size = new System.Drawing.Size(940, 480);
            this.grd_listTest.TabIndex = 3;
            // 
            // colNumber
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.colNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNumber.FillWeight = 50F;
            this.colNumber.Frozen = true;
            this.colNumber.HeaderText = "#";
            this.colNumber.MaxInputLength = 100;
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            this.colNumber.Width = 50;
            // 
            // colDate
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = "N/A";
            this.colDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDate.FillWeight = 150F;
            this.colDate.Frozen = true;
            this.colDate.HeaderText = "Date";
            this.colDate.MaxInputLength = 10;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 150;
            // 
            // colTitle
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.colTitle.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTitle.FillWeight = 200F;
            this.colTitle.Frozen = true;
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 200;
            // 
            // colScore
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "N/A";
            this.colScore.DefaultCellStyle = dataGridViewCellStyle6;
            this.colScore.HeaderText = "Score";
            this.colScore.MaxInputLength = 3;
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            // 
            // colExplanation
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.colExplanation.DefaultCellStyle = dataGridViewCellStyle7;
            this.colExplanation.FillWeight = 400F;
            this.colExplanation.HeaderText = "Overview";
            this.colExplanation.Name = "colExplanation";
            this.colExplanation.ReadOnly = true;
            this.colExplanation.Width = 400;
            // 
            // frmPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1002, 584);
            this.Controls.Add(this.grd_listTest);
            this.Controls.Add(this.lbl_greetings);
            this.Controls.Add(this.pic_home);
            this.Controls.Add(this.lbl_act1);
            this.Controls.Add(this.lbl_act2);
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "frmPortal";
            this.Text = "Training Application";
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_act2;
        private System.Windows.Forms.Label lbl_act1;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.Label lbl_greetings;
        private System.Windows.Forms.DataGridView grd_listTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExplanation;
    }
}