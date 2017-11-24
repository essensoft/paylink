using System;
using System.IO;

using Essensoft.AspNetCore.Security.Utilities;
using Essensoft.AspNetCore.Security.Utilities.IO;

namespace Essensoft.AspNetCore.Security.Cms
{
	public class CmsProcessableInputStream
		: CmsProcessable, CmsReadable
	{
		private readonly Stream input;

        private bool used = false;

        public CmsProcessableInputStream(Stream input)
		{
			this.input = input;
		}

        public virtual Stream GetInputStream()
		{
			CheckSingleUsage();

            return input;
		}

        public virtual void Write(Stream output)
		{
			CheckSingleUsage();

			Streams.PipeAll(input, output);
            Platform.Dispose(input);
		}

        [Obsolete]
		public virtual object GetContent()
		{
			return GetInputStream();
		}

        protected virtual void CheckSingleUsage()
		{
			lock (this)
			{
				if (used)
					throw new InvalidOperationException("CmsProcessableInputStream can only be used once");

                used = true;
			}
		}
	}
}
