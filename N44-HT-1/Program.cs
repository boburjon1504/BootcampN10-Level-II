

using System.Text;

var file = File.Open("text.txt", FileMode.Append, FileAccess.Write);
file.Write(Encoding.UTF8.GetBytes("dusafdg"));
file.Close();