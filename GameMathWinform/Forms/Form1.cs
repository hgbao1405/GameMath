using GameMathWinform.Forms;
using GameMathWinform.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMathWinform
{
    public partial class Form1 : Form
    {
        private Game game;
        const int GameTime = 5;

        public Form1()
        {
            game = new Game(GameTime);
            InitializeComponent();
            txt_Thongbao.Text = "";
            generatingQuestion();
        }

        public void generatingQuestion()
        {
            lbl_debai.Text = game.generateQuestion().ShowCauhoi();
            lbl_level.Text = $"Level: {game.level}";
            lbl_point.Text = $"Điểm: {game.score}";
            lbl_time.Text = $"Lượt chơi: {game.time}";
            txt_cautraloi.Text = "";
            txt_cautraloi.Focus();
        }

        private void TraLoi(object sender, EventArgs e)
        {
            int dapan;
            if(int.TryParse(txt_cautraloi.Text, out dapan))
            {
                if (game.question.IsCorrect(dapan)) {
                    game.addScore(game.level);
                    game.AddCorrect();
                    txt_Thongbao.Text = game.messCorrect();
                    txt_Thongbao.ForeColor = Color.Green;
                }
                else
                {
                    game.minusTime();
                    txt_Thongbao.Text = game.messNotCorrect();
                    txt_Thongbao.ForeColor = Color.Red;
                }
                if (game.isLosing())
                {
                    //Kiểm tra điểm cao vào thêm vào top người chơi nếu muốn
                    HighScoreModels highScore = new HighScoreModels();
                    if (highScore.CheckScore(game.score))
                    {
                        string result = InputDialog.Show("Hãy nhập tên của bạn:","Bạn đạt điểm cao");
                        if (result != null)
                        {
                            highScore.AddTopPlayer(result, game.score);
                        }
                    }
                    //thông báo hết lượt chơi, đề nghị chơi tiếp
                    DialogResult r= MessageBox.Show("Bạn đã hết lượt chơi, bạn có muốn chơi lại không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (r == DialogResult.OK)
                    {
                        game = new Game(GameTime);
                        txt_Thongbao.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }
                }
                generatingQuestion();
            }
            txt_cautraloi.Focus();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txt_cautraloi_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TraLoi(sender, e);
            }
        }

        private void lbl_newGame_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn chơi lại?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                game = new Game(GameTime);
                txt_Thongbao.Text = "";
                generatingQuestion();
            }
        }

        private void link_lbl_highScore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                HighScore highScore = new HighScore();
                highScore.Show();
            }
            catch {
                
            }
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }
    }
}
