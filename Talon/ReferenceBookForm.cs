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
    public partial class ReferenceBookForm : Form
    {
        private readonly string ReferenceBookFileName = @"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Reference Book example.docx";
        public ReferenceBookForm()
        {
            InitializeComponent();
        }

        private void ReferenceBookForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //наши поля талона,которые названы как в шаблоне
            var diagnosis = txt_diagnosis.Text;
            var comment = txt_comment.Text;

            var wordApp = new Word.Application();
            wordApp.Visible = false;  //чтобы не видеть мигающий ворд при печати

            try
            {
                var wordDocument = wordApp.Documents.Open(ReferenceBookFileName); //открываем для вставки данных в шаблон
                ReplaceWordStub("{diagnosis}", diagnosis, wordDocument);
                ReplaceWordStub("{comment}", comment, wordDocument);
                wordDocument.SaveAs(@"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Reference_tmp.docx");
                wordDocument.Close();

                //тут надо создать переменную для индентификатора, чтобы открывать нужную карту
                var bookDocument = wordApp.Documents.Open(@"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Referense Book.docx");
                bookDocument.Words.Last.InsertParagraph(); 
                bookDocument.Words.Last.InsertFile(@"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Reference_tmp.docx");
                bookDocument.Close();
            }
            catch
            {
                MessageBox.Show("Все по женской линии пошло!");
            }
            finally
            {
                wordApp.Quit();
            }

            txt_diagnosis.Clear();
            txt_comment.Clear();
        }

        private void ReplaceWordStub(string StubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content; //область,где мы будем что-то вставлять, в нашем случае - весь документ
            range.Find.ClearFormatting();  //очищаем предыдущие поиски в документе
            range.Find.Execute(FindText: StubToReplace, ReplaceWith: text); //меняем в шаблоне на нужное нам
        }

    }
}
