using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QuarsPicker
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        public static Color clr;
        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

        public Main()
        {
            InitializeComponent();
            colorBox.BorderStyle = BorderStyle.FixedSingle;
            colorBox.Padding = new Padding(2);
            selectedColor.BorderStyle = BorderStyle.FixedSingle;
            selectedColor.Padding = new Padding(2);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            pixelGrabber.Enabled = false;
            pixelGrabber.Stop();
            Environment.Exit(0);
        }

        private void PixelGrabber_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            clr = GetColorAt(cursor);
            colorBox.BackColor = clr;
        }

        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }
            return screenPixel.GetPixel(0, 0);
        }

        private void CpyClr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(colorList.SelectedItem.ToString());
        }

        private void KeyGrabber_Tick(object sender, EventArgs e)
        {
            if(IsKeyPushedDown(Keys.X))
            {
                colorList.Items.Add("#" + clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2"));
                
            }
        }
        public static bool IsKeyPushedDown(Keys vKey)
        {
            return 0 != (GetAsyncKeyState(vKey) & 0x8000);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Still WIP!", "QuarsPicker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ColorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color rgbClr = ColorTranslator.FromHtml(colorList.SelectedItem.ToString());
            float rf = rgbClr.R / 255.0F;
            float rg = rgbClr.G / 255.0F;
            float rb = rgbClr.B / 255.0F;
            rgbLabel.Text = @"RGB:" + Environment.NewLine + rgbClr.R.ToString() + ", " + rgbClr.G.ToString() + ", " + rgbClr.B.ToString();
            rgbbLabel.Text = @"RGB(1-0):" + Environment.NewLine + TruncateCalc(rf, 2) + ", " + TruncateCalc(rg, 2) + ", " + TruncateCalc(rb, 2);
            hexLabel.Text = @"HEX:" + Environment.NewLine + "0x" + rgbClr.R.ToString("X2") + rgbClr.G.ToString("X2") + rgbClr.B.ToString("X2");
            intLabel.Text = @"INTEGER:" + Environment.NewLine + ColorTranslator.FromHtml(colorList.SelectedItem.ToString()).ToArgb().ToString();
            selectedColor.BackColor = rgbClr;
        }
        private static float TruncateCalc(float value, int digits)
        {
            double mult = Math.Pow(10.0, digits);
            double result = Math.Truncate(mult * value) / mult;
            return (float)result;
        }
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Color rgbClr = ColorTranslator.FromHtml(colorList.SelectedItem.ToString());
            Clipboard.SetText(rgbClr.R.ToString() + ", " + rgbClr.G.ToString() + ", " + rgbClr.B.ToString());
        }

        private void CopyRgbb_Click(object sender, EventArgs e)
        {
            Color rgbClr = ColorTranslator.FromHtml(colorList.SelectedItem.ToString());
            float rf = rgbClr.R / 255.0F;
            float rg = rgbClr.G / 255.0F;
            float rb = rgbClr.B / 255.0F;
            Clipboard.SetText(TruncateCalc(rf, 2) + ", " + TruncateCalc(rg, 2) + ", " + TruncateCalc(rb, 2));
        }

        private void CopyHex_Click(object sender, EventArgs e)
        {
            Color rgbClr = ColorTranslator.FromHtml(colorList.SelectedItem.ToString());
            Clipboard.SetText("0x" + rgbClr.R.ToString("X2") + rgbClr.G.ToString("X2") + rgbClr.B.ToString("X2"));
        }

        private void CopyInt_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ColorTranslator.FromHtml(colorList.SelectedItem.ToString()).ToArgb().ToString());
        }

        private void İnfoButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox.Show("QuarsPicker\nMade by Lysep CORP.\ngithub.com/lysep-corp/", "QuarsPicker -|- Info", CustomMessageBox.eDialogButtons.OK, Properties.Resources.LS_ORANGE);
            Process.Start("https://github.com/lysep-corp/");
        }
    }
}
