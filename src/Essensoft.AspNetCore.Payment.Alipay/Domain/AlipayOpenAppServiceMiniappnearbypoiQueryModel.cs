using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbypoiQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServiceMiniappnearbypoiQueryModel : AlipayObject
    {
        /// <summary>
        /// poiCode列表
        /// </summary>
        [JsonPropertyName("poi_code_list")]
        public List<string> PoiCodeList { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
