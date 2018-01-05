using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

using Essensoft.AspNetCore.Security.Asn1;
using Essensoft.AspNetCore.Security.Asn1.CryptoPro;
using Essensoft.AspNetCore.Security.Asn1.Pkcs;
using Essensoft.AspNetCore.Security.Asn1.X509;
using Essensoft.AspNetCore.Security.Asn1.X9;
using Essensoft.AspNetCore.Security.Crypto;
using Essensoft.AspNetCore.Security.Crypto.Generators;
using Essensoft.AspNetCore.Security.Crypto.Parameters;
using Essensoft.AspNetCore.Security.Math;
using Essensoft.AspNetCore.Security.Pkcs;
using Essensoft.AspNetCore.Security.Security;
using Essensoft.AspNetCore.Security.Security.Certificates;
using Essensoft.AspNetCore.Security.Utilities.Encoders;
using Essensoft.AspNetCore.Security.Utilities.IO.Pem;
using Essensoft.AspNetCore.Security.X509;

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
