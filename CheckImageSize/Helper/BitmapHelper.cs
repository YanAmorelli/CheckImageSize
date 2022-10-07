using System.Drawing;

namespace CheckImageSize.Helper
{
    internal static class BitmapHelper
    {
        internal static Bitmap Base64StringToBitmap(this string base64String)
        {
            Bitmap bmpReturn = null;

            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);

            memoryStream.Position = 0;

            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);

            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;

            return bmpReturn;
        }

        internal static bool IsValid(Bitmap image, long fileSize)
        {
            if (image.Width > 1280 || image.Height > 220)
            {
                return false;
            }

            // 1mb = 1024000bytes
            if (fileSize > 1024000)
            {
                return false;
            }

            return true;
        }
    }
}
