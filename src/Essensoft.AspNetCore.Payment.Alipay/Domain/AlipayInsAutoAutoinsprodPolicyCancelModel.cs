using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyCancelModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoinsprodPolicyCancelModel : AlipayObject
    {
        /// <summary>
        /// 车险订单号
        /// </summary>
        [JsonProperty("trade_biz_id")]
        public string TradeBizId { get; set; }
    }
}
