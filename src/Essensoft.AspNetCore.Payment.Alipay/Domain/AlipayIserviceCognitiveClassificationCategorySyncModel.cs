using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationCategorySyncModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveClassificationCategorySyncModel : AlipayObject
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 垃圾数据
        /// </summary>
        [JsonPropertyName("rubbish_list")]
        public List<RubbishDTO> RubbishList { get; set; }
    }
}
