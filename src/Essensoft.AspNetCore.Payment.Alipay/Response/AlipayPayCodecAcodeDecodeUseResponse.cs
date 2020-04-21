using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPayCodecAcodeDecodeUseResponse.
    /// </summary>
    public class AlipayPayCodecAcodeDecodeUseResponse : AlipayResponse
    {
        /// <summary>
        /// 业务身份标识符
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务机构代码
        /// </summary>
        [JsonPropertyName("biz_inst_code")]
        public string BizInstCode { get; set; }

        /// <summary>
        /// 业务信息，默认为空
        /// </summary>
        [JsonPropertyName("business_info")]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// 码值产生时间(Long型)
        /// </summary>
        [JsonPropertyName("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 发码机构代码
        /// </summary>
        [JsonPropertyName("encode_inst_code")]
        public string EncodeInstCode { get; set; }

        /// <summary>
        /// 码值失效时间(Long型)
        /// </summary>
        [JsonPropertyName("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 支付账户
        /// </summary>
        [JsonPropertyName("pay_account")]
        public string PayAccount { get; set; }

        /// <summary>
        /// 支付账户支付授权时间（Long型）
        /// </summary>
        [JsonPropertyName("pay_account_auth_expire")]
        public long PayAccountAuthExpire { get; set; }

        /// <summary>
        /// 支付金额(单位:元)
        /// </summary>
        [JsonPropertyName("pay_amount_limit")]
        public string PayAmountLimit { get; set; }
    }
}
