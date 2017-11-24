using System.Collections;

using Essensoft.AspNetCore.Security.Asn1.Cms;

namespace Essensoft.AspNetCore.Security.Cms
{
    /**
	 * Basic generator that just returns a preconstructed attribute table
	 */
    public class SimpleAttributeTableGenerator
		: CmsAttributeTableGenerator
	{
		private readonly AttributeTable attributes;

		public SimpleAttributeTableGenerator(
			AttributeTable attributes)
		{
			this.attributes = attributes;
		}

		public virtual AttributeTable GetAttributes(
			IDictionary parameters)
		{
			return attributes;
		}
	}
}
