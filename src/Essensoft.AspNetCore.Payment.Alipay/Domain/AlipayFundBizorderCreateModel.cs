using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundBizorderCreateModel Data Structure.
    /// </summary>
    public class AlipayFundBizorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 转账请求的扩展参数，具体请与支付宝工程师联系
        /// </summary>
        [JsonPropertyName("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 业务订单标题，用于在支付宝用户的账单里显示
        /// </summary>
        [JsonPropertyName("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔转账请求，商户需保证该订单号唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务订单所属商户ID
        /// </summary>
        [JsonPropertyName("partner_user_id")]
        public string PartnerUserId { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [JsonPropertyName("payee_info")]
        public Participant PayeeInfo { get; set; }
    }
}
