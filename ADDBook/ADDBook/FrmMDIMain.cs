using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADDBook
{
    public partial class FrmMDIMain : Form
    {
        FrmListView addrbook = new FrmListView();
        FrmDataGridView frmgrid = new FrmDataGridView();
        FrmCalc frmcalc = new FrmCalc();
        FrmLogViewer frmlogviewer = new FrmLogViewer();
        FrmCrawler frmCrawler = new FrmCrawler();

        public FrmMDIMain()
        {
            InitializeComponent();
        }
    }
}
