using System.IO;
using Essensoft.AspNetCore.Security.Security;
using Essensoft.AspNetCore.Security.Utilities.IO.Pem;

namespace Essensoft.AspNetCore.Security.OpenSsl
{
    /// <remarks>General purpose writer for OpenSSL PEM objects.</remarks>
    public class PemWriter
		: Essensoft.AspNetCore.Security.Utilities.IO.Pem.PemWriter
	{
		/// <param name="writer">The TextWriter object to write the output to.</param>
		public PemWriter(
			TextWriter writer)
			: base(writer)
		{
		}

		public void WriteObject(
			object obj) 
		{
			try
			{
				base.WriteObject(new MiscPemGenerator(obj));
			}
			catch (PemGenerationException e)
			{
				if (e.InnerException is IOException)
					throw (IOException)e.InnerException;

				throw e;
			}
		}

		public void WriteObject(
			object			obj,
			string			algorithm,
			char[]			password,
			SecureRandom	random)
		{
			base.WriteObject(new MiscPemGenerator(obj, algorithm, password, random));
		}
	}
}
