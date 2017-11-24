using System;
using System.IO;

namespace Essensoft.AspNetCore.Security.Cms
{
	public interface CmsProcessable
	{
		/// <summary>
		/// Generic routine to copy out the data we want processed.
		/// </summary>
		/// <remarks>
		/// This routine may be called multiple times.
		/// </remarks>
		void Write(Stream outStream);

		[Obsolete]
		object GetContent();
	}
}
