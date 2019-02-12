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

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        //Print the document
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;
            
            CaptureScreen();

            Document doc = new Document();
            try
            {
                Image PrintForm;

                using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                {
                    this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                    PrintForm = Image.GetInstance(bmp, System.Drawing.Imaging.ImageFormat.Png);
                }

                string pdfpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(pdfpath + "/" + InfoPass.line.ToString() + " - " + InfoPass.partnumber.ToString() + ".pdf", FileMode.Create));
                PrintForm.ScaleToFit(doc.PageSize.Width, doc.PageSize.Height);
                doc.Open();
                doc.Add(PrintForm);
                doc.Close();

                MessageBox.Show("PDF Document Created @ " + pdfpath + "/" + InfoPass.line.ToString() + " - " + InfoPass.partnumber.ToString() + ".pdf");
            }
            catch (Exception ex)
            {
                //Log error;
            }

            
            this.Dispose();
        }
    }
}
