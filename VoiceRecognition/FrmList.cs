using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceRecognition
{
    public partial class FrmList : Form
    {
        public void addData(string _data)
        {
            this.lb_process.Items.Add(_data);
        }
        public void clearCommand()
        { 
            this.lb_process.Items.Clear();
        }

        public FrmList()
        {
            InitializeComponent();
        }

        private void FrmList_Load(object sender, EventArgs e)
        {

        }
      
        private void lb_process_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
