using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiseaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DiseaseDTO : AlipayObject
    {
        /// <summary>
        /// 疾病标准编码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 疾病标准名称
        /// </summary>
        [JsonProperty("disease_name")]
        public string DiseaseName { get; set; }
    }
}
