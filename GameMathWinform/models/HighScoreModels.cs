using GameMathWinform.tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMathWinform.models
{
    public class HighScoreModels
    {
        const int topCount = 10;
        public List<Player> highScores { get; set; }

        public HighScoreModels()
        {
        }
        private string GetFilePath()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string directoryPath = Path.Combine(appDataPath, "GameMathWinform");
            string filePath = Path.Combine(directoryPath, "HighScore.json");

            // Kiểm tra và tạo thư mục nếu chưa tồn tại
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            return filePath;
        }

        public bool CheckScore(int Score)
        {
            if (!TryReadFromJsonFile())
            {
                return false;
            }
            return this.highScores.Any(x => x.Score < Score) || this.highScores.Count<topCount;
        }

        public bool TryReadFromJsonFile()
        {
            try
            {
                string filePath = GetFilePath();
                var directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                if (!File.Exists(filePath))
                {
                    // Nếu tệp không tồn tại, tạo tệp mới và lưu danh sách rỗng
                    File.WriteAllText(filePath, JsonConvert.SerializeObject(new List<Player>(), Formatting.Indented));
                    return true;
                }

                string jsonData = File.ReadAllText(filePath);
                highScores = JsonConvert.DeserializeObject<List<Player>>(jsonData);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool WriteToJsonFile()
        {
            try
            {
                string filePath = GetFilePath();
                FilePermission.SetFolderPermissions(filePath);
                string jsonData = JsonConvert.SerializeObject(this.highScores, Formatting.Indented);
                File.WriteAllText(filePath, jsonData);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public List<Player> GetTopPlayers()
        {
            return this.highScores.OrderByDescending(p => p.Score).Take(topCount).ToList();
        }


        public void AddTopPlayer(string playerName, int Score)
        {
            Player player = new Player();
            player.Name = playerName;
            player.Score = Score;

            this.highScores.Add(player);
            this.highScores = GetTopPlayers();

            if (!WriteToJsonFile())
            {
                MessageBox.Show("Có lỗi khi thêm điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
