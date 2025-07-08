using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaReportSystem
{
    public partial class fmVersion : Form {
        public fmVersion() {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e) {


            Close();

        }

        private void fmVersion_Load(object sender, EventArgs e) {
            var asm = Assembly.GetExecutingAssembly();
            var version = asm.GetName().Verion;
            lbVersion.Text = string.Format($"{version.major}.{version.major}.{version.Build}.{version.Revision}");

        }
    }
}
