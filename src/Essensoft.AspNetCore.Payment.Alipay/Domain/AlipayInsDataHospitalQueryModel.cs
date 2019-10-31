using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataHospitalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataHospitalQueryModel : AlipayObject
    {
        /// <summary>
        /// 医院所在的地市名称
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [JsonProperty("hospital_name")]
        public string HospitalName { get; set; }
    }
}
