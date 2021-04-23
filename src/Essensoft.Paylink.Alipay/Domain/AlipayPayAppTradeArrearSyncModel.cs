using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPayAppTradeArrearSyncModel Data Structure.
    /// </summary>
    public class AlipayPayAppTradeArrearSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 商品摘要。格式参照示例，多款商品则使用逗号分隔。用于催缴展示给用户
        /// </summary>
        [JsonPropertyName("goods_digest")]
        public string GoodsDigest { get; set; }

        /// <summary>
        /// 收款商户名称，用户通知用户页面展示，请务必传正确
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
