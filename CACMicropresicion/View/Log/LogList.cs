using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.Log
{
    public partial class LogList : UserControl
    {
        public LogList()
        {
            InitializeComponent();
            this.Location = new Point(237, 50);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        public void loadDataGrid(Object list)
        {
            this.dbLogs.DataSource = list;
            changeHeadersText();
            //setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText()
        {
            this.dbLogs.Columns[0].HeaderText = "Fecha";
            this.dbLogs.Columns[1].HeaderText = "Acción";
            this.dbLogs.Columns[2].HeaderText = "Tabla";
            this.dbLogs.Columns[3].HeaderText = "Contenido Nuevo";
            this.dbLogs.Columns[4].HeaderText = "Contenido Antiguo";
            this.dbLogs.Columns[5].HeaderText = "Usuario";
        }

        private void setColumnsSize()
        {
            this.dbLogs.Columns[0].Width = 180;
            this.dbLogs.Columns[1].Width = 100;
            this.dbLogs.Columns[2].Width = 200;
            this.dbLogs.Columns[3].Width = 200;
            this.dbLogs.Columns[4].Width = 200;
            this.dbLogs.Columns[5].Width = 100;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dbLogs.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

    }
}
