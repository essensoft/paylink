using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishSpecgroupSyncResponse.
    /// </summary>
    public class KoubeiCateringDishSpecgroupSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 12323
        /// </summary>
        [JsonPropertyName("kbdish_spec_group_id")]
        public string KbdishSpecGroupId { get; set; }
    }
}
