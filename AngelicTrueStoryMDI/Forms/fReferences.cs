using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ModelDB;

namespace AngelicTrueStory
{
    public partial class fReferences : Form
    {
        public fReferences()
        {
            InitializeComponent();
        }

        private void fReferences_Load(object sender, EventArgs e)
        {
            DBEntities db = new DBEntities();
            BindingSource bs = new BindingSource();

            //db.sActivity.Include(x => x.sActivityType).Load();
            db.sActivity.Load();
            this.sActivityBindingSource.DataSource = db.sActivity.Local.ToBindingList(); 
            //db.sActivityType.Where(x=> x == x).Load();
            //bs.DataSource = db.sActivityType.Local.ToBindingList(); 
            //dataGridView2.DataSource = bs;
        }

        private void sActivityBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
