using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;    //без этого не заработает, проверь, что у тебя это подключено 
                                                //и добавлено в ссылки(я устанавливала дополнительно)



// если вдруг ты очень захочешь, можно сделать защиту от инъекций sql  и эта красненькая фигня об обязательности


namespace Talon
{
    public partial class Form1 : Form
    {
        private readonly string TalonFileName = @"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Talon.docx"; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //наши поля талона,которые названы как в шаблоне
            var patient = txt_patient.Text;
            var speciality = txt_speciality.Text;
            var doctor = txt_doctor.Text;
            var office = txt_office.Text;
            var date = dateTimePicker.Value.ToShortDateString();
            var time = txt_time.Text;

            var day = dateTimePicker.Value.Day;
            var month = dateTimePicker.Value.Month;
            var year = dateTimePicker.Value.Year;

            var localtime = DateTime.Now;
            if (localtime.Year > year || localtime.Month > month || localtime.Day > day)
            {
                MessageBox.Show("Машины времени не существует!");
            }

            var wordApp = new Word.Application();
            wordApp.Visible = false;  //чтобы не видеть мигающий ворд при печати

            try
            {
                var wordDocument = wordApp.Documents.Open(TalonFileName); //открываем для вставки данных в шаблон
                ReplaceWordStub("{patient}", patient, wordDocument);
                ReplaceWordStub("{speciality}", speciality, wordDocument);
                ReplaceWordStub("{doctor}", doctor, wordDocument);
                ReplaceWordStub("{office}", office, wordDocument);
                ReplaceWordStub("{date}", date, wordDocument);
                ReplaceWordStub("{time}", time, wordDocument);

                wordDocument.SaveAs(@"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Result.docx");
                //я какашка и у меня нет ворда, поэтому у меня это не работает
                //wordApp.Visible = true; //если хотим, чтобы нам еще и открылся вордовский файл
                wordDocument.Close(); //если хотим сами потом залезть в проект и открыть,а то у меня винда виснет при ворде, на которого нет лицензии, видосиками и вижлой
            }
            catch
            {
                MessageBox.Show("Все по женской линии пошло!");
            }
            finally
            {
                wordApp.Quit();
            }

            txt_patient.Clear();
            txt_speciality.Clear();
            txt_doctor.Clear();
            txt_office.Clear();
            txt_time.Clear();
        }

        //функция для замены в шаблоне
        private void ReplaceWordStub(string StubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content; //область,где мы будем что-то вставлять, в нашем случае - весь документ
            range.Find.ClearFormatting();  //очищаем предыдущие поиски в документе
            range.Find.Execute(FindText: StubToReplace, ReplaceWith: text); //меняем в шаблоне на нужное нам
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
