using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ChargeItems Data Structure.
    /// </summary>
    public class ChargeItems : AlipayObject
    {
        /// <summary>
        /// 缴费项名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 缴费项金额
        /// </summary>
        [JsonProperty("item_price")]
        public string ItemPrice { get; set; }
    }
}
