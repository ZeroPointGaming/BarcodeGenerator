namespace BarcodeGeneration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GeneratePreviewBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UnformattedBarcodeTextbox = new System.Windows.Forms.TextBox();
            this.DocumentTitleTextbox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RemoveBarcodeBtn = new System.Windows.Forms.Button();
            this.ClearBarcodeListBtn = new System.Windows.Forms.Button();
            this.UndoClearBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreatePdfBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GeneratePreviewBtn
            // 
            this.GeneratePreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeneratePreviewBtn.Location = new System.Drawing.Point(10, 62);
            this.GeneratePreviewBtn.Name = "GeneratePreviewBtn";
            this.GeneratePreviewBtn.Size = new System.Drawing.Size(182, 46);
            this.GeneratePreviewBtn.TabIndex = 8;
            this.GeneratePreviewBtn.Text = "Generate Preview";
            this.GeneratePreviewBtn.UseVisualStyleBackColor = true;
            this.GeneratePreviewBtn.Click += new System.EventHandler(this.GeneratePreviewBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UPC-A",
            "EAN-13",
            "ITF-14"});
            this.comboBox1.Location = new System.Drawing.Point(92, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "UPC-A";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UnformattedBarcodeTextbox
            // 
            this.UnformattedBarcodeTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.UnformattedBarcodeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnformattedBarcodeTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnformattedBarcodeTextbox.Location = new System.Drawing.Point(100, 7);
            this.UnformattedBarcodeTextbox.Name = "UnformattedBarcodeTextbox";
            this.UnformattedBarcodeTextbox.Size = new System.Drawing.Size(278, 20);
            this.UnformattedBarcodeTextbox.TabIndex = 16;
            this.toolTip1.SetToolTip(this.UnformattedBarcodeTextbox, "UPC-A QTY(1) MFG(51131) PN(26340) Chk(3)");
            // 
            // DocumentTitleTextbox
            // 
            this.DocumentTitleTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DocumentTitleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DocumentTitleTextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DocumentTitleTextbox.Location = new System.Drawing.Point(92, 386);
            this.DocumentTitleTextbox.Name = "DocumentTitleTextbox";
            this.DocumentTitleTextbox.Size = new System.Drawing.Size(286, 20);
            this.DocumentTitleTextbox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.DocumentTitleTextbox, "UPC-A QTY(1) MFG(51131) PN(26340) Chk(3)");
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(10, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(368, 96);
            this.listBox1.TabIndex = 24;
            this.toolTip1.SetToolTip(this.listBox1, "You can fit up to 21 barcodes on a single sheet of barcode labels.");
            // 
            // RemoveBarcodeBtn
            // 
            this.RemoveBarcodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveBarcodeBtn.Location = new System.Drawing.Point(10, 348);
            this.RemoveBarcodeBtn.Name = "RemoveBarcodeBtn";
            this.RemoveBarcodeBtn.Size = new System.Drawing.Size(149, 28);
            this.RemoveBarcodeBtn.TabIndex = 26;
            this.RemoveBarcodeBtn.Text = "Remove Selected Barcode";
            this.toolTip1.SetToolTip(this.RemoveBarcodeBtn, "This removes the currently selected barcode from the barcode list.");
            this.RemoveBarcodeBtn.UseVisualStyleBackColor = true;
            this.RemoveBarcodeBtn.Click += new System.EventHandler(this.RemoveBarcodeBtn_Click);
            // 
            // ClearBarcodeListBtn
            // 
            this.ClearBarcodeListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBarcodeListBtn.Location = new System.Drawing.Point(165, 348);
            this.ClearBarcodeListBtn.Name = "ClearBarcodeListBtn";
            this.ClearBarcodeListBtn.Size = new System.Drawing.Size(136, 28);
            this.ClearBarcodeListBtn.TabIndex = 28;
            this.ClearBarcodeListBtn.Text = "Clear The Barcode List";
            this.toolTip1.SetToolTip(this.ClearBarcodeListBtn, "This removes the currently selected barcode from the barcode list.");
            this.ClearBarcodeListBtn.UseVisualStyleBackColor = true;
            this.ClearBarcodeListBtn.Click += new System.EventHandler(this.ClearBarcodeListBtn_Click);
            // 
            // UndoClearBtn
            // 
            this.UndoClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UndoClearBtn.Location = new System.Drawing.Point(307, 348);
            this.UndoClearBtn.Name = "UndoClearBtn";
            this.UndoClearBtn.Size = new System.Drawing.Size(71, 28);
            this.UndoClearBtn.TabIndex = 29;
            this.UndoClearBtn.Text = "Undo Clear";
            this.toolTip1.SetToolTip(this.UndoClearBtn, "This removes the currently selected barcode from the barcode list.");
            this.UndoClearBtn.UseVisualStyleBackColor = true;
            this.UndoClearBtn.Click += new System.EventHandler(this.UndoClearBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Barcode Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Barcode Type\r\n";
            // 
            // CreatePdfBtn
            // 
            this.CreatePdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreatePdfBtn.Location = new System.Drawing.Point(10, 412);
            this.CreatePdfBtn.Name = "CreatePdfBtn";
            this.CreatePdfBtn.Size = new System.Drawing.Size(368, 28);
            this.CreatePdfBtn.TabIndex = 18;
            this.CreatePdfBtn.Text = "Create Printable Document";
            this.CreatePdfBtn.UseVisualStyleBackColor = true;
            this.CreatePdfBtn.Click += new System.EventHandler(this.CreatePdfBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Document Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Barcode Preview";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(196, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 46);
            this.button3.TabIndex = 25;
            this.button3.Text = "Add Barcode";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddBarcodeToList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Barcode List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(388, 452);
            this.Controls.Add(this.UndoClearBtn);
            this.Controls.Add(this.ClearBarcodeListBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveBarcodeBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocumentTitleTextbox);
            this.Controls.Add(this.CreatePdfBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UnformattedBarcodeTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GeneratePreviewBtn);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Barcode Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GeneratePreviewBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox UnformattedBarcodeTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreatePdfBtn;
        private System.Windows.Forms.TextBox DocumentTitleTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button RemoveBarcodeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearBarcodeListBtn;
        private System.Windows.Forms.Button UndoClearBtn;
    }
}

