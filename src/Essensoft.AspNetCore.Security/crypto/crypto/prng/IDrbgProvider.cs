using System;

using Essensoft.AspNetCore.Security.Crypto.Prng.Drbg;

namespace Essensoft.AspNetCore.Security.Crypto.Prng
{
    internal interface IDrbgProvider
    {
        ISP80090Drbg Get(IEntropySource entropySource);
    }
}
