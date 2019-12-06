using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataDsbEstimateQueryModel Data Structure.
    /// </summary>
    public class AlipayInsDataDsbEstimateQueryModel : AlipayObject
    {
        /// <summary>
        /// 定损单号
        /// </summary>
        [JsonPropertyName("estimate_no")]
        public string EstimateNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonPropertyName("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 修理厂类型，枚举如下。    4S－4S店  GENERAL－综合修理厂
        /// </summary>
        [JsonPropertyName("garage_type")]
        public string GarageType { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("license_no")]
        public string LicenseNo { get; set; }
    }
}
