using System;
using System.IO;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
	public interface TlsCompression
	{
		Stream Compress(Stream output);

		Stream Decompress(Stream output);
	}
}
