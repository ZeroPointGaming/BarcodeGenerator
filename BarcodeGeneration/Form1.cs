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

        //Create barcode
        string Code = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Symbology CurrentSymbology = Symbology.UPCA;
                        
            //Switch between the encoding types
            switch (comboBox1.SelectedItem)
            {
                case "UPC-A":
                    CurrentSymbology = Symbology.UPCA;
                    break;
                case "EAN-13":
                    CurrentSymbology = Symbology.EAN13;
                    break;
                case "ITF-14":
                    CurrentSymbology = Symbology.ITF14;
                    break;
            }

            BarCode Instance = new BarCode
            {
                Symbology = CurrentSymbology,
                CodeToEncode = Code
            };

            pictureBox1.BackgroundImage = Instance.generateBarcodeToBitmap();
        }

        //Save barcode
        private void button2_Click(object sender, EventArgs e)
        {
            Symbology CurrentSymbology = Symbology.UPCA;
            Code = UnformattedBarcodeTextbox.Text;

            //Switch between the encoding types
            switch (comboBox1.SelectedItem)
            {
                case "UPC-A":
                    CurrentSymbology = Symbology.UPCA;
                    break;
                case "EAN-13":
                    CurrentSymbology = Symbology.EAN13;
                    break;
                case "ITF-14":
                    CurrentSymbology = Symbology.ITF14;
                    break;
            }

            BarCode Instance = new BarCode
            {
                Symbology = CurrentSymbology,
                CodeToEncode = Code
            };

            pictureBox1.BackgroundImage = Instance.generateBarcodeToBitmap();

            if (pictureBox1.BackgroundImage != null)
            {
                Clipboard.SetImage(pictureBox1.BackgroundImage);
            }
        }

        //Generate a barcode with a unformatted barcode number
        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
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
            InfoPass.line = LineCodeTextbox.Text;
            InfoPass.partnumber = PartNumberTextbox.Text;
            InfoPass.Type = CurrentSymbology;

            PrintPages PrintedDocument = new PrintPages();
            PrintedDocument.Show();
        }
    }

    public static class InfoPass
    {
        public static string barcodenumber;
        public static string line;
        public static string partnumber;
        public static Image Barcode;
        public static Symbology Type;
    }
}
