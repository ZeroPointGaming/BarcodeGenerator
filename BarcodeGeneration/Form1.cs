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
using System.Windows.Media.Imaging;
using KeepAutomation.Barcode;
using KeepAutomation.Barcode.Bean;
using KeepAutomation.Barcode.Windows;

namespace BarcodeGeneration
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form 1 initialization constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handle text input to make sure we only allow numerical values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// local barcode string for storing a temp barcode number string for processing.
        /// </summary>
        string Code = "";

        /// <summary>
        /// Generate a barcode preview button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneratePreviewBtn_Click(object sender, EventArgs e)
        {
            Symbology CurrentSymbology = Symbology.UPCA;

            //Switch between the encoding types
            switch (comboBox1.SelectedItem)
            {
                case "UPC-A":
                    CurrentSymbology = Symbology.UPCA;
                    Code = UnformattedBarcodeTextbox.Text;
                    break;
                case "EAN-13":
                    CurrentSymbology = Symbology.EAN13;
                    Code = UnformattedBarcodeTextbox.Text;
                    break;
                case "ITF-14":
                    CurrentSymbology = Symbology.ITF14;
                    Code = UnformattedBarcodeTextbox.Text;
                    break;
            }

            BarCode Instance = new BarCode
            {
                Symbology = CurrentSymbology,
                CodeToEncode = Code
            };

            pictureBox1.BackgroundImage = Instance.generateBarcodeToBitmap();
        }

        /// <summary>
        /// Combo box selection changed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Switch between the encoding types
            switch (comboBox1.SelectedItem)
            {
                case "UPC-A":
                    toolTip1.SetToolTip(UnformattedBarcodeTextbox, "UPC-A QTY(1) MFG(51131) PN(26340) Chk(3)");
                    break;
                case "EAN-13":
                    toolTip1.SetToolTip(UnformattedBarcodeTextbox, "EAN-13 NS(7 5) MFG(01054) PN(53010) Chk(7)");
                    break;
                case "ITF-14":
                    toolTip1.SetToolTip(UnformattedBarcodeTextbox, "ITF-14 ID(5) NS(00) MFG(51131) (PN26340) Chk(1)");
                    break;
            }
        }

        /// <summary>
        /// Create pdf button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatePdfBtn_Click(object sender, EventArgs e)
        {
            Symbology CurrentSymbology = Symbology.UPCA;

            //Switch between the encoding types
            switch (comboBox1.SelectedItem)
            {
                case "UPC-A":
                    CurrentSymbology = Symbology.UPCA;
                    Code = UnformattedBarcodeTextbox.Text;
                    break;
                case "EAN-13":
                    CurrentSymbology = Symbology.EAN13;
                    Code = UnformattedBarcodeTextbox.Text;
                    break;
                case "ITF-14":
                    CurrentSymbology = Symbology.ITF14;
                    Code = UnformattedBarcodeTextbox.Text;
                    break;
            }

            BarCode Instance = new BarCode
            {
                Symbology = CurrentSymbology,
                CodeToEncode = Code
            };

            //Iterate the list and add the barcodes to the static class for transfer
            for (int i=0; i < listBox1.Items.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type1 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type1 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type1 = Instance.Symbology; }
                        InfoPass.Barcode1 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber1 = listBox1.Items[i].ToString();
                        break;
                    case 1:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type2 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type2 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type2 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode2 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber2 = listBox1.Items[i].ToString();
                        break;
                    case 2:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type3 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type3 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type3 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode3 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber3 = listBox1.Items[i].ToString();
                        break;
                    case 3:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type4 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type4 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type4 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode4 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber4 = listBox1.Items[i].ToString();
                        break;
                    case 4:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type5 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type5 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type5 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode5 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber5 = listBox1.Items[i].ToString();
                        break;
                    case 5:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type6 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type6 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type6 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode6 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber6 = listBox1.Items[i].ToString();
                        break;
                    case 6:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type7 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type7 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type7 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode7 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber7 = listBox1.Items[i].ToString();
                        break;
                    case 7:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type8 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type8 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type8 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode8 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber8 = listBox1.Items[i].ToString();
                        break;
                    case 8:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type9 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type9 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type9 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode9 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber9 = listBox1.Items[i].ToString();
                        break;
                    case 9:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type10 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type10 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type10 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode10 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber10 = listBox1.Items[i].ToString();
                        break;
                    case 10:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type11 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type11 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type11 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode11 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber11 = listBox1.Items[i].ToString();
                        break;
                    case 11:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type12 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type12 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type12 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode12 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber12 = listBox1.Items[i].ToString();
                        break;
                    case 12:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type13 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type13 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type13 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode13 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber13 = listBox1.Items[i].ToString();
                        break;
                    case 13:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type14 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type14 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type14 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode14 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber14 = listBox1.Items[i].ToString();
                        break;
                    case 14:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type15 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type15 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type15 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode15 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber15 = listBox1.Items[i].ToString();
                        break;
                    case 15:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type16 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type16 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type16 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode16 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber16  = listBox1.Items[i].ToString();
                        break;
                    case 16:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type17 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type17 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type17 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode17 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber17 = listBox1.Items[i].ToString();
                        break;
                    case 17:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type18 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type18 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type18 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode18 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber18 = listBox1.Items[i].ToString();
                        break;
                    case 18:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type19 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type19 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type19 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode19 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber19 = listBox1.Items[i].ToString();
                        break;
                    case 19:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type20 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type20 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type20 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode20 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber20 = listBox1.Items[i].ToString();
                        break;
                    case 20:
                        if (Instance.CodeToEncode.Length == 11) { Instance.Symbology = Symbology.UPCA; InfoPass.type21 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 12) { Instance.Symbology = Symbology.EAN13; InfoPass.type21 = Instance.Symbology; }
                        if (Instance.CodeToEncode.Length == 13) { Instance.Symbology = Symbology.ITF14; InfoPass.type21 = Instance.Symbology; }
                        Instance.CodeToEncode = listBox1.Items[i].ToString();
                        InfoPass.Barcode21 = Instance.generateBarcodeToBitmap();
                        InfoPass.barcodenumber21 = listBox1.Items[i].ToString();
                        break;
                }
            }

            InfoPass.DocumentTitle = DocumentTitleTextbox.Text;
            InfoPass.Type = CurrentSymbology;

            PrintPages PrintedDocument = new PrintPages();
            PrintedDocument.Show();
        }

        /// <summary>
        /// Add barcode to the listbox button event handler
        /// </summary>
        private void AddBarcodeToList_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count <= 20)
            {
                listBox1.Items.Add(UnformattedBarcodeTextbox.Text);
            }
            else { MessageBox.Show("Maximum number of barcodes reached for current page."); }
        }

        /// <summary>
        /// Remove selected barcode button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveBarcodeBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) { listBox1.Items.RemoveAt(listBox1.SelectedIndex); }
        }

        /// <summary>
        /// Save the barcodes to a list incase of undo and clear the listbox button event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearBarcodeListBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        /// <summary>
        /// Undo clearing the barcode list button event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoClearBtn_Click(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    /// This is a static data structure class for passing data between two forms.
    /// </summary>
    public static class InfoPass
    {
        /// <summary>
        /// Static string for the pdf document title
        /// </summary>
        public static string DocumentTitle;

        /// <summary>
        /// Static instance of barcode for whole page single barcode printing 
        /// </summary>
        [Obsolete("Barcodes are no longer printed by the page basis. This variable is being worked out of the system!")]
        public static Image Barcode;

        /// <summary>
        /// Global barcode page type for correct coordinate formatting.
        /// </summary>
        public static Symbology Type;

        /// <summary>
        /// Barcode #1 Static Image instance
        /// </summary>
        public static Image Barcode1;
        /// <summary>
        /// Barcode #1 Static barcode number string
        /// </summary>
        public static string barcodenumber1;
        /// <summary>
        /// Barcode #1 Static barcode type enumerator
        /// </summary>
        public static Symbology type1;

        public static Image Barcode2;
        public static string barcodenumber2;
        public static Symbology type2;
        public static Image Barcode3;
        public static string barcodenumber3;
        public static Symbology type3;
        public static Image Barcode4;
        public static string barcodenumber4;
        public static Symbology type4;
        public static Image Barcode5;
        public static string barcodenumber5;
        public static Symbology type5;
        public static Image Barcode6;
        public static string barcodenumber6;
        public static Symbology type6;
        public static Image Barcode7;
        public static string barcodenumber7;
        public static Symbology type7;
        public static Image Barcode8;
        public static string barcodenumber8;
        public static Symbology type8;
        public static Image Barcode9;
        public static string barcodenumber9;
        public static Symbology type9;
        public static Image Barcode10;
        public static string barcodenumber10;
        public static Symbology type10;
        public static Image Barcode11;
        public static string barcodenumber11;
        public static Symbology type11;
        public static Image Barcode12;
        public static string barcodenumber12;
        public static Symbology type12;
        public static Image Barcode13;
        public static string barcodenumber13;
        public static Symbology type13;
        public static Image Barcode14;
        public static string barcodenumber14;
        public static Symbology type14;
        public static Image Barcode15;
        public static string barcodenumber15;
        public static Symbology type15;
        public static Image Barcode16;
        public static string barcodenumber16;
        public static Symbology type16;
        public static Image Barcode17;
        public static string barcodenumber17;
        public static Symbology type17;
        public static Image Barcode18;
        public static string barcodenumber18;
        public static Symbology type18;
        public static Image Barcode19;
        public static string barcodenumber19;
        public static Symbology type19;
        public static Image Barcode20;
        public static string barcodenumber20;
        public static Symbology type20;
        public static Image Barcode21;
        public static string barcodenumber21;
        public static Symbology type21;
    }
}
