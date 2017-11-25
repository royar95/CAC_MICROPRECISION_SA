using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Controller;

namespace CACMicropresicion.View.Cients
{
    public partial class ClientsList : UserControl
    {
        ClientsController controller = new ClientsController();   
        public ClientsList()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        private void ClientsList_Load(object sender, EventArgs e)
        {
            var result = controller.populateClientsList();

            dataGridViewClients.DataSource = result["content"];
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var result = controller.populateClientsList();

            dataGridViewClients.DataSource = result["content"];
        }
    }
}
