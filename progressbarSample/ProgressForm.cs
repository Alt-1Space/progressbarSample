using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressbarSample
{
    public partial class ProgressForm : Form
    {
        public ProgressBar progressBar;
        public Label label;

        public ProgressForm()
        {
            progressBar = new ProgressBar();
            label = new Label();

            // ProgressBarの設定
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Dock = DockStyle.Bottom;

            // Labelの設定
            label.Text = "処理を実行しています...";
            label.Dock = DockStyle.Top;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ProgressFormの設定
            this.Controls.Add(progressBar);
            this.Controls.Add(label);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(300, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
        }
    }
}
