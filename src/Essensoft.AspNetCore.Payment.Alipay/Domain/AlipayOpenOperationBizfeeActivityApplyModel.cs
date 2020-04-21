using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationBizfeeActivityApplyModel Data Structure.
    /// </summary>
    public class AlipayOpenOperationBizfeeActivityApplyModel : AlipayObject
    {
        /// <summary>
        /// 优惠活动码，由优惠平台创建并分配，对应于某一特定的优惠活动，例如免费提现额度提额活动，由运营同学进行录入，并提供给外部商户
        /// </summary>
        [JsonPropertyName("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 针对免费额度提额活动，对应于需要提升的免费额度的量，最多两位小数
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务发生时间，如当前时间
        /// </summary>
        [JsonPropertyName("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 外部业务号，用作幂等控制，不同的调用需要保证不重复；多次重试的情况下，需要保证该外部业务号相同
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户ID，填写商户的支付宝2088号
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 扩展属性（Map的JSON对象） key和value中不能有英文逗号及等于符号。
        /// </summary>
        [JsonPropertyName("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，即应用优惠的对象，例如免费提现额度提额活动，对应于将额度发放的对象
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
