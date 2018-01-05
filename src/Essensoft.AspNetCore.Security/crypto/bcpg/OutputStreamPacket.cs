using System;
using System.IO;

namespace Essensoft.AspNetCore.Security.Bcpg
{
    public abstract class OutputStreamPacket
    {
        private readonly BcpgOutputStream bcpgOut;

		internal OutputStreamPacket(
            BcpgOutputStream bcpgOut)
        {
			if (bcpgOut == null)
				throw new ArgumentNullException("bcpgOut");

			this.bcpgOut = bcpgOut;
        }

		public abstract BcpgOutputStream Open();

		public abstract void Close();
    }
}

