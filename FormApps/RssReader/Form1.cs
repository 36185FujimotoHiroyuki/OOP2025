using System.Drawing.Text;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace RssReader {
    public partial class btGobak : Form {

        private List<ItemData> items;


        Dictionary<string, string> rssUrDict = new Dictionary<string, string>() {


            {"��v","https://news.yahoo.co.jp/rss/topics/top-picks.xml"},
            {"����","https://news.yahoo.co.jp/rss/topics/domestic.xml"},
            {"����","https://news.yahoo.co.jp/rss/topics/world.xml"},
            {"�o��","https://news.yahoo.co.jp/rss/topics/business.xml"},
            {"�G���^��","https://news.yahoo.co.jp/rss/topics/entertainment.xml"},
            {"�X�|�[�c","https://news.yahoo.co.jp/rss/topics/sports.xml"},
            {"IT","https://news.yahoo.co.jp/rss/topics/it.xml"},
            {"�Ȋw","https://news.yahoo.co.jp/rss/topics/science.xml"},
            { "�n��","https://news.yahoo.co.jp/rss/topics/local.xml"},

        };
        public btGobak() {
            InitializeComponent();
        }

        private async void btRssGet_Click(object sender, EventArgs e) {

            cbUrl.DataSource = rssUrDict.Select(k => k.Key).ToList();
            GoFowardBtEnableSet();





            using (var hc = new HttpClient()) {


                string xml = await hc.GetStringAsync(tbURL.Text);
                XDocument xdoc = XDocument.Parse(xml);

                //  var url = hc.OpenRead(tbURL.Text);
                // XDocument xdoc = XDocument.Load(url); //RSS�̎擾
                // XDocument xdoc = client
                //RSS�𕪐͂��ĕK�v�ȗv�f���擾
                var items = xdoc.Root.Descendants("item").
                        Select(x => new ItemData {
                            Title = (string?)x.Element("title"),
                            Link = (string?)x.Element("Link"),


                        }).ToList();
                //���X�g�{�b�N�X�փX�^�C����\��
                lbTitles.Items.Clear();
                foreach (var item in items) {
                    lbTitles.Items.Add(item.Title ?? "�f�[�^�[�Ȃ�");


                }
            }
        }//�R���{�{�b�N�X�̕�������`�F�b�N���ăA�N�Z�X�\��URL��ԋp����
        private string getRssUrl(string str) {

            if (rssUrDict.ContainsKey(str)) {
                return rssUrDict[str];
            }
            return str;

        }

        //  �^�C�g����I���i�N���b�N�j�����Ƃ��ɌĂ΂��C�x���g�n���h��
        private void lbTitles_Click(object sender, EventArgs e) {
            var selectItem = lbTitles.SelectedItem;
            foreach (var item in items) {
                if (item.Title == selectItem)

                    wvRssLink.Source = new Uri(item.Link);
            }
        }
        //�i�߂�
        private void button2_Click(object sender, EventArgs e) {

            wvRssLink.GoForward();
        }
        //�߂�
        private void btGoBack_Click(object sender, EventArgs e) {

            wvRssLink.GoBack();

        }

        private void btnAddFavorite_Click(object sender, EventArgs e) {


            //  btnAddFavorite data = (btnAddFavorite)


            btnAddFavorite.Text = "���C�ɓ����";



        }

        private void tbURL_TextChanged(object sender, EventArgs e) {

        }
    }

}


    

        
    




