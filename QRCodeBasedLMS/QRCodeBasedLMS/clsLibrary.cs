using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing;

namespace QRCodeBasedLMS
{
    abstract class clsLibrary
    {
        public virtual void AddRecord() { }
        public virtual void UpdateRecord() { }
        public virtual string GenerateIDNumber() { return ""; }
        public Bitmap GenerateQRCode(string msg)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(msg);
            return bmp;
        }
        public void SetMaximumLength(Bunifu.Framework.UI.BunifuMetroTextbox metroTextbox, int maximumLength)
        {
            foreach (Control ctl in metroTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = maximumLength;
                }
            }
        }
        public void SetDropdownText(Bunifu.Framework.UI.BunifuDropdown drpCombo, string text)
        {
            foreach (Control ctl in drpCombo.Controls)
            {
                if (ctl.GetType() == typeof(ComboBox))
                {
                    var cmb = (ComboBox)ctl;
                    cmb.Text = text;
                }
            }
        }

    }
}
