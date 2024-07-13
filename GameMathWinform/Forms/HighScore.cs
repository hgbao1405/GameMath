using GameMathWinform.models;
using GameMathWinform.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMathWinform.Forms
{
    public partial class HighScore : Form
    {
        private HighScoreModels highScore;

        private CustomDataGridView customDataGridView;
        public HighScore()
        {
            InitializeComponent();
            highScore = new HighScoreModels();
            if (!highScore.TryReadFromJsonFile())
            {
                DialogResult r = MessageBox.Show("Có lỗi khi đọc dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (r == DialogResult.OK)
                {
                    this.Close();
                }
            }
            customDataGridView = new CustomDataGridView();
            this.Controls.Add(customDataGridView);

            customDataGridView.DataSource= highScore.GetTopPlayers();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
