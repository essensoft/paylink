using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataDsbEstimateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDsbEstimateQueryModel : AlipayObject
    {
        /// <summary>
        /// 定损单号
        /// </summary>
        [JsonProperty("estimate_no")]
        public string EstimateNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonProperty("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 修理厂类型，枚举如下。    4S－4S店  GENERAL－综合修理厂
        /// </summary>
        [JsonProperty("garage_type")]
        public string GarageType { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("license_no")]
        public string LicenseNo { get; set; }
    }
}
