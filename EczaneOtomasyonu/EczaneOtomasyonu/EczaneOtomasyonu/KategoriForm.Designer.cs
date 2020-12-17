
namespace EczaneOtomasyonu
{
    partial class KategoriForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ktAdTBox = new System.Windows.Forms.TextBox();
            this.silButton = new System.Windows.Forms.Button();
            this.guncelButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.yAdLabel = new System.Windows.Forms.Label();
            this.ktGTbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(298, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(376, 45);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(127, 51);
            this.ekleButton.TabIndex = 1;
            this.ekleButton.Text = "EKLE";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Adı";
            // 
            // ktAdTBox
            // 
            this.ktAdTBox.Location = new System.Drawing.Point(165, 242);
            this.ktAdTBox.Name = "ktAdTBox";
            this.ktAdTBox.Size = new System.Drawing.Size(100, 22);
            this.ktAdTBox.TabIndex = 5;
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(376, 102);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(127, 51);
            this.silButton.TabIndex = 6;
            this.silButton.Text = "SİL";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // guncelButton
            // 
            this.guncelButton.Location = new System.Drawing.Point(376, 161);
            this.guncelButton.Name = "guncelButton";
            this.guncelButton.Size = new System.Drawing.Size(127, 51);
            this.guncelButton.TabIndex = 7;
            this.guncelButton.Text = "GÜNCELLE";
            this.guncelButton.UseVisualStyleBackColor = true;
            this.guncelButton.Click += new System.EventHandler(this.guncelButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(282, 242);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Ürün Güncelleyeceğim";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // yAdLabel
            // 
            this.yAdLabel.AutoSize = true;
            this.yAdLabel.Location = new System.Drawing.Point(55, 275);
            this.yAdLabel.Name = "yAdLabel";
            this.yAdLabel.Size = new System.Drawing.Size(57, 17);
            this.yAdLabel.TabIndex = 9;
            this.yAdLabel.Text = "Yeni Ad";
            // 
            // ktGTbox
            // 
            this.ktGTbox.Location = new System.Drawing.Point(165, 275);
            this.ktGTbox.Name = "ktGTbox";
            this.ktGTbox.Size = new System.Drawing.Size(100, 22);
            this.ktGTbox.TabIndex = 10;
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 320);
            this.Controls.Add(this.ktGTbox);
            this.Controls.Add(this.yAdLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.guncelButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ktAdTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KategoriForm";
            this.Text = "KategoriForm";
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ktAdTBox;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button guncelButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label yAdLabel;
        private System.Windows.Forms.TextBox ktGTbox;
    }
}