
using Essensoft.AspNetCore.Security.Prng.Drbg;

namespace Essensoft.AspNetCore.Security.Prng
{
    internal interface IDrbgProvider
    {
        ISP80090Drbg Get(IEntropySource entropySource);
    }
}
