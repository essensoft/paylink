using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoUserOilQueryResponse.
    /// </summary>
    public class AlipayInsAutoUserOilQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 累计攒油量（不包含未收取油量）
        /// </summary>
        [JsonPropertyName("accum_oil")]
        public long AccumOil { get; set; }

        /// <summary>
        /// 当前可兑换油量
        /// </summary>
        [JsonPropertyName("current_oil")]
        public long CurrentOil { get; set; }

        /// <summary>
        /// 当前总油量（包含当前可兑换油量及未收取的油量 currentOil + unpickOil）
        /// </summary>
        [JsonPropertyName("total_oil")]
        public long TotalOil { get; set; }

        /// <summary>
        /// 未收取油滴
        /// </summary>
        [JsonPropertyName("unpick_oil")]
        public long UnpickOil { get; set; }

        /// <summary>
        /// 当前已使用油量
        /// </summary>
        [JsonPropertyName("use_oil")]
        public long UseOil { get; set; }
    }
}
