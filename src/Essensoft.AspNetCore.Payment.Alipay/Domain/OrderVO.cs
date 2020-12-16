using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderVO Data Structure.
    /// </summary>
    public class OrderVO : AlipayObject
    {
        /// <summary>
        /// 订单金额-单位为分
        /// </summary>
        [JsonPropertyName("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 订单申请时间
        /// </summary>
        [JsonPropertyName("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 交易来源传递的交易编号
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("ccy")]
        public string Ccy { get; set; }

        /// <summary>
        /// 订单生效时间
        /// </summary>
        [JsonPropertyName("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单到期时间
        /// </summary>
        [JsonPropertyName("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// CREATE(投标中)/CANCEL(未中标)/VALID(中标)/PAYING(支付中)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
