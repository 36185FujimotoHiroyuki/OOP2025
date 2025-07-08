using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static CaReportSystem.CarReport;
using System.Xaml.Permissions;

namespace CaReportSystem {
    public partial class Form1 : Form {
        //カーレポート管理用リスト
        BindingList<CarReport> ListCarReports = new BindingList<CarReport>();

        //設定クラスのインスタンスを生成
        Setting



        public Form1() {
            InitializeComponent();
            dguRecord.DataSource = ListCarReports;
        }
        private void btPicOpen_Click(object sender, EventArgs e) {
            pbPicture.Image = null;



        }


        private void btPIcOpen_Click_1(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }
        //いらないコード
        // private void btRecordadd_Click(object sender, EventArgs e) {

        //    tsslbMessage.Text = "記録者、または車名が未入力です";


        //    pbPicture.Image = null;
        //  }

        //記録者の履歴をコンボボックスへ登録（重複なし）
        private void setCbAuthor(string author) {
            //既に登録済みか確認
            if (!cbAuthor.Items.Contains(author)) {
                //未登録なら登録「登録済みなら何もしない」

            }
        }

        //  車名の履歴をコンボボックスへ登録（重複なし）
        private void setCbCarName(string carName) {
            if (!cbAuthor.Items.Contains(carName)) {
                ////未登録なら登録「登録済みなら何もしない」
                cbCarName.Items.Add(carName);

            }
        }



        private void btRecordAdd_Click(object sender, EventArgs e) {
            //記入者、車名が何も書かれなかったら下の文を書け
            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です";
                return;
            }



