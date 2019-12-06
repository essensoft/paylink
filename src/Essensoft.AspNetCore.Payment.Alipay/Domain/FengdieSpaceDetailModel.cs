using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSpaceDetailModel Data Structure.
    /// </summary>
    public class FengdieSpaceDetailModel : AlipayObject
    {
        /// <summary>
        /// 空间可用域名列表，云凤蝶站点发布后链接可用采用的域名
        /// </summary>
        [JsonPropertyName("domains")]
        public List<FengdieSpaceDomains> Domains { get; set; }

        /// <summary>
        /// 空间创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 空间 ID
        /// </summary>
        [JsonPropertyName("space_id")]
        public string SpaceId { get; set; }

        /// <summary>
        /// 空间标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
