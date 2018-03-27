using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayOptions
    {
        /// <summary>
        /// 应用账号(公众账号ID/小程序ID/企业号CorpId)
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// API秘钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// API证书文件 Base64字符串
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// RSA公钥 企业付款到银行卡
        /// </summary>
        public string RsaPublicKey { get; set; }
    }
}
