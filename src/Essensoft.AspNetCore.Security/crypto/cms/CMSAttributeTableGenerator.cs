using System.Collections;

using Essensoft.AspNetCore.Security.Asn1.Cms;

namespace Essensoft.AspNetCore.Security.Cms
{
    /// <remarks>
    /// The 'Signature' parameter is only available when generating unsigned attributes.
    /// </remarks>
    public enum CmsAttributeTableParameter
	{
//		const string ContentType = "contentType";
//		const string Digest = "digest";
//		const string Signature = "encryptedDigest";
//		const string DigestAlgorithmIdentifier = "digestAlgID";

		ContentType, Digest, Signature, DigestAlgorithmIdentifier
	}

	public interface CmsAttributeTableGenerator
	{
		AttributeTable GetAttributes(IDictionary parameters);
	}
}
