using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMathWinform.Forms
{
    public class InputDialog : Form
    {
        private TextBox textBox;
        private Button okButton;
        private Button cancelButton;
        private Label label;

        public string InputText
        {
            get { return textBox.Text; }
        }

        public InputDialog(string prompt,string title)
        {
            label = new Label { Left = 10, Top = 10, Text = prompt, AutoSize = true };
            textBox = new TextBox { Left = 10, Top = 30, Width = 400 };
            okButton = new Button { Text = "OK", Left = 250, Width = 80, Top = 60, DialogResult = DialogResult.OK };
            cancelButton = new Button { Text = "Cancel", Left = 330, Width = 80, Top = 60, DialogResult = DialogResult.Cancel };

            okButton.Click += (sender, e) => { this.DialogResult = DialogResult.OK; this.Close(); };
            cancelButton.Click += (sender, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.Add(label);
            this.Controls.Add(textBox);
            this.Controls.Add(okButton);
            this.Controls.Add(cancelButton);

            this.Text = title;

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ClientSize = new System.Drawing.Size(420, 100);
        }

        public static string Show(string prompt, string title)
        {
            using (var dialog = new InputDialog(prompt, title))
            {
                return dialog.ShowDialog() == DialogResult.OK ? dialog.InputText : null;
            }
        }
    }
}
