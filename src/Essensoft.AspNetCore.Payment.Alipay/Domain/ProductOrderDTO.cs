using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProductOrderDTO Data Structure.
    /// </summary>
    public class ProductOrderDTO : AlipayObject
    {
        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonPropertyName("active_datetime")]
        public string ActiveDatetime { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [JsonPropertyName("inactive_datetime")]
        public string InactiveDatetime { get; set; }

        /// <summary>
        /// 订购编号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订购者支付宝ID
        /// </summary>
        [JsonPropertyName("order_user_id")]
        public string OrderUserId { get; set; }

        /// <summary>
        /// 订购平台
        /// </summary>
        [JsonPropertyName("ordered_channel")]
        public string OrderedChannel { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [JsonPropertyName("ordering_datetime")]
        public string OrderingDatetime { get; set; }

        /// <summary>
        /// 外部商户ID
        /// </summary>
        [JsonPropertyName("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("ps_code")]
        public string PsCode { get; set; }

        /// <summary>
        /// 合约状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
