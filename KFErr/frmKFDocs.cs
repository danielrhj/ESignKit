using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CostErrDeal.KFErr
{
    public partial class frmKFDocs : Form
    {
        public frmKFDocs()
        {
            InitializeComponent();
            this.linkLabel1.Links.Add(0, 12, "www.logistics.foxconn.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}
