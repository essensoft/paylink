using System;
using System.Collections;
using System.IO;
using System.Text;

using Essensoft.AspNetCore.Security.Asn1;
using Essensoft.AspNetCore.Security.Asn1.X509;
using Essensoft.AspNetCore.Security.Crypto.Agreement;
using Essensoft.AspNetCore.Security.Crypto.Agreement.Srp;
using Essensoft.AspNetCore.Security.Crypto.Digests;
using Essensoft.AspNetCore.Security.Crypto.Encodings;
using Essensoft.AspNetCore.Security.Crypto.Engines;
using Essensoft.AspNetCore.Security.Crypto.Generators;
using Essensoft.AspNetCore.Security.Crypto.IO;
using Essensoft.AspNetCore.Security.Crypto.Parameters;
using Essensoft.AspNetCore.Security.Crypto.Prng;
using Essensoft.AspNetCore.Security.Math;
using Essensoft.AspNetCore.Security.Security;
using Essensoft.AspNetCore.Security.Utilities;
using Essensoft.AspNetCore.Security.Utilities.Date;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
    [Obsolete("Use 'TlsClientProtocol' instead")]
    public class TlsProtocolHandler
        :   TlsClientProtocol
    {
        public TlsProtocolHandler(Stream stream, SecureRandom secureRandom)
            :   base(stream, stream, secureRandom)
        {
        }

        /// <remarks>Both streams can be the same object</remarks>
        public TlsProtocolHandler(Stream input, Stream output, SecureRandom	secureRandom)
            :   base(input, output, secureRandom)
        {
        }
    }
}
