using Essensoft.AspNetCore.Payment.Alipay.Utility;
using Org.BouncyCastle.X509;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 选项。
    /// </summary>
    public class AlipayOptions
    {
        internal string AppCertSN;
        internal X509Certificate AlipayPublicCertificate;
        internal string AlipayPublicCertSN;
        internal string AlipayPublicCertKey;
        internal string RootCertSN;

        private string appCert;
        private string alipayPublicCert;
        private string rootCert;

        /// <summary>
        /// 蚂蚁金服开放平台 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// RSA 支付宝公钥
        /// </summary>
        public string AlipayPublicKey { get; set; }

        /// <summary>
        /// RSA 应用私钥
        /// </summary>
        public string AppPrivateKey { get; set; }

        /// <summary>
        /// 服务地址
        /// "https://openapi.alipay.com/gateway.do"
        /// </summary>
        public string ServerUrl { get; set; } = "https://openapi.alipay.com/gateway.do";

        /// <summary>
        /// 数据格式
        /// "json"
        /// </summary>
        public string Format { get; } = "json";

        /// <summary>
        /// 接口版本
        /// "1.0"
        /// </summary>
        public string Version { get; set; } = "1.0";

        /// <summary>
        /// 签名方式
        /// "RSA2"
        /// </summary>
        public string SignType { get; set; } = "RSA2";

        /// <summary>
        /// 编码格式
        /// "utf-8"
        /// </summary>
        public string Charset { get; } = "utf-8";

        /// <summary>
        /// 加密方式
        /// "AES"
        /// </summary>
        public string EncyptType { get; } = "AES";

        /// <summary>
        /// 加密秘钥
        /// </summary>
        public string EncyptKey { get; set; }

        /// <summary>
        /// 商户证书
        /// </summary>
        public string AppCert
        {
            get => appCert;
            set
            {
                appCert = value;
                if (!string.IsNullOrEmpty(value))
                {
                    var cert = AntCertificationUtil.ParseCert(value);
                    AppCertSN = AntCertificationUtil.GetCertSN(cert);
                }
            }
        }

        /// <summary>
        /// 公钥证书
        /// </summary>
        public string AlipayPublicCert
        {
            get => alipayPublicCert;
            set
            {
                alipayPublicCert = value;
                if (!string.IsNullOrEmpty(value))
                {
                    AlipayPublicCertificate = AntCertificationUtil.ParseCert(value);
                    AlipayPublicCertSN = AntCertificationUtil.GetCertSN(AlipayPublicCertificate);
                    AlipayPublicCertKey = AntCertificationUtil.ExtractPemPublicKeyFromCert(AlipayPublicCertificate);
                }
            }
        }

        /// <summary>
        /// 根证书
        /// </summary>
        public string RootCert
        {
            get => rootCert;
            set
            {
                rootCert = value;
                if (!string.IsNullOrEmpty(value))
                {
                    RootCertSN = AntCertificationUtil.GetRootCertSN(value);
                }
            }
        }
    }
}
