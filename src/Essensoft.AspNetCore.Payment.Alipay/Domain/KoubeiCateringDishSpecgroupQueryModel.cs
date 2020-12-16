using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishSpecgroupQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishSpecgroupQueryModel : AlipayObject
    {
        /// <summary>
        /// 规则标签明细的id，比如「特别热」的字典id，当传入时，也做为查询参数
        /// </summary>
        [JsonPropertyName("detail_spec_id")]
        public string DetailSpecId { get; set; }

        /// <summary>
        /// 规格组的id，当传入时，也做为查询条件，只查询当前规格组下的明细
        /// </summary>
        [JsonPropertyName("group_spec_id")]
        public string GroupSpecId { get; set; }
    }
}
