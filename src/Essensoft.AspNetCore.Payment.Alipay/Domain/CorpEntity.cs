using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CorpEntity Data Structure.
    /// </summary>
    public class CorpEntity : AlipayObject
    {
        /// <summary>
        /// 企业支付宝登录账号(邮箱或手机号)
        /// </summary>
        [JsonPropertyName("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 企业统一社会信用编码
        /// </summary>
        [JsonPropertyName("corp_code")]
        public string CorpCode { get; set; }

        /// <summary>
        /// xxx测试公司
        /// </summary>
        [JsonPropertyName("corp_name")]
        public string CorpName { get; set; }
    }
}
