using System;

namespace Essensoft.AspNetCore.Security.Math.Field
{
    public interface IPolynomialExtensionField
        : IExtensionField
    {
        IPolynomial MinimalPolynomial { get; }
    }
}
