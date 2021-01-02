
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriForm));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ekleButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.ktAdTBox = new System.Windows.Forms.TextBox();
			this.silButton = new System.Windows.Forms.Button();
			this.guncelButton = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.yAdLabel = new System.Windows.Forms.Label();
			this.ktGTbox = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(85, 45);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(348, 171);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// ekleButton
			// 
			this.ekleButton.BackColor = System.Drawing.Color.Red;
			this.ekleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.ekleButton.FlatAppearance.BorderSize = 4;
			this.ekleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ekleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ekleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.ekleButton.Location = new System.Drawing.Point(360, 245);
			this.ekleButton.Name = "ekleButton";
			this.ekleButton.Size = new System.Drawing.Size(127, 51);
			this.ekleButton.TabIndex = 1;
			this.ekleButton.Text = "EKLE";
			this.ekleButton.UseVisualStyleBackColor = false;
			this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(22, 246);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Kategori Adı";
			// 
			// ktAdTBox
			// 
			this.ktAdTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ktAdTBox.Location = new System.Drawing.Point(224, 243);
			this.ktAdTBox.Name = "ktAdTBox";
			this.ktAdTBox.Size = new System.Drawing.Size(100, 26);
			this.ktAdTBox.TabIndex = 5;
			// 
			// silButton
			// 
			this.silButton.BackColor = System.Drawing.Color.Red;
			this.silButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.silButton.FlatAppearance.BorderSize = 4;
			this.silButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.silButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.silButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.silButton.Location = new System.Drawing.Point(360, 304);
			this.silButton.Name = "silButton";
			this.silButton.Size = new System.Drawing.Size(127, 51);
			this.silButton.TabIndex = 6;
			this.silButton.Text = "SİL";
			this.silButton.UseVisualStyleBackColor = false;
			this.silButton.Click += new System.EventHandler(this.silButton_Click);
			// 
			// guncelButton
			// 
			this.guncelButton.BackColor = System.Drawing.Color.Red;
			this.guncelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.guncelButton.FlatAppearance.BorderSize = 4;
			this.guncelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.guncelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.guncelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.guncelButton.Location = new System.Drawing.Point(360, 361);
			this.guncelButton.Name = "guncelButton";
			this.guncelButton.Size = new System.Drawing.Size(127, 51);
			this.guncelButton.TabIndex = 7;
			this.guncelButton.Text = "GÜNCELLE";
			this.guncelButton.UseVisualStyleBackColor = false;
			this.guncelButton.Click += new System.EventHandler(this.guncelButton_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.checkBox1.Location = new System.Drawing.Point(29, 322);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(220, 24);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Ürün Güncelleyeceğim";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// yAdLabel
			// 
			this.yAdLabel.AutoSize = true;
			this.yAdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.yAdLabel.Location = new System.Drawing.Point(22, 279);
			this.yAdLabel.Name = "yAdLabel";
			this.yAdLabel.Size = new System.Drawing.Size(73, 20);
			this.yAdLabel.TabIndex = 9;
			this.yAdLabel.Text = "Yeni Ad";
			// 
			// ktGTbox
			// 
			this.ktGTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ktGTbox.Location = new System.Drawing.Point(224, 279);
			this.ktGTbox.Name = "ktGTbox";
			this.ktGTbox.Size = new System.Drawing.Size(100, 26);
			this.ktGTbox.TabIndex = 10;
			// 
			// button5
			// 
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(27, 361);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(93, 82);
			this.button5.TabIndex = 16;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// KategoriForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Ivory;
			this.ClientSize = new System.Drawing.Size(536, 455);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.ktGTbox);
			this.Controls.Add(this.yAdLabel);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.guncelButton);
			this.Controls.Add(this.silButton);
			this.Controls.Add(this.ktAdTBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ekleButton);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "KategoriForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ürün Kategori Ayarları - MSY ECZANESİ";
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
		private System.Windows.Forms.Button button5;
	}
}