namespace Essensoft.AspNetCore.WeChatPay
{
    public class WeChatPayOptions
    {
        /// <summary>
        /// 应用账号(公众账号ID/小程序ID/企业号CorpId)
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 应用秘钥
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// API秘钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// API证书 Base64String
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// RSA公钥
        /// </summary>
        public string RsaPublicKey { get; set; }
    }
}
