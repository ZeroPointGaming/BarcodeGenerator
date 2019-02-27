using iTextSharp.text;
using KeepAutomation.Barcode;
using KeepAutomation.Barcode.Bean;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                this.Text = InfoPass.DocumentTitle.ToString();

                /*
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        ((PictureBox)x).BackgroundImage = InfoPass.Barcode;
                    }
                }
                */

                ///New Method for individual barcodes instead of whole page.
                Barcode1Preview.BackgroundImage = InfoPass.Barcode1;
                Barcode2Preview.BackgroundImage = InfoPass.Barcode2;
                Barcode3Preview.BackgroundImage = InfoPass.Barcode3;
                Barcode4Preview.BackgroundImage = InfoPass.Barcode4;
                Barcode5Preview.BackgroundImage = InfoPass.Barcode5;
                Barcode6Preview.BackgroundImage = InfoPass.Barcode6;
                Barcode7Preview.BackgroundImage = InfoPass.Barcode7;
                Barcode8Preview.BackgroundImage = InfoPass.Barcode8;
                Barcode9Preview.BackgroundImage = InfoPass.Barcode9;
                Barcode10Preview.BackgroundImage = InfoPass.Barcode10;
                Barcode11Preview.BackgroundImage = InfoPass.Barcode11;
                Barcode12Preview.BackgroundImage = InfoPass.Barcode12;
                Barcode13Preview.BackgroundImage = InfoPass.Barcode13;
                Barcode14Preview.BackgroundImage = InfoPass.Barcode14;
                Barcode15Preview.BackgroundImage = InfoPass.Barcode15;
                Barcode16Preview.BackgroundImage = InfoPass.Barcode16;
                Barcode17Preview.BackgroundImage = InfoPass.Barcode17;
                Barcode18Preview.BackgroundImage = InfoPass.Barcode18;
                Barcode19Preview.BackgroundImage = InfoPass.Barcode19;
                Barcode20Preview.BackgroundImage = InfoPass.Barcode20;
                Barcode21Preview.BackgroundImage = InfoPass.Barcode21;
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
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(pdfpath + "/" + InfoPass.DocumentTitle.ToString() + ".pdf", FileMode.Create));

                doc.Open();

                //New barcode labels system per coordinates
                Image Barcode = Image.GetInstance(InfoPass.Barcode, System.Drawing.Imaging.ImageFormat.Png);

                switch (InfoPass.Type)
                {
                    //Correct coordinate positioning for UPC-A (12 digit) barcodes
                    case Symbology.UPCA:
                        //Barcode = Image.GetInstance(InfoPass.Barcode19, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 30); //Row 7 Label 1 (50, 220) * appeared at the bottom left of the document :? (65, 38) ?Wtf is this coord system
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode20, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 30); //Row 7 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode21, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 30); //Row 7 Label 3
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode16, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 140); //Row 6 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode17, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 140); //Row 6 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode18, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 140); //Row 6 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode13, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 252); //Row 5 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode14, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 252); //Row 5 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode15, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 252); //Row 5 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode10, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 364); //Row 4 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode11, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 364); //Row 4 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode12, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 364); //Row 4 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode7, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 475); //Row 3 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode8, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 475); //Row 3 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode9, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 475); //Row 3 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode4, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 585); //Row 2 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode5, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 585); //Row 2 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode6, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 585); //Row 2 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode1, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 696); //Row 1 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode2, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 696); //Row 1 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode3, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 696); //Row 1 Label 3 
                        doc.Add(Barcode);
                        break;
                    //Correct coordinate positioning for EAN-13 (13 digit) barcodes
                    case Symbology.EAN13:
                        //Barcode = Image.GetInstance(InfoPass.Barcode19, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 30); //Row 7 Label 1 (50, 220) * appeared at the bottom left of the document :? (65, 38) ?Wtf is this coord system
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode20, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 30); //Row 7 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode21, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 30); //Row 7 Label 3
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode16, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 140); //Row 6 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode17, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 140); //Row 6 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode18, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 140); //Row 6 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode13, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 252); //Row 5 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode14, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 252); //Row 5 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode15, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 252); //Row 5 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode10, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 364); //Row 4 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode11, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 364); //Row 4 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode12, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 364); //Row 4 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode7, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 475); //Row 3 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode8, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 475); //Row 3 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode9, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 475); //Row 3 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode4, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 585); //Row 2 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode5, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 585); //Row 2 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode6, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 585); //Row 2 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode1, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 670); //Row 1 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode2, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 670); //Row 1 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode3, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 670); //Row 1 Label 3 
                        doc.Add(Barcode);
                        break;
                    //Correct coordinate positioning for ITF-14 (14 digit) barcodes
                    case Symbology.ITF14:
                        //Barcode = Image.GetInstance(InfoPass.Barcode19, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 27); //Row 7 Label 1 (50, 220) * appeared at the bottom left of the document :? (65, 38) ?Wtf is this coord system
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode20, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 27); //Row 7 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode21, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 27); //Row 7 Label 3
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode16, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 138); //Row 6 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode17, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 138); //Row 6 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode18, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 138); //Row 6 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode13, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 250); //Row 5 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode14, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 250); //Row 5 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode15, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 250); //Row 5 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode10, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 363); //Row 4 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode11, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 363); //Row 4 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode12, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 363); //Row 4 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode7, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 474); //Row 3 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode8, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 474); //Row 3 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode9, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 474); //Row 3 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode4, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 585); //Row 2 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode5, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 585); //Row 2 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode6, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 585); //Row 2 Label 3 
                        doc.Add(Barcode);

                        //Barcode = Image.GetInstance(InfoPass.Barcode1, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(65, 696); //Row 1 Label 1 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode2, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(260, 696); //Row 1 Label 2 
                        doc.Add(Barcode);
                        //Barcode = Image.GetInstance(InfoPass.Barcode3, System.Drawing.Imaging.ImageFormat.Png);
                        Barcode.SetAbsolutePosition(450, 696); //Row 1 Label 3 
                        doc.Add(Barcode);
                        break;
                }
                

                doc.Close();
                MessageBox.Show("PDF Document Created @ " + pdfpath + "/" + InfoPass.DocumentTitle.ToString() + ".pdf" + Environment.NewLine + "This document can be printed on the orange napa sticky labels.");
                Process.Start(pdfpath + "/" + InfoPass.DocumentTitle.ToString() + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error creating a printable document!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }

            
            this.Dispose();
        }

        /// <summary>
        /// This button event handler refreshes the first barcode on the print preview page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type1;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber1
                };

                InfoPass.Barcode1 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }
        
        /// <summary>
        /// This button event handler refreshes the second barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type2;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber2
                };

                InfoPass.Barcode2 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event handler refreshes the third barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode3Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type3;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber3
                };

                InfoPass.Barcode3 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event handler refreshes the fourth barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode4Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type4;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber4
                };

                InfoPass.Barcode4 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode4;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event handler refreshes the fifth barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode5Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type5;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber5
                };

                InfoPass.Barcode5 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode5;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event handler refreshes the sixth barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode6Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type6;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber6
                };

                InfoPass.Barcode6 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode6;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event handler refreshes the seventh barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode7Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type7;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber7
                };

                InfoPass.Barcode7 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode7;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event hanlder refreshes the eighth barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode8Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type8;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber8
                };

                InfoPass.Barcode8 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode8;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event handler refreshes the nineth barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode9Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type9;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber9
                };

                InfoPass.Barcode9 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode9;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event handler refreshes the tenth barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode10Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type10;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber10
                };

                InfoPass.Barcode10 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode10;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button refreshes the eleventh barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode11Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type11;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber11
                };

                InfoPass.Barcode11 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode11;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event handler refreshes the twelth barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode12Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type12;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber12
                };

                InfoPass.Barcode12 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode12;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event handler refreshes the thirteenth barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode13Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type13;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber13
                };

                InfoPass.Barcode13 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode13;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// This button event handler refreshes the fourteenth barcode on the print preview page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBarcode14Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Symbology CurrentSymbology = InfoPass.type14;

                BarCode Instance = new BarCode
                {
                    Symbology = CurrentSymbology,
                    CodeToEncode = InfoPass.barcodenumber14
                };

                InfoPass.Barcode14 = Instance.generateBarcodeToBitmap();
                Barcode1Preview.BackgroundImage = InfoPass.Barcode14;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error regenerating the barcode!" + Environment.NewLine + "Stack Trace: " + Environment.NewLine + ex.ToString());
            }
        }
    }
}
