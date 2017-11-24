namespace Essensoft.AspNetCore.Security.Math.Field
{
    public interface IExtensionField
        : IFiniteField
    {
        IFiniteField Subfield { get; }

        int Degree { get; }
    }
}
