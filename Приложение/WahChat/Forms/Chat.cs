using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WahChat
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();

            NetworkService.GetSharedService().chatBox = this.chatBox; //Отправленные
            NetworkService.GetSharedService().chatInBox = this.chatInbox; //Входящие

            this.usernameLabel.Text = String.Format("Подключен как \"{0}\"", NetworkService.GetSharedService().currentSession.username);
            this.chatBox.SelectionMode = SelectionMode.None;
            this.chatInbox.SelectionMode = SelectionMode.None;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = messageBox.Text;
            NetworkService.GetSharedService().SendMessage(message);

            messageBox.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            NetworkService.GetSharedService().CloseConnection();
        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнена в рамках курса \"Сетеввые технологии в АСОИУ\"\nИсполнители:\tКрротенко Е.А. ИУ5Ц-81Б\n\t\tПылаев Б.А. ИУ5Ц-82Б\n\t\tЧиварзин А.Е. ИУ5Ц-82Б\nПреподаватель:\tГалкин В.А.", "Разработка");
        }
    }
}
