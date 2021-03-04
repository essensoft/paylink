using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosDishgroupSyncResponse.
    /// </summary>
    public class KoubeiCateringPosDishgroupSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 返回对应的组合菜ID
        /// </summary>
        [JsonPropertyName("dish_group_id")]
        public string DishGroupId { get; set; }
    }
}
