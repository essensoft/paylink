using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SymbolDTO Data Structure.
    /// </summary>
    public class SymbolDTO : AlipayObject
    {
        /// <summary>
        /// 股票code
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 成交单位
        /// </summary>
        [JsonPropertyName("hand")]
        public long Hand { get; set; }

        /// <summary>
        /// 成交单位
        /// </summary>
        [JsonPropertyName("hand_unit")]
        public string HandUnit { get; set; }

        /// <summary>
        /// 上市状态：commons-push-model/src/main/proto/model/symbol.proto
        /// </summary>
        [JsonPropertyName("list_type")]
        public string ListType { get; set; }

        /// <summary>
        /// 市场
        /// </summary>
        [JsonPropertyName("market")]
        public string Market { get; set; }

        /// <summary>
        /// 股票名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 报价单位精度
        /// </summary>
        [JsonPropertyName("price_decimal")]
        public long PriceDecimal { get; set; }

        /// <summary>
        /// 股票子类型
        /// </summary>
        [JsonPropertyName("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 股票唯一代码，symbol=code.market
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// 股票类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
