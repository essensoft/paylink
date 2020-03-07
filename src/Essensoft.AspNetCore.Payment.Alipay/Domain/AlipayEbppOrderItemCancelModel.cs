using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppOrderItemCancelModel Data Structure.
    /// </summary>
    public class AlipayEbppOrderItemCancelModel : AlipayObject
    {
        /// <summary>
        /// 机构订单子项id
        /// </summary>
        [JsonPropertyName("inst_item_id")]
        public string InstItemId { get; set; }
    }
}
