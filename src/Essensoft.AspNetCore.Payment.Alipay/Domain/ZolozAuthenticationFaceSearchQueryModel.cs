using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationFaceSearchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationFaceSearchQueryModel : AlipayObject
    {
        /// <summary>
        /// 人脸图片采集后的加密字符串
        /// </summary>
        [JsonProperty("blob")]
        public string Blob { get; set; }

        /// <summary>
        /// 商户设备编码
        /// </summary>
        [JsonProperty("device_num")]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 机具分组编码
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// zim唯一标识
        /// </summary>
        [JsonProperty("zim_id")]
        public string ZimId { get; set; }
    }
}
