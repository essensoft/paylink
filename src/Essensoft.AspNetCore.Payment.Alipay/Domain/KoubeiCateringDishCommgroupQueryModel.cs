using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishCommgroupQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishCommgroupQueryModel : AlipayObject
    {
        /// <summary>
        /// 需要查询的组id
        /// </summary>
        [JsonPropertyName("comm_group_id")]
        public string CommGroupId { get; set; }

        /// <summary>
        /// 查询页码，表示第几页
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，表示每页查询数量，不超过50
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }
    }
}
