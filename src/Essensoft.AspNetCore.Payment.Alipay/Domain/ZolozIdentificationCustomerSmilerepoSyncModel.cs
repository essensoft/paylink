using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerSmilerepoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationCustomerSmilerepoSyncModel : AlipayObject
    {
        /// <summary>
        /// 活体图片encode base64 String
        /// </summary>
        [JsonProperty("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// 商户的机具编码
        /// </summary>
        [JsonProperty("device_num")]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 人脸定制分配的场景码
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 人脸相关的比对结果信
        /// </summary>
        [JsonProperty("zface_info")]
        public string ZfaceInfo { get; set; }
    }
}
