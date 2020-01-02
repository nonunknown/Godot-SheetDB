using Godot ;
using System;
using System.Text;
using System.IO.Compression;
using System.IO;

namespace Sheets
{
		
	static class Comprime {
		private static string Compact(string text)
			{
				byte[] buffer = Encoding.UTF8.GetBytes(text);
				MemoryStream ms = new MemoryStream();
				using (GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true))
				{
					zip.Write(buffer, 0, buffer.Length);
				}

				ms.Position = 0;
				MemoryStream outStream = new MemoryStream();

				byte[] compressed = new byte[ms.Length];
				ms.Read(compressed, 0, compressed.Length);

				byte[] gzBuffer = new byte[compressed.Length + 4];
				System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
				System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
				return Convert.ToBase64String(gzBuffer);
			}

			private static string Descompact(string compressedText)
			{
				byte[] gzBuffer = Convert.FromBase64String(compressedText);
				using (MemoryStream ms = new MemoryStream())
				{
					int msgLength = BitConverter.ToInt32(gzBuffer, 0);
					ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

					byte[] buffer = new byte[msgLength];

					ms.Position = 0;
					using (GZipStream zip = new GZipStream(ms, CompressionMode.Decompress))
					{
						zip.Read(buffer, 0, buffer.Length);
					}
					return Encoding.UTF8.GetString(buffer);
				}
			}

			private static string GetFile(string path) {
				string s = "";
				try
				{
					s = System.IO.File.ReadAllText(path);
					
				}
				catch (System.Exception e)
				{
					
					GD.Print("error at getfile"+e.Message);
				}
				return s;
			}

			public static String[] Compress(string pathToScene) {
				String[] result = new String[2];

				string toComprime = Comprime.GetFile(pathToScene);


				string comprimed = Comprime.Compact(toComprime);
				result[0] = comprimed;
				result[1] = GD.Str(comprimed).MD5Text();

				// string decompacted = Comprime.Descompact(result[1]);
				// result[2] = decompacted;

				

				// System.IO.File.WriteAllLines("test.txt",result);

				return result;
			}
	}

}

