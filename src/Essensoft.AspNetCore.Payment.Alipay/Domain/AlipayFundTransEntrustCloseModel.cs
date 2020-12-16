using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransEntrustCloseModel Data Structure.
    /// </summary>
    public class AlipayFundTransEntrustCloseModel : AlipayObject
    {
        /// <summary>
        /// CREDIT_SALE_REPAY
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 该笔委托支付在支付宝系统内部的单据ID（委托支付打款场景必传）
        /// </summary>
        [JsonPropertyName("entrust_order_id")]
        public string EntrustOrderId { get; set; }

        /// <summary>
        /// 业务产品码，委托支付传ENTRUSTED_PAYMENT_COLLECTION
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
