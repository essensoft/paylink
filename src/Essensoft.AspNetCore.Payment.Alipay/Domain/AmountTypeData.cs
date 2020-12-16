using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AmountTypeData Data Structure.
    /// </summary>
    public class AmountTypeData : AlipayObject
    {
        /// <summary>
        /// 累计类型为金额类型的累计名称。为必传入参。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠信息。为List类型，支持传入多笔优惠，大部分场景传入一笔。包含：优惠名称，优惠类型，优惠金额（单位元）。 字段必传场景： 1.当累计模式为【交易绑定模式】时，为必传入参。 2.当累计模式为【交易解耦模式】，同时需要累计优惠信息时，为必传入参。
        /// </summary>
        [JsonPropertyName("out_discount_infos")]
        public List<ZMGoOutDiscountInfo> OutDiscountInfos { get; set; }

        /// <summary>
        /// 交易信息。包含：交易号，交易金额。 字段必传场景： 1.当累计模式为【交易绑定模式】时，为必传入参。 2.当累计模式为【交易解耦模式】，同时需要累计交易信息时，为必传入参。
        /// </summary>
        [JsonPropertyName("trade_info")]
        public ZMGoTradeInfo TradeInfo { get; set; }
    }
}
