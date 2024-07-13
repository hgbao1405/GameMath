using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMathWinform.tools
{
    public class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            // Cấu hình kiểu dáng và màu sắc của DataGridView
            this.Dock = DockStyle.Fill;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.DefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.ForeColor = Color.Black;
            this.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            this.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.RowTemplate.Height = 30;
            this.RowHeadersVisible = false;

            // Tạo hiệu ứng hover cho các hàng
            this.RowsDefaultCellStyle.BackColor = Color.White;
            this.RowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Cấu hình viền của các ô
            this.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.RowTemplate.Height = 40;
            this.EnableHeadersVisualStyles = false;
        }
    }
}
