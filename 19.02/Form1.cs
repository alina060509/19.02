using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._02
{
    public partial class Form1 : Form
    {
        private Label _labelGender, _labelNews, _labelBirthDay, _labelMeeting;
        private RadioButton _radioMale, _radioFemale;
        private CheckBox _chekBoxNews;
        private DateTimePicker _dateTimePiker;
        private MonthCalendar _monthCalendar;
        private Button _buttonSudmit;
        private Label _resultLabel;

        public Form1()
        {
            this.Text = "анкетка пользователя";
            this.Size = new System.Drawing.Size(400, 500);
            //выбор пола
            _labelGender = new Label() { Text = "Выберите пол:", Location = new Point(20, 20) };
            _radioFemale = new RadioButton() { Text = "Женский", Checked = true, Location = new Point(20, 45) };
            _radioMale = new RadioButton() { Text = "Мужской", Location = new Point(125, 45) };

            //получение новостей
            _labelNews = new Label() { Text = "Хотите получать новости?)", Location = new Point(20,80), Width = 200};
            _chekBoxNews = new CheckBox() { Text = "да,очень хочу", Location = new Point(20, 100) };

            //Дата рождения
            _labelBirthDay = new Label() {Text = "Выберите свою дату рождения:", Location = new Point(20, 135), Width = 200 };
            _dateTimePiker = new DateTimePicker() { Location = new Point(20, 160), Format = DateTimePickerFormat.Short };

            //выбор дня встречи
            _labelMeeting = new Label() { Text = "Выберите день встречи:", Location = new Point(20, 200), Width = 200 };
            _monthCalendar = new MonthCalendar() { Location = new Point(20, 225) };

            //кнопка "отправить"
            _buttonSudmit = new Button() { Text = "отправить!", Location = new Point(20,400) };
            _buttonSudmit.Click += (s, e) => Result();

            //результат
            _resultLabel = new Label() { Location = new Point(100, 400), Size = new Size(400, 100) };




            Controls.Add(_labelGender);
            Controls.Add(_radioFemale);
            Controls.Add(_radioMale);
            Controls.Add(_labelNews);
            Controls.Add(_chekBoxNews);
            Controls.Add (_labelBirthDay);
            Controls.Add(_dateTimePiker);
            Controls.Add(_labelMeeting);
            Controls.Add(_monthCalendar);
            Controls.Add(_buttonSudmit);
            Controls.Add(_resultLabel);

        }
        private void Result()
        {
            string gender = _radioFemale.Checked ? "Женский" : "Мужской";
            string news = _chekBoxNews.Checked ? "Подписан на новости" : "Не подписан на новости";
            string birthday = _dateTimePiker.Value.ToShortDateString();
            string meetingdate = _monthCalendar.SelectionStart.ToShortDateString();
            _resultLabel.Text = $"Пол:{gender}\n" +
                $"{news}\n" +
                $"Дата рождения:{birthday}\n" +
                $"Встреча: {meetingdate}";

        }
      
    }
}
