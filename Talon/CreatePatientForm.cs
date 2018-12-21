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
    public partial class CreatePatientForm : Form
    {
        private readonly string TitulnicFileName = @"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Titulnic.docx";
        public CreatePatientForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //наши поля талона,которые названы как в шаблоне
            var surname = txt_surname.Text;
            var name = txt_name.Text;
            var patronymic = txt_patronymic.Text;
            var office = txt_office.Text;
            var birthday = dateTimePicker1.Value.ToShortDateString();
            var address = txt_address.Text;

            var date = DateTime.Now;

            var wordApp = new Word.Application();
            wordApp.Visible = false;  //чтобы не видеть мигающий ворд при печати

            try
            {
                var wordDocument = wordApp.Documents.Open(TitulnicFileName); //открываем для вставки данных в шаблон
                ReplaceWordStub("{surname}", surname, wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{patronymic}", patronymic, wordDocument);
                ReplaceWordStub("{office_number}", office, wordDocument);
                ReplaceWordStub("{birthday}", birthday, wordDocument);
                ReplaceWordStub("{address}", address, wordDocument);
                ReplaceWordStub("{registration_date}", date.ToShortDateString() , wordDocument);

                wordDocument.SaveAs(@"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Cards\print here surname and name.docx");
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

            txt_surname.Clear();
            txt_name.Clear();
            txt_patronymic.Clear();
            txt_office.Clear();
            txt_address.Clear();

        }

        //функция для замены в шаблоне
        private void ReplaceWordStub(string StubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content; //область,где мы будем что-то вставлять, в нашем случае - весь документ
            range.Find.ClearFormatting();  //очищаем предыдущие поиски в документе
            range.Find.Execute(FindText: StubToReplace, ReplaceWith: text); //меняем в шаблоне на нужное нам
        }

        private void CreatePatientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
