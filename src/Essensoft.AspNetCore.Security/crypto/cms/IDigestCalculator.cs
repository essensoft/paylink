namespace Essensoft.AspNetCore.Security.Cms
{
    internal interface IDigestCalculator
	{
		byte[] GetDigest();
	}
}
