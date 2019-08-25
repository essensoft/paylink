using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveFaceUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntarchiveFaceUploadModel : AlipayObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 证件名
        /// </summary>
        [JsonProperty("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 蚂蚁档案证件类型    个人类型取值范围：  100 居民身份证  102 护照  105 港澳居民往来内地通行证  106 台湾居民往来内地通行证    企业和组织类型取值范围：  200 统一社会信用代码  201 全国法人营业执照  204 民办非企业登记证书  206 社会团体法人登记证书  218 事业单位法人证书
        /// </summary>
        [JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 档案人脸扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public ArchiveFaceExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 身份证反面url，pg格式，大小限制为几百K以内
        /// </summary>
        [JsonProperty("other_portrait_url")]
        public string OtherPortraitUrl { get; set; }

        /// <summary>
        /// 请求人像url，jpg格式，大小限制为几百K以内
        /// </summary>
        [JsonProperty("portrait_url")]
        public string PortraitUrl { get; set; }
    }
}
