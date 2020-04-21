using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketMcommentQueryModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketMcommentQueryModel : AlipayObject
    {
        /// <summary>
        /// 调用途径：  1：当值为ISV表示isv途径调用  2：当值为PROVIDER表示服务商调用
        /// </summary>
        [JsonPropertyName("op_role")]
        public string OpRole { get; set; }

        /// <summary>
        /// 字段涵义：当前交易对应的商户partner_id  仅op_role='PROVIDER'必须传入
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
