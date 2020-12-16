using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceValidpageQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServiceValidpageQueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页显示多少条
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonPropertyName("region_codes")]
        public List<string> RegionCodes { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }
    }
}
