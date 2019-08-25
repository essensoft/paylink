using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAccountDeviceInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountDeviceInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// idfa或者imei号数组。同一笔请求中，数组中只能是idfa或者imei,不能既有imei，又有idfa
        /// </summary>
        [JsonProperty("device_ids")]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// 设备类型，IMEI、IDFA、MOBILE(大小写敏感）
        /// </summary>
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备id的加密方式，如没有加密，可以不传。一般MD5即可满足需求，如其他方式，请和支付宝技术支持联系
        /// </summary>
        [JsonProperty("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 扩展参数，如设备系统类型，系统版本等,格式为基本字符串组成的json串
        /// </summary>
        [JsonProperty("extra_info")]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// 一般代表调用的合作机构名称，可写简称，大小写敏感
        /// </summary>
        [JsonProperty("request_from")]
        public string RequestFrom { get; set; }
    }
}
