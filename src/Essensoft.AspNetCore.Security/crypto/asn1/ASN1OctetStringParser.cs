using System.IO;

namespace Essensoft.AspNetCore.Security.Asn1
{
	public interface Asn1OctetStringParser
		: IAsn1Convertible
	{
		Stream GetOctetStream();
	}
}
