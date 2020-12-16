using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillIstddetailQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceLogisticsWaybillIstddetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商家门店编号
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        [JsonPropertyName("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
