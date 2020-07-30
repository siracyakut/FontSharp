using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;

namespace FontSharp
{
    public class fontSharp
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        public static Font YeniFont(byte[] fontDosya, float fontSize)
        {
            try
            {
                PrivateFontCollection fonts = new PrivateFontCollection();
                byte[] fontData = fontDosya;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, fontDosya.Length);
                AddFontMemResourceEx(fontPtr, (uint)fontDosya.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
                Font f = new Font(fonts.Families[0], fontSize);
                return f;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}