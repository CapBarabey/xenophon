using System.Globalization;
using System.Windows.Forms;

namespace xenophon.Controllers
{
    internal class BookController
    {
        public object Total(DataGridView pageGrid)
        {
            var total = new Dictionary<string, float>()
            {
                ["Month"] = 0.0f,
                ["Year"] = 0.0f
            };

            for (int i = 1; i < pageGrid.ColumnCount - 2; i++)
            {
                for (int j = 0; j < pageGrid.RowCount - 2; j++)
                {
                    total["Month"] += float.Parse(pageGrid.Rows[j].Cells[i].Value.ToString() + "0", CultureInfo.InvariantCulture.NumberFormat);
                }
                pageGrid.Rows[^2].Cells[i].Value = total["Year"];
            }

            for (int i = 0; i < pageGrid.RowCount - 2; i++)
            {
                for (int j = 1; j < pageGrid.ColumnCount - 2; j++)
                {
                    total["Year"] += float.Parse(pageGrid.Rows[i].Cells[j].Value.ToString() + "0", CultureInfo.InvariantCulture.NumberFormat);
                }

                pageGrid.Rows[^2].Cells[i].Value = total["Month"];
            }

            return total;
        }
    }
}
