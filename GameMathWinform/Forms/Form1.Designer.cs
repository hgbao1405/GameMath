namespace GameMathWinform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_level = new System.Windows.Forms.Label();
            this.txt_Thongbao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_debai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_cautraloi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_point = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_lbl_highScore = new System.Windows.Forms.LinkLabel();
            this.link_lbl_newGame = new System.Windows.Forms.LinkLabel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(this.lbl_level, 0, 3);
            tableLayoutPanel1.Controls.Add(this.txt_Thongbao, 1, 2);
            tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            tableLayoutPanel1.Controls.Add(this.lbl_debai, 1, 0);
            tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new System.Drawing.Size(763, 385);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.Location = new System.Drawing.Point(3, 348);
            this.lbl_level.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(173, 29);
            this.lbl_level.TabIndex = 9;
            this.lbl_level.Text = "Level:";
            // 
            // txt_Thongbao
            // 
            this.txt_Thongbao.AutoSize = true;
            this.txt_Thongbao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Thongbao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Thongbao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Thongbao.Location = new System.Drawing.Point(182, 85);
            this.txt_Thongbao.Margin = new System.Windows.Forms.Padding(3);
            this.txt_Thongbao.Name = "txt_Thongbao";
            this.txt_Thongbao.Size = new System.Drawing.Size(578, 257);
            this.txt_Thongbao.TabIndex = 6;
            this.txt_Thongbao.Text = "Bạn làm đúng 1 câu";
            this.txt_Thongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập đáp án:";
            // 
            // lbl_debai
            // 
            this.lbl_debai.AutoSize = true;
            this.lbl_debai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_debai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_debai.Location = new System.Drawing.Point(182, 3);
            this.lbl_debai.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_debai.Name = "lbl_debai";
            this.lbl_debai.Size = new System.Drawing.Size(578, 34);
            this.lbl_debai.TabIndex = 2;
            this.lbl_debai.Text = "axb=?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đề bài:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.21782F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.78218F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_cautraloi, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(182, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(578, 36);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(455, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "trả lời";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TraLoi);
            // 
            // txt_cautraloi
            // 
            this.txt_cautraloi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cautraloi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_cautraloi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cautraloi.Location = new System.Drawing.Point(3, 3);
            this.txt_cautraloi.Name = "txt_cautraloi";
            this.txt_cautraloi.Size = new System.Drawing.Size(446, 28);
            this.txt_cautraloi.TabIndex = 1;
            this.txt_cautraloi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cautraloi_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.91695F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.08305F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_time, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_point, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(182, 348);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 34);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(383, 3);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(192, 28);
            this.lbl_time.TabIndex = 10;
            this.lbl_time.Text = "Lượt chơi:";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_point.Location = new System.Drawing.Point(3, 3);
            this.lbl_point.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(374, 28);
            this.lbl_point.TabIndex = 9;
            this.lbl_point.Text = "Điểm:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.link_lbl_highScore);
            this.panel1.Controls.Add(this.link_lbl_newGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 22);
            this.panel1.TabIndex = 1;
            // 
            // link_lbl_highScore
            // 
            this.link_lbl_highScore.AutoSize = true;
            this.link_lbl_highScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.link_lbl_highScore.LinkColor = System.Drawing.Color.Black;
            this.link_lbl_highScore.Location = new System.Drawing.Point(74, 0);
            this.link_lbl_highScore.Name = "link_lbl_highScore";
            this.link_lbl_highScore.Size = new System.Drawing.Size(74, 16);
            this.link_lbl_highScore.TabIndex = 3;
            this.link_lbl_highScore.TabStop = true;
            this.link_lbl_highScore.Text = "High Score";
            this.link_lbl_highScore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_highScore_LinkClicked);
            // 
            // link_lbl_newGame
            // 
            this.link_lbl_newGame.AutoSize = true;
            this.link_lbl_newGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.link_lbl_newGame.LinkColor = System.Drawing.Color.Black;
            this.link_lbl_newGame.Location = new System.Drawing.Point(0, 0);
            this.link_lbl_newGame.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.link_lbl_newGame.Name = "link_lbl_newGame";
            this.link_lbl_newGame.Size = new System.Drawing.Size(74, 16);
            this.link_lbl_newGame.TabIndex = 2;
            this.link_lbl_newGame.TabStop = true;
            this.link_lbl_newGame.Text = "New Game";
            this.link_lbl_newGame.Click += new System.EventHandler(this.lbl_newGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(763, 407);
            this.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(781, 415);
            this.Name = "Form1";
            this.Text = "Math Game";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_Thongbao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_debai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_cautraloi;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel link_lbl_newGame;
        private System.Windows.Forms.LinkLabel link_lbl_highScore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_point;
    }
}

