
namespace EczaneOtomasyonu
{
    partial class Tedarik_Üretici
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tedarik_Üretici));
			this.ureticiRadio = new System.Windows.Forms.RadioButton();
			this.tedarikRadio = new System.Windows.Forms.RadioButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tedarikYRadio = new System.Windows.Forms.RadioButton();
			this.ureticiYRadio = new System.Windows.Forms.RadioButton();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// ureticiRadio
			// 
			this.ureticiRadio.AutoSize = true;
			this.ureticiRadio.Location = new System.Drawing.Point(22, 31);
			this.ureticiRadio.Name = "ureticiRadio";
			this.ureticiRadio.Size = new System.Drawing.Size(109, 21);
			this.ureticiRadio.TabIndex = 0;
			this.ureticiRadio.TabStop = true;
			this.ureticiRadio.Text = "Üretici Şirket";
			this.ureticiRadio.UseVisualStyleBackColor = true;
			this.ureticiRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// tedarikRadio
			// 
			this.tedarikRadio.AutoSize = true;
			this.tedarikRadio.Location = new System.Drawing.Point(313, 31);
			this.tedarikRadio.Name = "tedarikRadio";
			this.tedarikRadio.Size = new System.Drawing.Size(116, 21);
			this.tedarikRadio.TabIndex = 1;
			this.tedarikRadio.TabStop = true;
			this.tedarikRadio.Text = "Tedarik Firma";
			this.tedarikRadio.UseVisualStyleBackColor = true;
			this.tedarikRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(22, 96);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(467, 305);
			this.dataGridView1.TabIndex = 2;
			// 
			// tedarikYRadio
			// 
			this.tedarikYRadio.AutoSize = true;
			this.tedarikYRadio.Location = new System.Drawing.Point(313, 58);
			this.tedarikYRadio.Name = "tedarikYRadio";
			this.tedarikYRadio.Size = new System.Drawing.Size(176, 21);
			this.tedarikYRadio.TabIndex = 3;
			this.tedarikYRadio.TabStop = true;
			this.tedarikYRadio.Text = "Tedarik Firma Yetkilileri";
			this.tedarikYRadio.UseVisualStyleBackColor = true;
			this.tedarikYRadio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// ureticiYRadio
			// 
			this.ureticiYRadio.AutoSize = true;
			this.ureticiYRadio.Location = new System.Drawing.Point(22, 58);
			this.ureticiYRadio.Name = "ureticiYRadio";
			this.ureticiYRadio.Size = new System.Drawing.Size(169, 21);
			this.ureticiYRadio.TabIndex = 4;
			this.ureticiYRadio.TabStop = true;
			this.ureticiYRadio.Text = "Üretici Şirket Yetkilileri";
			this.ureticiYRadio.UseVisualStyleBackColor = true;
			this.ureticiYRadio.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// button5
			// 
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(22, 411);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(88, 78);
			this.button5.TabIndex = 16;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Tedarik_Üretici
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Ivory;
			this.ClientSize = new System.Drawing.Size(524, 501);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.ureticiYRadio);
			this.Controls.Add(this.tedarikYRadio);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tedarikRadio);
			this.Controls.Add(this.ureticiRadio);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Tedarik_Üretici";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tedarik-Üretici - MSY ECZANESİ";
			this.Load += new System.EventHandler(this.Tedarik_Üretici_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ureticiRadio;
        private System.Windows.Forms.RadioButton tedarikRadio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton tedarikYRadio;
        private System.Windows.Forms.RadioButton ureticiYRadio;
		private System.Windows.Forms.Button button5;
	}
}