            var carReport = new CarReport {

                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbreport.Text,
                Picture = pbPicture.Image,

            };
            ListCarReports.Add(carReport);
            setCbAuthor(cbAuthor.Text);//コンボボックスへ登録
            setCbCarName(cbCarName.Text);
            InputItemAIICIear();//登録

        }
        //入力項目をすべてクリア
        private void InputItemAIICIear() {

            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbreport.Text = string.Empty;
            pbPicture.Image = null;



        }
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return MakerGroup.トヨタ;
            } else if (rbhonda.Checked) {
                return MakerGroup.ホンダ;
            } else if (rbSubaru.Checked) {
                return MakerGroup.スバル;

            } else if (rbsuzuki.Checked) {
                return MakerGroup.スズキ;

            } else if (rbNinsan.Checked) {
                return MakerGroup.日産;

            } else if (rbOther.Checked) {
                return MakerGroup.その他;
            } else {
                return MakerGroup.なし;
            }
        }

        private void dguRecord_Click(object sender, EventArgs e) {
            if (dguRecord.CurrentRow == null) return;

            dtpDate.Value = (DateTime)dguRecord.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dguRecord.CurrentRow.Cells["Author"].Value;
            setRadioButtonMaker((MakerGroup)dguRecord.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dguRecord.CurrentRow.Cells["CarName"].Value;
            tbreport.Text = (string)dguRecord.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dguRecord.CurrentRow.Cells["Picture"].Value;

        }

        //指定したメーカーのラジオボタンをセット
        private void setRadioButtonMaker(MakerGroup targetMaker) {

            //rbToyota.Checked = false;
            //rbhonda.Checked = false;
            //rbSubaru.Checked = false;
            //rbsuzuki.Checked = false;
            //rbOther.Checked = false;

            switch (targetMaker) {
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbhonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.スズキ:
                    rbsuzuki.Checked = true;
                    break;
                case MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:

                    rbOther.Checked = true;
                    break;

            }

        }
        // 新規追加のイベントパンドラ
        private void btNewRecord_Click(object sender, EventArgs e) {

            InputItemAIICIear();

        }

        // 修正ボタンのイベントパンドラ
        private void btRecordModify_Click(object sender, EventArgs e) {
            if ((dguRecord.CurrentRow == null) ||
              (!dguRecord.CurrentRow.Selected)) return;


            //間違い
            //    if (dguRecord.CurrentRow == null) return;
            // var current = dguRecord.CurrentRow.DataBoundItem as CarReport;
            //  if (current == null) return;
            //  dguRecord.Refresh();
            //  InputItemAIICIear();
        }
        //間違い
        // 修正ボタンのイベントパンドラ
        //  private void btRecordModify_Click(object sender, EventArgs e) {

        //     if (dguRecord.CurrentRow == null) return;
        //     var current = dguRecord.CurrentRow.DataBoundItem as CarReport;
        //     if (current == null) return;
        //    dguRecord.Refresh();

        //    InputItemAIICIear();
        //  }


        //削除ボタンのイベントパンドラ
        private void btRecordDelete_Click(object sender, EventArgs e) {
            ///カーレポート管理用リストから
            ///該当するデータを削除する

            //       if (dguRecord.CurrentRow == null) return;
            //選択されているインデックスを取得
            //       int Index = dguRecord.CurrentRow.Index;

            //      if (Index >= 0 && Index < ListCarReports.Count) {
            //削除したいインデックスを指定してリストから削除
            //         ListCarReports.RemoveAt(Index);

            //正解文
            if ((dguRecord.CurrentRow == null)
            || (!dguRecord.CurrentRow.Selected)) return;
            //選択されているインデックスを取得
            int Index = dguRecord.CurrentRow.Index;
            //削除したいインデックスを指定してリストから削除
            ListCarReports.RemoveAt(Index);


            //間違い
            // if (dguRecord.CurrentRow == null) return;
            // var current = dguRecord.CurrentRow.DataBoundItem as CarReport;
            //  if (current == null) return;
            // ListCarReports.Remove(current);
            //  dguRecord.Refresh();

        }


        private void Form1_Load(object sender, EventArgs e) {
            InputItemAIICIear();

            //交互に色を設定（データグリッドビュー）


            dguRecord.DefaultCellStyle.BackColor = Color.LightGray;

            dguRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            //設定ファイルを読み込み背景色を設定（逆シリアル化）




        }

        private void ファイルFToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }
        //このアプリについてを選択した時のイベントパンドラ
        private void このアプリについてToolStripMenuItem_Click(object sender, EventArgs e) {
            fmVersion fmv = new fmVersion();
            fmv.ShowDialog();
        }

        private void Collar_Click(object sender, EventArgs e) {

            if (cdCollar.ShowDialog() == DialogResult.OK) {
                BackColor = cdCollar.Color;
                //設定ファイルへ保存
                settings.MainFormBackColor = cdCollar.Color.ToArgb();//背景色を設定インスタンスへ設定




            }
        }

        //ファイルオープン処理
        private void reportOpenFile() {

            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //逆シリアル化でバイナリ形式を取り込む
#pragma warning disable SYSLIB0011 // 型またはメンバーが旧型式です
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // 型またはメンバーが旧型式です
                    using (FileStream fs = File.Open(
                        ofdPicFileOpen.FileName, FileMode.Open, FileAccess.Read)) {

                        ListCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dguRecord.DataSource = ListCarReports;

                        cbAuthor.Items.Clear();
                        //コンボボックスに登録
                        foreach (var report in ListCarReports) {
                            setCbAuthor(report.Author);
                            setCbCarName(report.CarName);

                        }

                    }

                }
                catch (Exception) {
                    tsslbMessage.Text = "ファイル形式が違います";

                }

            }
        }



        //ファイルセーブ処理
        private void reportSaveFile() {
            if (sfdReportfilesave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
#pragma warning disable SYSLIB0011


                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011



                    using (FileStream fs = File.Open(
                        sfdReportfilesave.FileName, FileMode.Create)) {

                        bf.Serialize(fs, ListCarReports);

                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "ファイル書き出しエラー";
                    MessageBox.Show(ex.Message);//←より具体的なエラーを出力

                }
            }

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            reportSaveFile();
            try {
                reportSaveFile();
                tsslbMessage.Text = " 保存に成功しました";
            }
            catch (Exception ex) {

                tsslbMessage.Text = "保存時にエラーが発生しました: " + ex.Message;

            }

        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            reportSaveFile();
        }




        //フォームが閉じたら呼ばれる
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルへ色情報を保存する処理（シリアル化）

            var colorSettings = new ColorSettings {
                //FormBackgroundColor
                MainFormBackColor = BackColor
            };


        }
    }
}
    






