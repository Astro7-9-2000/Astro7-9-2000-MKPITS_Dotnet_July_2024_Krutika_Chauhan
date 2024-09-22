namespace CRUDPractice1
{
    partial class PracticeForm1
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
            this.PracticeForm1lbl = new System.Windows.Forms.Label();
            this.lbl_ProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.RichTextBox();
            this.txtItemName = new System.Windows.Forms.RichTextBox();
            this.txtDesign = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PracticeForm1lbl
            // 
            this.PracticeForm1lbl.AutoSize = true;
            this.PracticeForm1lbl.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PracticeForm1lbl.Location = new System.Drawing.Point(270, 24);
            this.PracticeForm1lbl.Name = "PracticeForm1lbl";
            this.PracticeForm1lbl.Size = new System.Drawing.Size(202, 29);
            this.PracticeForm1lbl.TabIndex = 0;
            this.PracticeForm1lbl.Text = "Practice Form 1";
            // 
            // lbl_ProductId
            // 
            this.lbl_ProductId.AutoSize = true;
            this.lbl_ProductId.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductId.Location = new System.Drawing.Point(48, 132);
            this.lbl_ProductId.Name = "lbl_ProductId";
            this.lbl_ProductId.Size = new System.Drawing.Size(110, 24);
            this.lbl_ProductId.TabIndex = 1;
            this.lbl_ProductId.Text = "Product ID";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(234, 132);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(270, 24);
            this.txtProductId.TabIndex = 1;
            this.txtProductId.Text = "";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(234, 216);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(270, 24);
            this.txtItemName.TabIndex = 2;
            this.txtItemName.Text = "";
            // 
            // txtDesign
            // 
            this.txtDesign.Location = new System.Drawing.Point(234, 297);
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.Size = new System.Drawing.Size(270, 24);
            this.txtDesign.TabIndex = 3;
            this.txtDesign.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "ItemName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Design";
            // 
            // CmbColor
            // 
            this.CmbColor.FormattingEnabled = true;
            this.CmbColor.Items.AddRange(new object[] {
            "Red",
            "Black",
            "White",
            "Grey"});
            this.CmbColor.Location = new System.Drawing.Point(234, 392);
            this.CmbColor.Name = "CmbColor";
            this.CmbColor.Size = new System.Drawing.Size(270, 24);
            this.CmbColor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color";
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.InsertBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(52, 662);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(132, 50);
            this.InsertBtn.TabIndex = 9;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(544, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(886, 290);
            this.dataGridView1.TabIndex = 10;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(216, 662);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(132, 50);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(382, 662);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(132, 50);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.SearchBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(566, 662);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(132, 50);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Location = new System.Drawing.Point(234, 520);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(270, 23);
            this.DateTimePicker.TabIndex = 15;
            // 
            // PracticeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1469, 750);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesign);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbl_ProductId);
            this.Controls.Add(this.PracticeForm1lbl);
            this.Name = "PracticeForm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PracticeForm1lbl;
        private System.Windows.Forms.Label lbl_ProductId;
        private System.Windows.Forms.RichTextBox txtProductId;
        private System.Windows.Forms.RichTextBox txtItemName;
        private System.Windows.Forms.RichTextBox txtDesign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}

