using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppOrderItemQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppOrderItemQueryModel : AlipayObject
    {
        /// <summary>
        /// 机构端订单项id列表
        /// </summary>
        [JsonPropertyName("inst_item_id")]
        public string InstItemId { get; set; }
    }
}
