using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace progressbarSample
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            // ProgressBarの設定
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            progressBar1.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            using (var progressForm = new ProgressForm())
            {
                progressForm.Show();

                // 非同期処理の開始
                await Task.Run(() => DoWork());

                // 処理が完了したらポップアップを閉じる
                progressForm.Close();
            }

            //// ProgressBarを表示
            //progressBar1.Visible = true;

            //// 何らかの非同期処理を開始
            //await Task.Run(() => DoWork());

            //// ProgressBarを非表示
            //progressBar1.Visible = false;
        }

        // 仮の非同期で実行する長い処理
        private void DoWork()
        {
            // ここに長い処理を書く
            System.Threading.Thread.Sleep(5000); // 仮に5秒間のスリープを入れる
        }
    }
}
