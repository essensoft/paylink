using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 配置选项
    /// </summary>
    public class AlipayOptions
    {
        private string appCert;
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
        /// “公钥证书”方式时，留空
        /// “普通公钥”方式时，必填
        /// </summary>
        public string AlipayPublicKey { get; set; }

        /// <summary>
        /// RSA 应用私钥
        /// </summary>
        public string AppPrivateKey { get; set; }

        /// <summary>
        /// 服务网关地址
        /// 默认为："https://openapi.alipay.com/gateway.do"
        /// </summary>
        public string ServerUrl { get; set; } = "https://openapi.alipay.com/gateway.do";

        /// <summary>
        /// 数据格式
        /// 默认为："json"
        /// </summary>
        public string Format { get; } = "json";

        /// <summary>
        /// 接口版本
        /// 默认为："1.0"
        /// </summary>
        public string Version { get; set; } = "1.0";

        /// <summary>
        /// 签名方式
        /// 默认为："RSA2"
        /// </summary>
        public string SignType { get; set; } = "RSA2";

        /// <summary>
        /// 编码格式
        /// 默认为："utf-8"
        /// </summary>
        public string Charset { get; } = "utf-8";

        /// <summary>
        /// 加密方式
        /// 默认为："AES"
        /// </summary>
        public string EncyptType { get; } = "AES";

        /// <summary>
        /// 加密秘钥
        /// </summary>
        public string EncyptKey { get; set; }

        /// <summary>
        /// 应用公钥证书
        /// 可为 证书文件路径 / 证书文件的文本内容 / 证书文件的Base64编码
        /// “公钥证书”方式时，必填
        /// “普通公钥”方式时，留空
        /// </summary>
        public string AppCert
        {
            get => appCert;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    appCert = value;
                    var appCertificate = AlipayCertUtil.Parse(appCert);
                    AppCertSN = AlipayCertUtil.GetCertSN(appCertificate);
                }
            }
        }

        /// <summary>
        /// 支付宝公钥证书
        /// 可为 证书文件路径 / 证书文件的文本内容 / 证书文件的Base64编码
        /// “公钥证书”方式时，必填
        /// “普通公钥”方式时，留空
        /// </summary>
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
        /// 可为 证书文件路径 / 证书文件的文本内容 / 证书文件的Base64编码
        /// “公钥证书”方式时，必填
        /// “普通公钥”方式时，留空
        /// </summary>
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
