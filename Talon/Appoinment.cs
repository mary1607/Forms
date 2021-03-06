﻿using System;
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
                ReplaceWordStub("{date}", date.ToShortDateString(), wordDocument);
                wordDocument.SaveAs(@"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Cards\Appointment_result.docx");
                wordDocument.Close();

                //тут надо создать переменную для индентификатора, чтобы открывать нужную карту
                var cardDocument = wordApp.Documents.Open(@"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Cards\print here id.docx");
                cardDocument.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak); //вставим следующую страницу
                cardDocument.Words.Last.InsertFile(@"C:\Users\Mary\Documents\Visual Studio 2015\Projects\Talon\Cards\Appointment_result.docx");
                cardDocument.Close();
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
            txt_therapy.Clear();
        }


    
        //функция для замены в шаблоне
        private void ReplaceWordStub(string StubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content; //область,где мы будем что-то вставлять, в нашем случае - весь документ
            range.Find.ClearFormatting();  //очищаем предыдущие поиски в документе
            range.Find.Execute(FindText: StubToReplace, ReplaceWith: text); //меняем в шаблоне на нужное нам
        }

        private void Appoinment_Load(object sender, EventArgs e)
        {

        }
    }
}
