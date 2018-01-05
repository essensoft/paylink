using System;
using System.IO;

namespace Essensoft.AspNetCore.Security.Cms
{
	public interface CmsReadable
	{
		Stream GetInputStream();
	}
}
