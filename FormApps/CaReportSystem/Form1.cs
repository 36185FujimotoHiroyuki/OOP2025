using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static CaReportSystem.CarReport;
using System.Xaml.Permissions;

namespace CaReportSystem {
    public partial class Form1 : Form {
        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport> ListCarReports = new BindingList<CarReport>();

        //�ݒ�N���X�̃C���X�^���X�𐶐�
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
        //����Ȃ��R�[�h
        // private void btRecordadd_Click(object sender, EventArgs e) {

        //    tsslbMessage.Text = "�L�^�ҁA�܂��͎Ԗ��������͂ł�";


        //    pbPicture.Image = null;
        //  }

        //�L�^�҂̗������R���{�{�b�N�X�֓o�^�i�d���Ȃ��j
        private void setCbAuthor(string author) {
            //���ɓo�^�ς݂��m�F
            if (!cbAuthor.Items.Contains(author)) {
                //���o�^�Ȃ�o�^�u�o�^�ς݂Ȃ牽�����Ȃ��v

            }
        }

        //  �Ԗ��̗������R���{�{�b�N�X�֓o�^�i�d���Ȃ��j
        private void setCbCarName(string carName) {
            if (!cbAuthor.Items.Contains(carName)) {
                ////���o�^�Ȃ�o�^�u�o�^�ς݂Ȃ牽�����Ȃ��v
                cbCarName.Items.Add(carName);

            }
        }



        private void btRecordAdd_Click(object sender, EventArgs e) {
            //�L���ҁA�Ԗ�������������Ȃ������牺�̕�������
            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
                tsslbMessage.Text = "�L�^�ҁA�܂��͎Ԗ��������͂ł�";
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
            setCbAuthor(cbAuthor.Text);//�R���{�{�b�N�X�֓o�^
            setCbCarName(cbCarName.Text);
            InputItemAIICIear();//�o�^

        }
        //���͍��ڂ����ׂăN���A
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
                return MakerGroup.�g���^;
            } else if (rbhonda.Checked) {
                return MakerGroup.�z���_;
            } else if (rbSubaru.Checked) {
                return MakerGroup.�X�o��;

            } else if (rbsuzuki.Checked) {
                return MakerGroup.�X�Y�L;

            } else if (rbNinsan.Checked) {
                return MakerGroup.���Y;

            } else if (rbOther.Checked) {
                return MakerGroup.���̑�;
            } else {
                return MakerGroup.�Ȃ�;
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

        //�w�肵�����[�J�[�̃��W�I�{�^�����Z�b�g
        private void setRadioButtonMaker(MakerGroup targetMaker) {

            //rbToyota.Checked = false;
            //rbhonda.Checked = false;
            //rbSubaru.Checked = false;
            //rbsuzuki.Checked = false;
            //rbOther.Checked = false;

            switch (targetMaker) {
                case MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.�z���_:
                    rbhonda.Checked = true;
                    break;
                case MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.�X�Y�L:
                    rbsuzuki.Checked = true;
                    break;
                case MakerGroup.���̑�:
                    rbOther.Checked = true;
                    break;
                default:

                    rbOther.Checked = true;
                    break;

            }

        }
        // �V�K�ǉ��̃C�x���g�p���h��
        private void btNewRecord_Click(object sender, EventArgs e) {

            InputItemAIICIear();

        }

        // �C���{�^���̃C�x���g�p���h��
        private void btRecordModify_Click(object sender, EventArgs e) {
            if ((dguRecord.CurrentRow == null) ||
              (!dguRecord.CurrentRow.Selected)) return;


            //�ԈႢ
            //    if (dguRecord.CurrentRow == null) return;
            // var current = dguRecord.CurrentRow.DataBoundItem as CarReport;
            //  if (current == null) return;
            //  dguRecord.Refresh();
            //  InputItemAIICIear();
        }
        //�ԈႢ
        // �C���{�^���̃C�x���g�p���h��
        //  private void btRecordModify_Click(object sender, EventArgs e) {

        //     if (dguRecord.CurrentRow == null) return;
        //     var current = dguRecord.CurrentRow.DataBoundItem as CarReport;
        //     if (current == null) return;
        //    dguRecord.Refresh();

        //    InputItemAIICIear();
        //  }


        //�폜�{�^���̃C�x���g�p���h��
        private void btRecordDelete_Click(object sender, EventArgs e) {
            ///�J�[���|�[�g�Ǘ��p���X�g����
            ///�Y������f�[�^���폜����

            //       if (dguRecord.CurrentRow == null) return;
            //�I������Ă���C���f�b�N�X���擾
            //       int Index = dguRecord.CurrentRow.Index;

            //      if (Index >= 0 && Index < ListCarReports.Count) {
            //�폜�������C���f�b�N�X���w�肵�ă��X�g����폜
            //         ListCarReports.RemoveAt(Index);

            //����
            if ((dguRecord.CurrentRow == null)
            || (!dguRecord.CurrentRow.Selected)) return;
            //�I������Ă���C���f�b�N�X���擾
            int Index = dguRecord.CurrentRow.Index;
            //�폜�������C���f�b�N�X���w�肵�ă��X�g����폜
            ListCarReports.RemoveAt(Index);


            //�ԈႢ
            // if (dguRecord.CurrentRow == null) return;
            // var current = dguRecord.CurrentRow.DataBoundItem as CarReport;
            //  if (current == null) return;
            // ListCarReports.Remove(current);
            //  dguRecord.Refresh();

        }


        private void Form1_Load(object sender, EventArgs e) {
            InputItemAIICIear();

            //���݂ɐF��ݒ�i�f�[�^�O���b�h�r���[�j


            dguRecord.DefaultCellStyle.BackColor = Color.LightGray;

            dguRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            //�ݒ�t�@�C����ǂݍ��ݔw�i�F��ݒ�i�t�V���A�����j




        }

        private void �t�@�C��FToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }
        //���̃A�v���ɂ��Ă�I���������̃C�x���g�p���h��
        private void ���̃A�v���ɂ���ToolStripMenuItem_Click(object sender, EventArgs e) {
            fmVersion fmv = new fmVersion();
            fmv.ShowDialog();
        }

