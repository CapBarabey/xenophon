using System.Globalization;
using System.Windows.Forms;

namespace xenophon.Controllers
{
    internal class BookController
    {
        public object Total(DataGridView pageGrid)
        {
            var total = new Dictionary<string, int>()
            {
                ["Month"] = 0,
                ["Year"] = 0
            };

            for (int i = 1; i < pageGrid.ColumnCount - 2; i++)
            {
                for (int j = 0; j < pageGrid.RowCount - 2; j++)
                {
                    total["Month"] += Convert.ToInt32(pageGrid.Rows[j].Cells[i].Value);
                }
                pageGrid.Rows[^2].Cells[i].Value = total["Month"];
            }

            for (int i = 0; i < pageGrid.RowCount - 2; i++)
            {
                for (int j = 1; j < pageGrid.ColumnCount - 2; j++)
                {
                    total["Year"] += Convert.ToInt32(pageGrid.Rows[i].Cells[j].Value);
                }

                pageGrid.Rows[i].Cells[^2].Value = total["Year"];
            }

            return total;
        }
    }
}
