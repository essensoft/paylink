using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceResultGetModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceResultGetModel : AlipayObject
    {
        /// <summary>
        /// 开票申请id
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 业务平台对应的订单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 销售方税号
        /// </summary>
        [JsonPropertyName("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 业务平台code, 由发票中台分配
        /// </summary>
        [JsonPropertyName("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 业务平台商户id
        /// </summary>
        [JsonPropertyName("platform_user_id")]
        public string PlatformUserId { get; set; }
    }
}
