using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VaderConsulting.Database;

namespace SCSMEnumValues
{
    public partial class frmMain : Form
    {
        private SQLServer _SQL = new SQLServer(20);

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            _SQL.ConnectionString = "Server=" + txtServer.Text + ";Database=ServiceManager;Trusted_Connection=true;";
            _SQL.OpenConnection();
            string Query = "SELECT DISTINCT EnumTypeId, l.LTValue FROM EnumType e left join LocalizedText l ON l.MPElementId = e.EnumTypeId WHERE l.LanguageCode = 'ENU' ORDER BY l.LTValue";

            lstEnums.Items.Clear();

            DataTable Enums = _SQL.Execute(Query);

            foreach (DataRow Row in Enums.Rows)
            {
                lstEnums.Items.Add(Row[1].ToString());
            }
            
        }

        private void lstEnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Enums = null;

            if (lstEnums.SelectedItem != null)
            {
                string Query = txtQuery.Text.Replace("#SELECTEDITEM#", lstEnums.SelectedItem.ToString()).Trim();

                if (rbSimpleList.Checked)
                {
                    Enums = _SQL.Execute(Query);
                }

                dgvResults.DataSource = Enums;

                /*dgvResults.Width = dgvResults.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                                   + (dgvResults.RowHeadersVisible ? dgvResults.RowHeadersWidth : 0) + 3; */
            }
        }

        private void rbSimpleList_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSimpleList.Checked)
            {
                txtQuery.Text = "SELECT DISTINCT EnumTypeId, l.LTValue, e.ManagementPackID, e.EnumTypeName, Ordinal FROM EnumType e left join LocalizedText l ON l.MPElementId = e.EnumTypeId WHERE l.LanguageCode = 'ENU' AND l.LTvalue = '#SELECTEDITEM#' ORDER BY l.LTValue";
            }
        }

        private void rbRecursiveList_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRecursiveList.Checked)
            {
                txtQuery.Text = "SELECT DISTINCT EnumTypeId, l.LTValue, e.ManagementPackID, e.EnumTypeName, Ordinal FROM EnumType e left join LocalizedText l ON l.MPElementId = e.EnumTypeId WHERE l.LanguageCode = 'ENU' AND l.LTvalue = '#SELECTEDITEM#' ORDER BY l.LTValue";
            }
        }
    }
}
