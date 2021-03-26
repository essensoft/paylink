using Essensoft.Paylink.Alipay.Utility;

namespace Essensoft.Paylink.Alipay
{
    /// <summary>
    /// Alipay 配置选项
    /// </summary>
    public class AlipayOptions
    {
        private string appPublicCert;
        private string alipayPublicCert;
        private string alipayRootCert;

        internal string AppCertSN;
        internal string AlipayPublicCertSN;
        internal string AlipayRootCertSN;

        /// <summary>
        /// 应用Id
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// RSA 支付宝公钥
        /// </summary>
        /// <remarks>
        /// “公钥证书”方式时, 留空
        /// “普通公钥”方式时, 必填
        /// </remarks>
        public string AlipayPublicKey { get; set; }

        /// <summary>
        /// RSA 应用私钥
        /// </summary>
        public string AppPrivateKey { get; set; }

        /// <summary>
        /// 服务网关地址
        /// </summary>
        /// <remarks>
        /// 默认为正式环境："https://openapi.alipay.com/gateway.do"
        /// </remarks>
        public string ServerUrl { get; set; } = "https://openapi.alipay.com/gateway.do";

        /// <summary>
        /// 数据格式
        /// </summary>
        /// <remarks>
        /// 默认为："json"
        /// </remarks>
        public string Format { get; } = "json";

        /// <summary>
        /// 接口版本
        /// </summary>
        /// <remarks>
        /// 默认为："1.0"
        /// </remarks>
        public string Version { get; set; } = "1.0";

        /// <summary>
        /// 签名方式
        /// </summary>
        /// <remarks>
        /// 默认为："RSA2"
        /// </remarks>
        public string SignType { get; set; } = "RSA2";

        /// <summary>
        /// 编码格式
        /// </summary>
        /// <remarks>
        /// 默认为："utf-8"
        /// </remarks>
        public string Charset { get; } = "utf-8";

        /// <summary>
        /// 加密方式
        /// </summary>
        /// <remarks>
        /// 默认为："AES"
        /// </remarks>
        public string EncyptType { get; } = "AES";

        /// <summary>
        /// 加密秘钥
        /// </summary>
        public string EncyptKey { get; set; }

        /// <summary>
        /// 应用公钥证书
        /// </summary>
        /// <remarks>
        /// 可为 证书文件路径 / 证书文件的文本内容 / 证书文件的Base64编码。
        /// “公钥证书”方式时，必填
        /// “普通公钥”方式时，留空
        /// </remarks>
        public string AppPublicCert
        {
            get => appPublicCert;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    appPublicCert = value;
                    var appCertificate = AlipayCertUtil.Parse(appPublicCert);
                    AppCertSN = AlipayCertUtil.GetCertSN(appCertificate);
                }
            }
        }

        /// <summary>
        /// 支付宝公钥证书
        /// </summary>
        /// <remarks>
        /// 可为 证书文件路径 / 证书文件的文本内容 / 证书文件的Base64编码。
        /// “公钥证书”方式时，必填
        /// “普通公钥”方式时，留空
        /// </remarks>
        public string AlipayPublicCert
        {
            get => alipayPublicCert;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    alipayPublicCert = value;
                    var alipayPublicCertificate = AlipayCertUtil.Parse(alipayPublicCert);
                    AlipayPublicCertSN = AlipayCertUtil.GetCertSN(alipayPublicCertificate);
                    AlipayPublicKey = AlipayCertUtil.GetCertPublicKey(alipayPublicCertificate);
                }
            }
        }

        /// <summary>
        /// 支付宝根证书
        /// </summary>
        /// <remarks>
        /// 可为 证书文件路径 / 证书文件的文本内容 / 证书文件的Base64编码。
        /// “公钥证书”方式时，必填
        /// “普通公钥”方式时，留空
        /// </remarks>
        public string AlipayRootCert
        {
            get => alipayRootCert;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    alipayRootCert = value;
                    AlipayRootCertSN = AlipayCertUtil.GetRootCertSN(alipayRootCert);
                }
            }
        }
    }
}
