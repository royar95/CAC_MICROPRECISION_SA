using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.Providers
{
    public partial class ViewProviders : UserControl
    {
        public ViewProviders()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
        }

        public void loadDataGrid(Object list)
        {
            this.dtViewProviders.DataSource = list;
        }

        private void changeHeadersText()
        {
            this.dtViewProviders.Columns[0].HeaderText = "ID";
            this.dtViewProviders.Columns[1].HeaderText = "Proveedor";
            this.dtViewProviders.Columns[2].HeaderText = "Eliminado";
        }
        }
}
