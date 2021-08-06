using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchBoxMarketingchangeOptStatusReq Data Structure.
    /// </summary>
    public class SearchBoxMarketingchangeOptStatusReq : AlipayObject
    {
        /// <summary>
        /// 需修改至何种状态(支持撤销和删除)
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
