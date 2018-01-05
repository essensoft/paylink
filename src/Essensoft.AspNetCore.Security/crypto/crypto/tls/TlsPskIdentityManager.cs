using System;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
    public interface TlsPskIdentityManager
    {
        byte[] GetHint();

        byte[] GetPsk(byte[] identity);
    }
}
