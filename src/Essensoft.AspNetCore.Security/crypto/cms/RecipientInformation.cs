using System;
using System.IO;

using Essensoft.AspNetCore.Security.Asn1;
using Essensoft.AspNetCore.Security.Asn1.Nist;
using Essensoft.AspNetCore.Security.Asn1.Pkcs;
using Essensoft.AspNetCore.Security.Asn1.X509;
using Essensoft.AspNetCore.Security.Crypto;
using Essensoft.AspNetCore.Security.Crypto.IO;
using Essensoft.AspNetCore.Security.Crypto.Parameters;
using Essensoft.AspNetCore.Security.Security;
using Essensoft.AspNetCore.Security.Utilities;
using Essensoft.AspNetCore.Security.Utilities.Collections;

namespace Essensoft.AspNetCore.Security.Cms
{
    public abstract class RecipientInformation
    {
		internal RecipientID			rid = new RecipientID();
		internal AlgorithmIdentifier	keyEncAlg;
		internal CmsSecureReadable		secureReadable;
		
		private byte[] resultMac;

		internal RecipientInformation(
			AlgorithmIdentifier	keyEncAlg,
			CmsSecureReadable	secureReadable)
		{
			this.keyEncAlg = keyEncAlg;
			this.secureReadable = secureReadable;
		}

		internal string GetContentAlgorithmName()
		{
			AlgorithmIdentifier algorithm = secureReadable.Algorithm;
//			return CmsEnvelopedHelper.Instance.GetSymmetricCipherName(algorithm.Algorithm.Id);
			return algorithm.Algorithm.Id;
		}

		public RecipientID RecipientID
        {
			get { return rid; }
        }

		public AlgorithmIdentifier KeyEncryptionAlgorithmID
		{
			get { return keyEncAlg; }
		}

		/**
        * return the object identifier for the key encryption algorithm.
        * 
		* @return OID for key encryption algorithm.
        */
        public string KeyEncryptionAlgOid
        {
            get { return keyEncAlg.Algorithm.Id; }
        }

		/**
        * return the ASN.1 encoded key encryption algorithm parameters, or null if
        * there aren't any.
        * 
		* @return ASN.1 encoding of key encryption algorithm parameters.
        */
		public Asn1Object KeyEncryptionAlgParams
		{
			get
			{
				Asn1Encodable ae = keyEncAlg.Parameters;

				return ae == null ? null : ae.ToAsn1Object();
			}
		}

		internal CmsTypedStream GetContentFromSessionKey(
			KeyParameter sKey)
		{
			CmsReadable readable = secureReadable.GetReadable(sKey); 

			try
			{
				return new CmsTypedStream(readable.GetInputStream());
			}
			catch (IOException e)
			{
				throw new CmsException("error getting .", e);
			}
		}

		public byte[] GetContent(
            ICipherParameters key)
        {
            try
            {
				return CmsUtilities.StreamToByteArray(GetContentStream(key).ContentStream);
            }
            catch (IOException e)
            {
                throw new Exception("unable to parse internal stream: " + e);
            }
        }

		/**
		* Return the MAC calculated for the content stream. Note: this call is only meaningful once all
		* the content has been read.
		*
		* @return  byte array containing the mac.
		*/
		public byte[] GetMac()
		{
			if (resultMac == null)
			{
				object cryptoObject = secureReadable.CryptoObject;
				if (cryptoObject is IMac)
				{
					resultMac = MacUtilities.DoFinal((IMac)cryptoObject);
				}
			}

			return Arrays.Clone(resultMac);
		}
		
		public abstract CmsTypedStream GetContentStream(ICipherParameters key);
	}
}
