using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationCategorySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveClassificationCategorySyncModel : AlipayObject
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 垃圾数据
        /// </summary>
        [JsonProperty("rubbish_list")]
        public List<RubbishDTO> RubbishList { get; set; }
    }
}
