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


            {"主要","https://news.yahoo.co.jp/rss/topics/top-picks.xml"},
            {"国内","https://news.yahoo.co.jp/rss/topics/domestic.xml"},
            {"国際","https://news.yahoo.co.jp/rss/topics/world.xml"},
            {"経済","https://news.yahoo.co.jp/rss/topics/business.xml"},
            {"エンタメ","https://news.yahoo.co.jp/rss/topics/entertainment.xml"},
            {"スポーツ","https://news.yahoo.co.jp/rss/topics/sports.xml"},
            {"IT","https://news.yahoo.co.jp/rss/topics/it.xml"},
            {"科学","https://news.yahoo.co.jp/rss/topics/science.xml"},
            { "地域","https://news.yahoo.co.jp/rss/topics/local.xml"},

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
                // XDocument xdoc = XDocument.Load(url); //RSSの取得
                // XDocument xdoc = client
                //RSSを分析して必要な要素を取得
                var items = xdoc.Root.Descendants("item").
                        Select(x => new ItemData {
                            Title = (string?)x.Element("title"),
                            Link = (string?)x.Element("Link"),


                        }).ToList();
                //リストボックスへスタイルを表示
                lbTitles.Items.Clear();
                foreach (var item in items) {
                    lbTitles.Items.Add(item.Title ?? "データーなし");


                }
            }
        }//コンボボックスの文字列をチェックしてアクセス可能なURLを返却する
        private string getRssUrl(string str) {

            if (rssUrDict.ContainsKey(str)) {
                return rssUrDict[str];
            }
            return str;

        }

        //  タイトルを選択（クリック）したときに呼ばれるイベントハンドラ
        private void lbTitles_Click(object sender, EventArgs e) {
            var selectItem = lbTitles.SelectedItem;
            foreach (var item in items) {
                if (item.Title == selectItem)

                    wvRssLink.Source = new Uri(item.Link);
            }
        }
        //進める
        private void button2_Click(object sender, EventArgs e) {

            wvRssLink.GoForward();
        }
        //戻る
        private void btGoBack_Click(object sender, EventArgs e) {

            wvRssLink.GoBack();

        }

        private void btnAddFavorite_Click(object sender, EventArgs e) {


            //  btnAddFavorite data = (btnAddFavorite)


            btnAddFavorite.Text = "お気に入り済";



        }

        private void tbURL_TextChanged(object sender, EventArgs e) {

        }
    }

}


    

        
    




