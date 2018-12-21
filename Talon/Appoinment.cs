using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace Talon
{
    public partial class Appoinment : Form
    {
        private readonly string AppointmentFileName = @"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Appointment.docx";
        public Appoinment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //наши поля талона,которые названы как в шаблоне
            var speciality = txt_speciality.Text;
            var name = txt_name.Text;
            var diagnosis = txt_diagnosis.Text;
            var therapy = txt_therapy.Text;

            var date = DateTime.Now;

            var wordApp = new Word.Application();
            wordApp.Visible = false;  //чтобы не видеть мигающий ворд при печати

            try
            {
                var wordDocument = wordApp.Documents.Open(AppointmentFileName); //открываем для вставки данных в шаблон
                ReplaceWordStub("{speciality}", speciality, wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{diagnosis}", diagnosis, wordDocument);
                ReplaceWordStub("{therapy}", therapy, wordDocument);
                ReplaceWordStub("{date}", date.ToShortDateString() , wordDocument);

              

                //надо найти карту нашего пациента, есть вариант написать для этого функцию поиска этой сраной карты
               // var Card = wordApp.Documents.Open(тут блин надо открыть эту женскую линию);
                //Card.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak); //вставим следующую страницу
                //Card.Words.Last.InsertFile (ref на нашу картуя)

                //wordDocument.SaveAs(@"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\print here surname and name.docx");
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
        }

        //функция для замены в шаблоне
        private void ReplaceWordStub(string StubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content; //область,где мы будем что-то вставлять, в нашем случае - весь документ
            range.Find.ClearFormatting();  //очищаем предыдущие поиски в документе
            range.Find.Execute(FindText: StubToReplace, ReplaceWith: text); //меняем в шаблоне на нужное нам
        }
    }
}
