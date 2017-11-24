using System;
using System.IO;

using Essensoft.AspNetCore.Security.Asn1;
using Essensoft.AspNetCore.Security.Asn1.Cms;
using Essensoft.AspNetCore.Security.Utilities;

namespace Essensoft.AspNetCore.Security.Cms
{
	public class CmsContentInfoParser
	{
		protected ContentInfoParser	contentInfo;
		protected Stream data;

		protected CmsContentInfoParser(
			Stream data)
		{
			if (data == null)
				throw new ArgumentNullException("data");

			this.data = data;

			try
			{
				Asn1StreamParser inStream = new Asn1StreamParser(data);

				this.contentInfo = new ContentInfoParser((Asn1SequenceParser)inStream.ReadObject());
			}
			catch (IOException e)
			{
				throw new CmsException("IOException reading content.", e);
			}
			catch (InvalidCastException e)
			{
				throw new CmsException("Unexpected object reading content.", e);
			}
		}

		/**
		* Close the underlying data stream.
		* @throws IOException if the close fails.
		*/
		public void Close()
		{
            Platform.Dispose(this.data);
		}
	}
}
