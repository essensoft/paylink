using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HospitalDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HospitalDTO : AlipayObject
    {
        /// <summary>
        /// 医院标准名称
        /// </summary>
        [JsonProperty("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 医院等级，一级医院、二级医院、三级医院、其他
        /// </summary>
        [JsonProperty("level")]
        public string Level { get; set; }

        /// <summary>
        /// 医院性质：公立医院、私立医院、其他
        /// </summary>
        [JsonProperty("ownership")]
        public string Ownership { get; set; }
    }
}
