namespace Essensoft.AspNetCore.Security.OpenSsl
{
    public interface IPasswordFinder
	{
		char[] GetPassword();
	}
}