        private void Collar_Click(object sender, EventArgs e) {

            if (cdCollar.ShowDialog() == DialogResult.OK) {
                BackColor = cdCollar.Color;
                //�ݒ�t�@�C���֕ۑ�
                settings.MainFormBackColor = cdCollar.Color.ToArgb();//�w�i�F��ݒ�C���X�^���X�֐ݒ�




            }
        }

        //�t�@�C���I�[�v������
        private void reportOpenFile() {

            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //�t�V���A�����Ńo�C�i���`������荞��
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    using (FileStream fs = File.Open(
                        ofdPicFileOpen.FileName, FileMode.Open, FileAccess.Read)) {

                        ListCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dguRecord.DataSource = ListCarReports;

                        cbAuthor.Items.Clear();
                        //�R���{�{�b�N�X�ɓo�^
                        foreach (var report in ListCarReports) {
                            setCbAuthor(report.Author);
                            setCbCarName(report.CarName);

                        }

                    }

                }
                catch (Exception) {
                    tsslbMessage.Text = "�t�@�C���`�����Ⴂ�܂�";

                }

            }
        }



        //�t�@�C���Z�[�u����
        private void reportSaveFile() {
            if (sfdReportfilesave.ShowDialog() == DialogResult.OK) {
                try {
                    //�o�C�i���`���ŃV���A����
#pragma warning disable SYSLIB0011


                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011



                    using (FileStream fs = File.Open(
                        sfdReportfilesave.FileName, FileMode.Create)) {

                        bf.Serialize(fs, ListCarReports);

                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "�t�@�C�������o���G���[";
                    MessageBox.Show(ex.Message);//������̓I�ȃG���[���o��

                }
            }

        }

        private void �ۑ�ToolStripMenuItem_Click(object sender, EventArgs e) {
            reportSaveFile();
            try {
                reportSaveFile();
                tsslbMessage.Text = " �ۑ��ɐ������܂���";
            }
            catch (Exception ex) {

                tsslbMessage.Text = "�ۑ����ɃG���[���������܂���: " + ex.Message;

            }

        }

        private void �J��ToolStripMenuItem_Click(object sender, EventArgs e) {
            reportSaveFile();
        }




        //�t�H�[����������Ă΂��
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //�ݒ�t�@�C���֐F����ۑ����鏈���i�V���A�����j

            var colorSettings = new ColorSettings {
                //FormBackgroundColor
                MainFormBackColor = BackColor
            };


        }
    }
}
    






