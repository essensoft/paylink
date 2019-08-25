using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureReportUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFacefeatureReportUploadModel : AlipayObject
    {
        /// <summary>
        /// 图片encode base64 String
        /// </summary>
        [JsonProperty("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// 学校团餐
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 商户机具编码
        /// </summary>
        [JsonProperty("device_num")]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonProperty("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 合作商户简称
        /// </summary>
        [JsonProperty("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 商户透传人脸客户端信息
        /// </summary>
        [JsonProperty("z_face_info")]
        public string ZFaceInfo { get; set; }
    }
}
