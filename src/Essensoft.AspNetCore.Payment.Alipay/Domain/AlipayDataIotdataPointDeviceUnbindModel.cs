using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataIotdataPointDeviceUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataPointDeviceUnbindModel : AlipayObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonProperty("business_id")]
        public long BusinessId { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [JsonProperty("point_id")]
        public long PointId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }
    }
}
