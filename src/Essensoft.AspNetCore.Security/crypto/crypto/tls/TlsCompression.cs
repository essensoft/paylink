using System.IO;

namespace Essensoft.AspNetCore.Security.Tls
{
    public interface TlsCompression
	{
		Stream Compress(Stream output);

		Stream Decompress(Stream output);
	}
}
