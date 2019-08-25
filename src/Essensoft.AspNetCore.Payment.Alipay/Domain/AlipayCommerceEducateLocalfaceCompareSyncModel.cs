using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateLocalfaceCompareSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateLocalfaceCompareSyncModel : AlipayObject
    {
        /// <summary>
        /// 算法版本
        /// </summary>
        [JsonProperty("alg_ver")]
        public string AlgVer { get; set; }

        /// <summary>
        /// 图片encode base64处理后的字符串
        /// </summary>
        [JsonProperty("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// SCHOOL_FACE_PAYMENT: 校园刷脸支付  SCHOOL_ENTRANCE_GUARD:校园门禁
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务流水唯一ID
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 2D或者3D，默认2D
        /// </summary>
        [JsonProperty("face_data_type")]
        public string FaceDataType { get; set; }

        /// <summary>
        /// 人脸本地1:N比对后的用户ID
        /// </summary>
        [JsonProperty("fuid")]
        public string Fuid { get; set; }

        /// <summary>
        /// ISV的名称
        /// </summary>
        [JsonProperty("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 学校机构编码
        /// </summary>
        [JsonProperty("organize_id")]
        public string OrganizeId { get; set; }

        /// <summary>
        /// 图片质量分
        /// </summary>
        [JsonProperty("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// 人脸坐标点
        /// </summary>
        [JsonProperty("rect")]
        public string Rect { get; set; }

        /// <summary>
        /// 人脸本地比对分
        /// </summary>
        [JsonProperty("score")]
        public string Score { get; set; }
    }
}
