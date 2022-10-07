using CheckImageSize.Helper;
using System.Drawing;

var path = Path.GetFullPath("C:/Users/3CON-RJ/Desktop/Tamanho_maior.txt");
string base64Img = File.ReadAllText(path);
long fileInfo = new FileInfo(path).Length;


Bitmap imgBitmap = BitmapHelper.Base64StringToBitmap(base64Img);
bool response = BitmapHelper.IsValid(imgBitmap, fileInfo);
Console.WriteLine(response);