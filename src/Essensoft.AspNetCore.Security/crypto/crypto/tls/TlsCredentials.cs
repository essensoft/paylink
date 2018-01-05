using System;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
	public interface TlsCredentials
	{
		Certificate Certificate { get; }
	}
}
