using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TravelScene Data Structure.
    /// </summary>
    public class TravelScene : AlipayObject
    {
        /// <summary>
        /// 出行场景，综合体入参列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<TravelMallRequest> DataList { get; set; }
    }
}
