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
        public Form1()
        {
            InitializeComponent();
        }

        //Handle text input to make sure we only allow numerical values
        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Create barcode Static String
        string Code = "";

        //Generate a barcode with a unformatted barcode number
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

            InfoPass.Barcode = Instance.generateBarcodeToBitmap();
            InfoPass.Barcode = Instance.generateBarcodeToBitmap();
            InfoPass.Barcode = Instance.generateBarcodeToBitmap();
            InfoPass.barcodenumber = UnformattedBarcodeTextbox.Text;
            InfoPass.DocumentTitle = DocumentTitleTextbox.Text;
            InfoPass.Type = CurrentSymbology;

            PrintPages PrintedDocument = new PrintPages();
            PrintedDocument.Show();
        }

        //Add barcode to the listbox button
        private void AddBarcodeToList_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 22)
            {
                listBox1.Items.Add(UnformattedBarcodeTextbox.Text);
            }
            else { MessageBox.Show("Maximum number of barcodes reached for current page."); }
        }

        //Remove selected barcode button
        private void RemoveBarcodeBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) { listBox1.Items.RemoveAt(listBox1.SelectedIndex); }
        }

        //Save the barcodes to a list incase of undo and clear the listbox
        private void ClearBarcodeListBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //Undo clearing the barcode list
        private void UndoClearBtn_Click(object sender, EventArgs e)
        {

        }
    }

    public static class InfoPass
    {
        public static string barcodenumber;
        public static string DocumentTitle;
        public static Image Barcode;
        public static Symbology Type;

        //Barcodes 1-21 In order from top to bottom
        public static Image Barcode1;
        public static Image Barcode2;
        public static Image Barcode3;
        public static Image Barcode4;
        public static Image Barcode5;
        public static Image Barcode6;
        public static Image Barcode7;
        public static Image Barcode8;
        public static Image Barcode9;
        public static Image Barcode10;
        public static Image Barcode11;
        public static Image Barcode12;
        public static Image Barcode13;
        public static Image Barcode14;
        public static Image Barcode15;
        public static Image Barcode16;
        public static Image Barcode17;
        public static Image Barcode18;
        public static Image Barcode19;
        public static Image Barcode20;
        public static Image Barcode21;
    }
}
