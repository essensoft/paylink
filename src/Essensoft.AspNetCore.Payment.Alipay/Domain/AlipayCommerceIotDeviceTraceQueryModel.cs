using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceTraceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceTraceQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一标识，设备id
        /// </summary>
        [JsonProperty("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 查询轨迹的结束时间.必须在当前时间的1小时之内
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询轨迹的开始时间. 必须在当前时间的1小时之内
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
