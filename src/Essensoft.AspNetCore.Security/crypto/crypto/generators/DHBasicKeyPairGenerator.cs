using System;

using Essensoft.AspNetCore.Security.Crypto.Parameters;
using Essensoft.AspNetCore.Security.Math;

namespace Essensoft.AspNetCore.Security.Crypto.Generators
{
    /**
     * a basic Diffie-Hellman key pair generator.
     *
     * This generates keys consistent for use with the basic algorithm for
     * Diffie-Hellman.
     */
    public class DHBasicKeyPairGenerator
		: IAsymmetricCipherKeyPairGenerator
    {
        private DHKeyGenerationParameters param;

        public virtual void Init(
			KeyGenerationParameters parameters)
        {
            this.param = (DHKeyGenerationParameters)parameters;
        }

        public virtual AsymmetricCipherKeyPair GenerateKeyPair()
        {
			DHKeyGeneratorHelper helper = DHKeyGeneratorHelper.Instance;
			DHParameters dhp = param.Parameters;

			BigInteger x = helper.CalculatePrivate(dhp, param.Random);
			BigInteger y = helper.CalculatePublic(dhp, x);

			return new AsymmetricCipherKeyPair(
                new DHPublicKeyParameters(y, dhp),
                new DHPrivateKeyParameters(x, dhp));
        }
    }
}
