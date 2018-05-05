using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTool_ColorValueCheck
{
	public partial class getRGB : Form
	{
		public getRGB()
		{
			InitializeComponent();
			//ドロップしたデータを受け入れるかどうか
			pictureBox1.AllowDrop = true;
		}

		private void pictureBox1_DragEnter(object sender, DragEventArgs e)
		{
			this.toggleEffectsToDragEvent(e);
		}

		//ソース画像とそのサイズやパス情報
		Image picture;
		string filePass;
		string fileDir;
		string fileName;
		int w;
		int h;

		//画像をドロップした時の挙動
		private void pictureBox1_DragDrop(object sender, DragEventArgs e)
		{
			filePass = this.getFileNameToDragEvent(e);
			/*
			//ただ画像ファイルを表示するだけならこちらでOK
			this.showPicture(filePass);
			*/

			//ファイルパスからファイル名を取得する
			fileName = Path.GetFileName(filePass);
			//ファイルパスからフォルダパスを取得する
			fileDir = Path.GetDirectoryName(filePass);

			//対応外の画像形式を読み込むと例外になるので対処
			try
			{
				//画像ファイルを読み込んで、Imageオブジェクトを作成する
				picture = Image.FromFile(filePass);

			}
			catch (Exception)
			{
				MessageBox.Show("対応していない画像形式です");
				return;
			}

			//画像を表示する
			pictureBox1.Image = picture;

			//ファイル名をラベルに表示
			labelFileName.Text = fileName;

			//画像の幅と高さを取得
			w = picture.Width;
			h = picture.Height;

			//フォームを画像サイズに合わせてリサイズ
			this.Width = w + 80;
			this.Height = h + 116;
		}

		//ドラッグしてきたものがファイルなら受け付け
		//それ以外なら受け付けない定番の記述
		private void toggleEffectsToDragEvent(DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.All;
			else
				e.Effect = DragDropEffects.None;
		}
		//ファイルのパスを取得する
		private string getFileNameToDragEvent(DragEventArgs e)
		{
			string[] filePass = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (File.Exists(filePass[0]) == true)
			{
				return filePass[0];
			}
			else
			{
				return null;
			}
		}

		//マウスクリックで色の値を取得する
		private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
		{
			//PixtureBox内の画像が無い領域をクリックすると例外になるので対処
			try
			{
				//クリックした座標の色を取得
				Color c = ((Bitmap)(pictureBox1.Image)).GetPixel(e.Location.X, e.Location.Y);

				//カラー値をラベルに表示
				labelR_Value.Text = c.R.ToString();
				labelG_Value.Text = c.G.ToString();
				labelB_Value.Text = c.B.ToString();

				//カラーをプレビュー用パネルの背景に表示
				panelColor.BackColor = Color.FromArgb(c.R, c.G, c.B);

			}
			catch (Exception){
				MessageBox.Show("画像内のピクセルをクリックしてください");
				return;
			}

		}
	}
}
