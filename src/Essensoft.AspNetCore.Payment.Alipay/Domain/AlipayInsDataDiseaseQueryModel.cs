using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataDiseaseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDiseaseQueryModel : AlipayObject
    {
        /// <summary>
        /// 疾病名称
        /// </summary>
        [JsonProperty("disease_name")]
        public string DiseaseName { get; set; }

        /// <summary>
        /// 分页使用，页码，1开始
        /// </summary>
        [JsonProperty("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 页码大小，最大50
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
