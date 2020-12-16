using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransInvoiceStatusModifyModel Data Structure.
    /// </summary>
    public class AlipayFundTransInvoiceStatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 票据代码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 票据号码
        /// </summary>
        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// 用户身份标识类型，当user_id为空时，此字段必须传值。 1 身份证
        /// </summary>
        [JsonPropertyName("payer_id_type")]
        public string PayerIdType { get; set; }

        /// <summary>
        /// 用户标识值，当user_id为空时此字段必须传值，且值与payer_id_type对应，例如身份证号。  如
        /// </summary>
        [JsonPropertyName("payer_id_value")]
        public string PayerIdValue { get; set; }

        /// <summary>
        /// 2-作废 3-报销 4-换开 5-红冲 其他状态待添加
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID,当此字段为空时，payer_id_type,payer_id_value不能为空
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [JsonPropertyName("verify")]
        public string Verify { get; set; }
    }
}
