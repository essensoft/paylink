using System;

namespace Essensoft.AspNetCore.Security.Math.EC
{
    public interface ECPointMap
    {
        ECPoint Map(ECPoint p);
    }
}
