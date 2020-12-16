using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSelleradmitAdmittanceQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiSelleradmitAdmittanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 来源系统
        /// </summary>
        [JsonPropertyName("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 合作机构的支付宝id
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 收款方的支付宝id
        /// </summary>
        [JsonPropertyName("payee_alipay_user_id")]
        public string PayeeAlipayUserId { get; set; }

        /// <summary>
        /// 请求标识
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 准入查询场景
        /// </summary>
        [JsonPropertyName("seller_admit_scene")]
        public string SellerAdmitScene { get; set; }

        /// <summary>
        /// 摊位id
        /// </summary>
        [JsonPropertyName("stall_code")]
        public string StallCode { get; set; }

        /// <summary>
        /// 二级商户的id
        /// </summary>
        [JsonPropertyName("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
