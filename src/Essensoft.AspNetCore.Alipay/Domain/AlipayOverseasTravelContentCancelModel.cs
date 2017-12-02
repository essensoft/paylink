using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelContentCancelModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelContentCancelModel : AlipayObject
    {
        /// <summary>
        /// 飞猪内容id
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("modified_date")]
        public long ModifiedDate { get; set; }
    }
}
