using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPoiQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniPoiQueryModel : AlipayObject
    {
        /// <summary>
        /// 页码，起始页码为1
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小，默认为10
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }
    }
}
