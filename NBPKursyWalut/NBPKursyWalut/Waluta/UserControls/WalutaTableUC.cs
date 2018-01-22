using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NBPKursyWalut.Data.Defs;

namespace NBPKursyWalut.Waluta.UserControls
{
    public partial class WalutaTableUC : UserControl
    {
        public WalutaTableUC(DataSet p_dataSet)
        {
            InitializeComponent();
            
            TabelaWalutaDGV.DataSource = p_dataSet.Tables[2];
            SetColumnNanmes(p_dataSet, p_dataSet.Tables[0].Rows[0]["Table"]);
            TabelaWalutaDGV.Refresh();
        }

        private void SetColumnNanmes(DataSet p_dataSet, object p_tableName)
        {
            if (Convert.ToString(p_tableName) == "A" || Convert.ToString(p_tableName) == "B")
            {
                p_dataSet.Tables[2].Columns["Currency"].ColumnName = TableABColumns.Currency;
                p_dataSet.Tables[2].Columns["Code"].ColumnName = TableABColumns.Code;
                p_dataSet.Tables[2].Columns["Mid"].ColumnName = TableABColumns.Mid;
            }
            else if (Convert.ToString(p_tableName) == "C")
            {
                p_dataSet.Tables[2].Columns["Currency"].ColumnName = TableCColumns.Currency;
                p_dataSet.Tables[2].Columns["Code"].ColumnName = TableCColumns.Code;
                p_dataSet.Tables[2].Columns["Bid"].ColumnName = TableCColumns.Bid;
                p_dataSet.Tables[2].Columns["Ask"].ColumnName = TableCColumns.Ask;
            }
        }
    }
}