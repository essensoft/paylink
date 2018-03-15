namespace Essensoft.AspNetCore.UnionPay
{
    public class UnionPayOptions
    {
        /// <summary>
        /// 商户代码
        /// </summary>
        public string MerId { get; set; }

        /// <summary>
        /// 接入类型
        /// 0：普通商户直连接入
        /// 2：平台类商户接入
        /// </summary>
        public string AccessType { get; set; } = "0";

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; } = "5.1.0";

        /// <summary>
        /// 编码方式
        /// </summary>
        public string Encoding { get; } = "UTF-8";

        /// <summary>
        /// 签名方法
        /// 01（表示采用RSA签名）
        /// HASH表示散列算法
        /// 11：支持散列方式验证SHA-256
        /// 12：支持散列方式验证SM3
        /// </summary>
        public string SignMethod { get; set; } = "01";

        /// <summary>
        /// 签名证书 
        /// </summary>
        public string SignCert { get; set; }

        /// <summary>
        /// 签名证书密码
        /// </summary>
        public string SignCertPassword { get; set; }

        /// <summary>
        /// 加密证书 
        /// </summary>
        public string EncryptCert { get; set; }

        /// <summary>
        /// 验签中级证书
        /// </summary>
        public string MiddleCert { get; set; }

        /// <summary>
        /// 验签根证书 
        /// </summary>
        public string RootCert { get; set; }

        /// <summary>
        /// 散列方式签名密钥
        /// </summary>
        public string SecureKey { get; set; }

        /// <summary>
        /// 测试模式
        /// </summary>
        public bool TestMode { get; set; }
    }
}
