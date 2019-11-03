namespace GUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.cboxFre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCRemove = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnCNew = new System.Windows.Forms.Button();
            this.btnCChange = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lvTable = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategory = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnChangeListView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(16, 309);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(265, 29);
            this.txtUrl.TabIndex = 6;
            // 
            // cboxCategory
            // 
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(580, 309);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(152, 28);
            this.cboxCategory.TabIndex = 9;
            this.cboxCategory.SelectedIndexChanged += new System.EventHandler(this.cboxCategory_SelectedIndexChanged);
            // 
            // cboxFre
            // 
            this.cboxFre.FormattingEnabled = true;
            this.cboxFre.Items.AddRange(new object[] {
            "Var 10:e sekund",
            "Var 20:e sekund",
            "Var 30:e sekund"});
            this.cboxFre.Location = new System.Drawing.Point(334, 309);
            this.cboxFre.Name = "cboxFre";
            this.cboxFre.Size = new System.Drawing.Size(222, 28);
            this.cboxFre.TabIndex = 10;
            this.cboxFre.SelectedIndexChanged += new System.EventHandler(this.cboxFre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Uppdateringsfrekvens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(816, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kategorier:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(578, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "URL:";
            // 
            // btnCRemove
            // 
            this.btnCRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCRemove.Location = new System.Drawing.Point(1163, 354);
            this.btnCRemove.Name = "btnCRemove";
            this.btnCRemove.Size = new System.Drawing.Size(108, 62);
            this.btnCRemove.TabIndex = 22;
            this.btnCRemove.Text = "Ta bort";
            this.btnCRemove.UseVisualStyleBackColor = false;
            this.btnCRemove.Click += new System.EventHandler(this.btnCRemove_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCategory.Location = new System.Drawing.Point(820, 309);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(450, 29);
            this.txtCategory.TabIndex = 27;
            // 
            // btnCNew
            // 
            this.btnCNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCNew.Location = new System.Drawing.Point(934, 354);
            this.btnCNew.Name = "btnCNew";
            this.btnCNew.Size = new System.Drawing.Size(108, 62);
            this.btnCNew.TabIndex = 29;
            this.btnCNew.Text = "Ny";
            this.btnCNew.UseVisualStyleBackColor = false;
            this.btnCNew.Click += new System.EventHandler(this.btnCNew_Click);
            // 
            // btnCChange
            // 
            this.btnCChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCChange.Location = new System.Drawing.Point(1048, 354);
            this.btnCChange.Name = "btnCChange";
            this.btnCChange.Size = new System.Drawing.Size(108, 62);
            this.btnCChange.TabIndex = 30;
            this.btnCChange.Text = "Ändra";
            this.btnCChange.UseVisualStyleBackColor = false;
            this.btnCChange.Click += new System.EventHandler(this.btnCChange_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(334, 354);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(130, 62);
            this.btnNew.TabIndex = 33;
            this.btnNew.Text = "Ny";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.Location = new System.Drawing.Point(610, 354);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 62);
            this.btnRemove.TabIndex = 31;
            this.btnRemove.Text = "Ta bort";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(818, 452);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(468, 225);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Text";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(12, 428);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(166, 25);
            this.lblSection.TabIndex = 37;
            this.lblSection.Text = "Podcast avsnitt:";
            // 
            // lvTable
            // 
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTable.FullRowSelect = true;
            this.lvTable.GridLines = true;
            this.lvTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTable.HideSelection = false;
            this.lvTable.Location = new System.Drawing.Point(16, 28);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(724, 216);
            this.lvTable.TabIndex = 39;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Namn";
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frekvens";
            this.columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            this.columnHeader4.Width = 150;
            // 
            // lvCategory
            // 
            this.lvCategory.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvCategory.HideSelection = false;
            this.lvCategory.LabelEdit = true;
            this.lvCategory.Location = new System.Drawing.Point(820, 65);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(450, 178);
            this.lvCategory.TabIndex = 40;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.List;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(817, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Kategori:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 457);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(724, 220);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnChangeListView
            // 
            this.btnChangeListView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeListView.Location = new System.Drawing.Point(474, 354);
            this.btnChangeListView.Name = "btnChangeListView";
            this.btnChangeListView.Size = new System.Drawing.Size(130, 62);
            this.btnChangeListView.TabIndex = 45;
            this.btnChangeListView.Text = "Ändra";
            this.btnChangeListView.UseVisualStyleBackColor = false;
            this.btnChangeListView.Click += new System.EventHandler(this.btnChangeListView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1282, 688);
            this.Controls.Add(this.btnChangeListView);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.lvTable);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCChange);
            this.Controls.Add(this.btnCNew);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnCRemove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxFre);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Podcasts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.ComboBox cboxFre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCRemove;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnCNew;
        private System.Windows.Forms.Button btnCChange;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnChangeListView;
    }
}

