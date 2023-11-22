namespace DemoFacilitiesFormsApp4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFacility_No = new System.Windows.Forms.TextBox();
            this.txtClosingTime = new System.Windows.Forms.TextBox();
            this.txtOpeningTime = new System.Windows.Forms.TextBox();
            this.txtTypes = new System.Windows.Forms.TextBox();
            this.txtHotel_No = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facility_No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hotel_No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Types";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "OpeningTime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ClosingTime";
            // 
            // txtFacility_No
            // 
            this.txtFacility_No.Location = new System.Drawing.Point(147, 8);
            this.txtFacility_No.Name = "txtFacility_No";
            this.txtFacility_No.Size = new System.Drawing.Size(174, 26);
            this.txtFacility_No.TabIndex = 5;
            // 
            // txtClosingTime
            // 
            this.txtClosingTime.Location = new System.Drawing.Point(147, 160);
            this.txtClosingTime.Name = "txtClosingTime";
            this.txtClosingTime.Size = new System.Drawing.Size(174, 26);
            this.txtClosingTime.TabIndex = 6;
            // 
            // txtOpeningTime
            // 
            this.txtOpeningTime.Location = new System.Drawing.Point(147, 120);
            this.txtOpeningTime.Name = "txtOpeningTime";
            this.txtOpeningTime.Size = new System.Drawing.Size(174, 26);
            this.txtOpeningTime.TabIndex = 7;
            // 
            // txtTypes
            // 
            this.txtTypes.Location = new System.Drawing.Point(147, 79);
            this.txtTypes.Name = "txtTypes";
            this.txtTypes.Size = new System.Drawing.Size(174, 26);
            this.txtTypes.TabIndex = 8;
            // 
            // txtHotel_No
            // 
            this.txtHotel_No.Location = new System.Drawing.Point(147, 42);
            this.txtHotel_No.Name = "txtHotel_No";
            this.txtHotel_No.Size = new System.Drawing.Size(174, 26);
            this.txtHotel_No.TabIndex = 9;
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Blue;
            this.Insert.Location = new System.Drawing.Point(639, 67);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 53);
            this.Insert.TabIndex = 10;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Yellow;
            this.Update.Location = new System.Drawing.Point(747, 67);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 53);
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(851, 67);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 53);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(959, 67);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(107, 51);
            this.View.TabIndex = 13;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Pink;
            this.Exit.Location = new System.Drawing.Point(1081, 66);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 52);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.Location = new System.Drawing.Point(665, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 35);
            this.button6.TabIndex = 15;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(444, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 26);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(799, 312);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.txtHotel_No);
            this.Controls.Add(this.txtTypes);
            this.Controls.Add(this.txtOpeningTime);
            this.Controls.Add(this.txtClosingTime);
            this.Controls.Add(this.txtFacility_No);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFacility_No;
        private System.Windows.Forms.TextBox txtClosingTime;
        private System.Windows.Forms.TextBox txtOpeningTime;
        private System.Windows.Forms.TextBox txtTypes;
        private System.Windows.Forms.TextBox txtHotel_No;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

