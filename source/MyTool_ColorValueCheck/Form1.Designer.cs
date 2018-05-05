namespace MyTool_ColorValueCheck
{
	partial class getRGB
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.labelFileName = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelR = new System.Windows.Forms.Label();
			this.labelR_Value = new System.Windows.Forms.Label();
			this.labelG = new System.Windows.Forms.Label();
			this.labelG_Value = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelB_Value = new System.Windows.Forms.Label();
			this.labelA = new System.Windows.Forms.Label();
			this.labelA_Value = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panelColor = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelFileName
			// 
			this.labelFileName.AutoSize = true;
			this.labelFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.labelFileName.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelFileName.ForeColor = System.Drawing.SystemColors.Control;
			this.labelFileName.Location = new System.Drawing.Point(21, 7);
			this.labelFileName.Name = "labelFileName";
			this.labelFileName.Size = new System.Drawing.Size(72, 20);
			this.labelFileName.TabIndex = 10;
			this.labelFileName.Text = "No Image";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.OldLace;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(20, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 256);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
			this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
			this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 10F);
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 21);
			this.label1.TabIndex = 8;
			this.label1.Text = "▼画像をドラッグ＆ドロップしてください";
			// 
			// labelR
			// 
			this.labelR.AutoSize = true;
			this.labelR.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelR.Location = new System.Drawing.Point(5, 6);
			this.labelR.Name = "labelR";
			this.labelR.Size = new System.Drawing.Size(24, 20);
			this.labelR.TabIndex = 10;
			this.labelR.Text = "R:";
			// 
			// labelR_Value
			// 
			this.labelR_Value.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelR_Value.Location = new System.Drawing.Point(28, 6);
			this.labelR_Value.Name = "labelR_Value";
			this.labelR_Value.Size = new System.Drawing.Size(33, 20);
			this.labelR_Value.TabIndex = 10;
			this.labelR_Value.Text = "-";
			this.labelR_Value.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelG
			// 
			this.labelG.AutoSize = true;
			this.labelG.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelG.Location = new System.Drawing.Point(5, 28);
			this.labelG.Name = "labelG";
			this.labelG.Size = new System.Drawing.Size(24, 20);
			this.labelG.TabIndex = 10;
			this.labelG.Text = "G:";
			// 
			// labelG_Value
			// 
			this.labelG_Value.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelG_Value.Location = new System.Drawing.Point(28, 27);
			this.labelG_Value.Name = "labelG_Value";
			this.labelG_Value.Size = new System.Drawing.Size(33, 20);
			this.labelG_Value.TabIndex = 10;
			this.labelG_Value.Text = "-";
			this.labelG_Value.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelB
			// 
			this.labelB.AutoSize = true;
			this.labelB.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelB.Location = new System.Drawing.Point(5, 50);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(24, 20);
			this.labelB.TabIndex = 10;
			this.labelB.Text = "B:";
			// 
			// labelB_Value
			// 
			this.labelB_Value.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelB_Value.Location = new System.Drawing.Point(28, 50);
			this.labelB_Value.Name = "labelB_Value";
			this.labelB_Value.Size = new System.Drawing.Size(33, 20);
			this.labelB_Value.TabIndex = 10;
			this.labelB_Value.Text = "-";
			this.labelB_Value.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelA.Location = new System.Drawing.Point(5, 72);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(24, 20);
			this.labelA.TabIndex = 10;
			this.labelA.Text = "A:";
			// 
			// labelA_Value
			// 
			this.labelA_Value.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelA_Value.Location = new System.Drawing.Point(28, 72);
			this.labelA_Value.Name = "labelA_Value";
			this.labelA_Value.Size = new System.Drawing.Size(33, 20);
			this.labelA_Value.TabIndex = 10;
			this.labelA_Value.Text = "-";
			this.labelA_Value.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(361, 34);
			this.panel1.TabIndex = 11;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel2.Controls.Add(this.labelFileName);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 301);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(361, 32);
			this.panel2.TabIndex = 12;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 34);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(288, 267);
			this.panel3.TabIndex = 13;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panelColor);
			this.panel4.Controls.Add(this.labelA_Value);
			this.panel4.Controls.Add(this.labelR);
			this.panel4.Controls.Add(this.labelA);
			this.panel4.Controls.Add(this.labelB_Value);
			this.panel4.Controls.Add(this.labelR_Value);
			this.panel4.Controls.Add(this.labelG);
			this.panel4.Controls.Add(this.labelB);
			this.panel4.Controls.Add(this.labelG_Value);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(288, 34);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(73, 267);
			this.panel4.TabIndex = 14;
			// 
			// panelColor
			// 
			this.panelColor.BackColor = System.Drawing.Color.OldLace;
			this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelColor.Location = new System.Drawing.Point(19, 97);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new System.Drawing.Size(34, 34);
			this.panelColor.TabIndex = 11;
			// 
			// getRGB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 333);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MinimumSize = new System.Drawing.Size(377, 230);
			this.Name = "getRGB";
			this.Text = "Color Check Tool";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelFileName;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelR;
		private System.Windows.Forms.Label labelR_Value;
		private System.Windows.Forms.Label labelG;
		private System.Windows.Forms.Label labelG_Value;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelB_Value;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.Label labelA_Value;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panelColor;
	}
}

