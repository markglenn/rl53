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
        public Form1()
        {
            InitializeComponent();

            using (var doc = new Document())
            //using (var pdf = new PdfCopy(doc, file))
            {
                doc.Open();
                int i = 1;
                foreach (var record in ReadCSV("C:\\Users\\markg\\Downloads\\RL-53-2017-11-01.csv"))
                {

                    var filename = "C:\\Users\\markg\\Downloads\\out\\page" + i.ToString("D4") + ".pdf";
                    using (var reader = new PdfReader("C:\\Users\\markg\\Downloads\\RL-53.pdf"))
                    using (var file = new FileStream(filename, FileMode.Create))
                    using (var pdfStamper = new PdfStamper(reader, file))
                    {
                        pdfStamper.FormFlattening = true;
                        pdfStamper.Writer.CloseStream = false;
                        foreach (var column in record)
                        {
                            pdfStamper.AcroFields.SetField(column.Key, column.Value);
                        }
                    }

                    i++;
                }
            }
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
    }
}
