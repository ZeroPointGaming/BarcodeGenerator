using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = iTextSharp.text.Image;

namespace BarcodeGeneration
{
    public partial class PrintPages : Form
    {
        public PrintPages()
        {
            InitializeComponent();
        }

        //Load all the image boxes with the labels
        private void PrintPage_Load(object sender, EventArgs e)
        {
            try
            {
                label1.Text = InfoPass.line + " - " + InfoPass.partnumber;

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        ((PictureBox)x).BackgroundImage = InfoPass.Barcode;
                    }
                }
            }
            catch
            {

            }
        }

        //Print the document
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Document doc = new Document(PageSize.LETTER, 0, 0, 0, 0);
            try
            {
                string pdfpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(pdfpath + "/" + InfoPass.line.ToString() + " - " + InfoPass.partnumber.ToString() + ".pdf", FileMode.Create));

                doc.Open();

                //New barcode labels system per coordinates
                Image Barcode = Image.GetInstance(InfoPass.Barcode, System.Drawing.Imaging.ImageFormat.Png);

                Barcode.SetAbsolutePosition(65, 38); //Row 7 Label 1 (50, 220) * appeared at the bottom left of the document :? (65, 38) ?Wtf is this coord system
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(260, 38); //Row 7 Label 2 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(450, 38); //Row 7 Label 3
                doc.Add(Barcode);

                Barcode.SetAbsolutePosition(65, 147); //Row 6 Label 1 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(260, 147); //Row 6 Label 2 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(450, 147); //Row 6 Label 3 
                doc.Add(Barcode);

                Barcode.SetAbsolutePosition(65, 255); //Row 5 Label 1 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(260, 255); //Row 5 Label 2 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(450, 255); //Row 5 Label 3 
                doc.Add(Barcode);

                Barcode.SetAbsolutePosition(65, 365); //Row 4 Label 1 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(260, 365); //Row 4 Label 2 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(450, 365); //Row 4 Label 3 
                doc.Add(Barcode);

                Barcode.SetAbsolutePosition(65, 474); //Row 3 Label 1 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(260, 474); //Row 3 Label 2 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(450, 474); //Row 3 Label 3 
                doc.Add(Barcode);

                Barcode.SetAbsolutePosition(65, 583); //Row 2 Label 1 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(260, 583); //Row 2 Label 2 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(450, 583); //Row 2 Label 3 
                doc.Add(Barcode);

                Barcode.SetAbsolutePosition(65, 689); //Row 1 Label 1 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(260, 689); //Row 1 Label 2 
                doc.Add(Barcode);
                Barcode.SetAbsolutePosition(450, 689); //Row 1 Label 3 
                doc.Add(Barcode);

                doc.Close();
                MessageBox.Show("PDF Document Created @ " + pdfpath + "/" + InfoPass.line.ToString() + " - " + InfoPass.partnumber.ToString() + ".pdf" + Environment.NewLine + "This document can be printed on the orange napa sticky labels.");
            }
            catch (Exception ex)
            {
                //Log error;
            }

            
            this.Dispose();
        }
    }
}
