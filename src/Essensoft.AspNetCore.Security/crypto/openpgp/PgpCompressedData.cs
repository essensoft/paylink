using System.IO;

using Essensoft.AspNetCore.Security.Apache.Bzip2;
using Essensoft.AspNetCore.Security.Utilities.Zlib;

namespace Essensoft.AspNetCore.Security.Bcpg.OpenPgp
{
	/// <remarks>Compressed data objects</remarks>
    public class PgpCompressedData
		: PgpObject
    {
        private readonly CompressedDataPacket data;

		public PgpCompressedData(
            BcpgInputStream bcpgInput)
        {
            data = (CompressedDataPacket) bcpgInput.ReadPacket();
        }

		/// <summary>The algorithm used for compression</summary>
        public CompressionAlgorithmTag Algorithm
        {
			get { return data.Algorithm; }
        }

		/// <summary>Get the raw input stream contained in the object.</summary>
        public Stream GetInputStream()
        {
            return data.GetInputStream();
        }

		/// <summary>Return an uncompressed input stream which allows reading of the compressed data.</summary>
        public Stream GetDataStream()
        {
            switch (Algorithm)
            {
				case CompressionAlgorithmTag.Uncompressed:
					return GetInputStream();
				case CompressionAlgorithmTag.Zip:
					return new ZInputStream(GetInputStream(), true);
                case CompressionAlgorithmTag.ZLib:
					return new ZInputStream(GetInputStream());
				case CompressionAlgorithmTag.BZip2:
					return new CBZip2InputStream(GetInputStream());
                default:
                    throw new PgpException("can't recognise compression algorithm: " + Algorithm);
            }
        }
    }
}
