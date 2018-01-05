using System;
using System.IO;

using Essensoft.AspNetCore.Security.Asn1;
using Essensoft.AspNetCore.Security.Asn1.Cms;
using Essensoft.AspNetCore.Security.Asn1.X509;
using Essensoft.AspNetCore.Security.Crypto;
using Essensoft.AspNetCore.Security.Crypto.Generators;
using Essensoft.AspNetCore.Security.Crypto.IO;
using Essensoft.AspNetCore.Security.Crypto.Parameters;
using Essensoft.AspNetCore.Security.Security;
using Essensoft.AspNetCore.Security.Utilities;
using Essensoft.AspNetCore.Security.Utilities.IO;

namespace Essensoft.AspNetCore.Security.Cms
{
	/**
	 * General class for generating a CMS authenticated-data message.
	 *
	 * A simple example of usage.
	 *
	 * <pre>
	 *      CMSAuthenticatedDataGenerator  fact = new CMSAuthenticatedDataGenerator();
	 *
	 *      fact.addKeyTransRecipient(cert);
	 *
	 *      CMSAuthenticatedData         data = fact.generate(content, algorithm, "BC");
	 * </pre>
	 */
	public class CmsAuthenticatedDataGenerator
	    : CmsAuthenticatedGenerator
	{
	    /**
	     * base constructor
	     */
	    public CmsAuthenticatedDataGenerator()
	    {
	    }

	    /**
	     * constructor allowing specific source of randomness
	     * @param rand instance of SecureRandom to use
	     */
	    public CmsAuthenticatedDataGenerator(
	        SecureRandom rand)
	        : base(rand)
	    {
	    }

	    /**
	     * generate an enveloped object that contains an CMS Enveloped Data
	     * object using the given provider and the passed in key generator.
	     */
		private CmsAuthenticatedData Generate(
			CmsProcessable		content,
			string				macOid,
			CipherKeyGenerator	keyGen)
		{
			AlgorithmIdentifier macAlgId;
			KeyParameter encKey;
			Asn1OctetString encContent;
			Asn1OctetString macResult;

			try
			{
				// FIXME Will this work for macs?
				byte[] encKeyBytes = keyGen.GenerateKey();
				encKey = ParameterUtilities.CreateKeyParameter(macOid, encKeyBytes);

				Asn1Encodable asn1Params = GenerateAsn1Parameters(macOid, encKeyBytes);

				ICipherParameters cipherParameters;
				macAlgId = GetAlgorithmIdentifier(
				macOid, encKey, asn1Params, out cipherParameters);

				IMac mac = MacUtilities.GetMac(macOid);
				// TODO Confirm no ParametersWithRandom needed
				// FIXME Only passing key at the moment
//	            mac.Init(cipherParameters);
				mac.Init(encKey);

				MemoryStream bOut = new MemoryStream();
				Stream mOut = new TeeOutputStream(bOut, new MacOutputStream(mac));

				content.Write(mOut);

                Platform.Dispose(mOut);

                encContent = new BerOctetString(bOut.ToArray());

				byte[] macOctets = MacUtilities.DoFinal(mac);
				macResult = new DerOctetString(macOctets);
			}
			catch (SecurityUtilityException e)
			{
				throw new CmsException("couldn't create cipher.", e);
			}
			catch (InvalidKeyException e)
			{
				throw new CmsException("key invalid in message.", e);
			}
			catch (IOException e)
			{
				throw new CmsException("exception decoding algorithm parameters.", e);
			}

			Asn1EncodableVector recipientInfos = new Asn1EncodableVector();

			foreach (RecipientInfoGenerator rig in recipientInfoGenerators) 
			{
				try
				{
					recipientInfos.Add(rig.Generate(encKey, rand));
				}
				catch (InvalidKeyException e)
				{
					throw new CmsException("key inappropriate for algorithm.", e);
				}
				catch (GeneralSecurityException e)
				{
					throw new CmsException("error making encrypted content.", e);
				}
			}
			
			ContentInfo eci = new ContentInfo(CmsObjectIdentifiers.Data, encContent);
			
			ContentInfo contentInfo = new ContentInfo(
			CmsObjectIdentifiers.AuthenticatedData,
			new AuthenticatedData(null, new DerSet(recipientInfos), macAlgId, null, eci, null, macResult, null));
			
			return new CmsAuthenticatedData(contentInfo);
		}

	    /**
	     * generate an authenticated object that contains an CMS Authenticated Data object
	     */
	    public CmsAuthenticatedData Generate(
	        CmsProcessable	content,
	        string			encryptionOid)
	    {
            try
            {
				// FIXME Will this work for macs?
				CipherKeyGenerator keyGen = GeneratorUtilities.GetKeyGenerator(encryptionOid);

				keyGen.Init(new KeyGenerationParameters(rand, keyGen.DefaultStrength));

				return Generate(content, encryptionOid, keyGen);
            }
            catch (SecurityUtilityException e)
            {
                throw new CmsException("can't find key generation algorithm.", e);
            }
	    }
	}
}
