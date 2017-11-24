namespace Essensoft.AspNetCore.Security.Modes.Gcm
{
    public interface IGcmMultiplier
	{
		void Init(byte[] H);
		void MultiplyH(byte[] x);
	}
}
