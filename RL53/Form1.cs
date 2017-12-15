using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RL53
{
    public partial class Form1 : Form
    {
        private BackgroundWorker worker;

        public Form1()
        {
            InitializeComponent();
        }

        public void GeneratePDF(object sender, DoWorkEventArgs e)
        {
            using (var doc = new Document())
            using (var file = new FileStream(this.outputPdfTextbox.Text, FileMode.Create))
            using (var pdf = new PdfCopy(doc, file))
            {
                doc.Open();
                int i = 1;
                int lineCount = this.NumberOfLines(this.csvExportTextbox.Text);
                foreach (var record in ReadCSV(this.csvExportTextbox.Text))
                {
                    var stream = new MemoryStream();
                    using (var reader = new PdfReader(this.rl53SourceTextbox.Text))
                    using (var pdfStamper = new PdfStamper(reader, stream))
                    {
                        pdfStamper.FormFlattening = true;
                        pdfStamper.Writer.CloseStream = false;
                        foreach (var column in record)
                            pdfStamper.AcroFields.SetField(column.Key, column.Value);
                    }

                    CopyPages(pdf, stream);
                    worker.ReportProgress((int)((float)i / lineCount * 100));
                    i++;
                }
            }

            worker.ReportProgress(100);
        }

        private static void CopyPages(PdfCopy pdf, MemoryStream stream)
        {
            using (var reader = new PdfReader(stream.GetBuffer()))
            {
                for (int pageNumber = 0; pageNumber < reader.NumberOfPages; ++pageNumber)
                    pdf.AddPage(pdf.GetImportedPage(reader, pageNumber + 1));
            }
        }

        private int NumberOfLines(string filename)
        {
            return File.ReadLines(filename).Count();
        }

        private IEnumerable<IDictionary<string, string>> ReadCSV(string filename)
        {
            using (TextFieldParser parser = new TextFieldParser(filename))
            {
                parser.Delimiters = new string[] { "," };
                var fields = parser.ReadFields();

                while(!parser.EndOfData)
                {
                    var fieldData = parser.ReadFields();
                    var row = new Dictionary<string, string>();

                    for(int i = 0; i < fieldData.Length; ++i)
                        row.Add(fields[i], fieldData[i]);

                    yield return row;
                }
            }
        }

        #region [ File Browsing Handlers ]

        private void outputPdfBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "pdf",
                Title = "Select new PDF to create",
                OverwritePrompt = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                outputPdfTextbox.Text = dialog.FileName;
            }
        }

        private void csvExportBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                AddExtension = true,
                DefaultExt = "csv",
                Title = "Open Winestyr RL53 CSV export"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                csvExportTextbox.Text = dialog.FileName;
            }
        }

        private void rl53SourceFileBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                AddExtension = true,
                DefaultExt = "csv",
                Title = "Open IL RL53 source PDF"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                rl53SourceTextbox.Text = dialog.FileName;
            }
        }

        #endregion

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBoxes())
                return;

            if (this.worker != null && this.worker.IsBusy)
                return;

            if (this.worker != null)
                this.worker.Dispose();

            this.worker = new BackgroundWorker();

            this.worker.DoWork += new DoWorkEventHandler(GeneratePDF);
            this.worker.WorkerReportsProgress = true;
            this.worker.ProgressChanged += Worker_ProgressChanged;
            this.worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            this.worker.RunWorkerAsync();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Export Complete", "Done", MessageBoxButtons.OK);
            this.progressBar.Value = 0;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
        }

        private bool ValidateTextBoxes()
        {
            if (!File.Exists(rl53SourceTextbox.Text))
            {
                MessageBox.Show("Missing RL53 source file", "Validation Error", MessageBoxButtons.OK);
                return false;
            }
            if (!File.Exists(csvExportTextbox.Text))
            {
                MessageBox.Show("Missing Winestyr CSV export file", "Validation Error", MessageBoxButtons.OK);
                return false;
            }
            if (String.IsNullOrWhiteSpace(outputPdfTextbox.Text))
            {
                MessageBox.Show("Missing output PDF file", "Validation Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}
