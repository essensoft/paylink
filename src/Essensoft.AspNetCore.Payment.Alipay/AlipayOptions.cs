using Essensoft.AspNetCore.Payment.Security;
using System.Security.Cryptography;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public class AlipayOptions
    {
        public static readonly string DefaultClientName = "Payment.Alipay.Client";

        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        private string rsaPublicKey;
        /// <summary>
        /// 支付宝公钥
        /// </summary>
        public string RsaPublicKey {
            get
            {
                return rsaPublicKey;
            }
            set
            {
                rsaPublicKey = value;
                PublicRSAParameters = RSAUtilities.GetRSAParametersFormPublicKey(RsaPublicKey);
            }
        }

        internal RSAParameters PublicRSAParameters;
        

        private string rsaPrivateKey;
        /// <summary>
        /// 应用私钥
        /// </summary>
        public string RsaPrivateKey {
            get {
                return rsaPrivateKey;
            }
            set {
                rsaPrivateKey = value;
                PrivateRSAParameters = RSAUtilities.GetRSAParametersFormPrivateKey(rsaPrivateKey);
            }
        }

        internal RSAParameters PrivateRSAParameters;
        

        /// <summary>
        /// 服务地址
        /// </summary>
        public string ServerUrl { get; set; } = "https://openapi.alipay.com/gateway.do";

        /// <summary>
        /// 数据格式
        /// </summary>
        public string Format { get; set; } = "json";

        /// <summary>
        /// 接口版本
        /// </summary>
        public string Version { get; set; } = "1.0";

        /// <summary>
        /// 签名方式
        /// </summary>
        public string SignType { get; set; } = "RSA2";

        /// <summary>
        /// 编码格式
        /// </summary>
        public string Charset { get; } = "utf-8";

        /// <summary>
        /// 加密方式
        /// </summary>
        public string EncyptType { get; } = "AES";

        /// <summary>
        /// 加密秘钥
        /// </summary>
        public string EncyptKey { get; set; }
    }
}
