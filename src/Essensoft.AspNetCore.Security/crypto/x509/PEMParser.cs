using System;
using System.IO;
using System.Text;

using Essensoft.AspNetCore.Security.Asn1;
using Essensoft.AspNetCore.Security.Utilities;
using Essensoft.AspNetCore.Security.Utilities.Encoders;

namespace Essensoft.AspNetCore.Security.X509
{
	class PemParser
	{
		private readonly string _header1;
		private readonly string _header2;
		private readonly string _footer1;
		private readonly string _footer2;

		internal PemParser(
			string type)
		{
			_header1 = "-----BEGIN " + type + "-----";
			_header2 = "-----BEGIN X509 " + type + "-----";
			_footer1 = "-----END " + type + "-----";
			_footer2 = "-----END X509 " + type + "-----";
		}

		private string ReadLine(
			Stream inStream)
		{
			int c;
			StringBuilder l = new StringBuilder();

			do
			{
				while (((c = inStream.ReadByte()) != '\r') && c != '\n' && (c >= 0))
				{
					if (c == '\r')
					{
						continue;
					}

					l.Append((char)c);
				}
			}
			while (c >= 0 && l.Length == 0);

			if (c < 0)
			{
				return null;
			}

			return l.ToString();
		}

		internal Asn1Sequence ReadPemObject(
			Stream inStream)
		{
			string line;
			StringBuilder pemBuf = new StringBuilder();

			while ((line = ReadLine(inStream)) != null)
			{
                if (Platform.StartsWith(line, _header1) || Platform.StartsWith(line, _header2))
				{
					break;
				}
			}

			while ((line = ReadLine(inStream)) != null)
			{
                if (Platform.StartsWith(line, _footer1) || Platform.StartsWith(line, _footer2))
				{
					break;
				}

				pemBuf.Append(line);
			}

			if (pemBuf.Length != 0)
			{
				Asn1Object o = Asn1Object.FromByteArray(Base64.Decode(pemBuf.ToString()));

				if (!(o is Asn1Sequence))
				{
					throw new IOException("malformed PEM data encountered");
				}

				return (Asn1Sequence) o;
			}

			return null;
		}
	}
}

