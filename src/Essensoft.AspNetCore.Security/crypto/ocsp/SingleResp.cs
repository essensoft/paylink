using System;
using System.Collections;

using Essensoft.AspNetCore.Security.Asn1;
using Essensoft.AspNetCore.Security.Asn1.Ocsp;
using Essensoft.AspNetCore.Security.Asn1.X509;
using Essensoft.AspNetCore.Security.Utilities.Date;
using Essensoft.AspNetCore.Security.X509;

namespace Essensoft.AspNetCore.Security.Ocsp
{
	public class SingleResp
		: X509ExtensionBase
	{
		internal readonly SingleResponse resp;

		public SingleResp(
			SingleResponse resp)
		{
			this.resp = resp;
		}

		public CertificateID GetCertID()
		{
			return new CertificateID(resp.CertId);
		}

		/**
		 * Return the status object for the response - null indicates good.
		 *
		 * @return the status object for the response, null if it is good.
		 */
		public object GetCertStatus()
		{
			CertStatus s = resp.CertStatus;

			if (s.TagNo == 0)
			{
				return null;            // good
			}

			if (s.TagNo == 1)
			{
				return new RevokedStatus(RevokedInfo.GetInstance(s.Status));
			}

			return new UnknownStatus();
		}

		public DateTime ThisUpdate
		{
			get { return resp.ThisUpdate.ToDateTime(); }
		}

		/**
		* return the NextUpdate value - note: this is an optional field so may
		* be returned as null.
		*
		* @return nextUpdate, or null if not present.
		*/
		public DateTimeObject NextUpdate
		{
			get
			{
				return resp.NextUpdate == null
					?	null
					:	new DateTimeObject(resp.NextUpdate.ToDateTime());
			}
		}

		public X509Extensions SingleExtensions
		{
			get { return resp.SingleExtensions; }
		}

		protected override X509Extensions GetX509Extensions()
		{
			return SingleExtensions;
		}
	}
}
