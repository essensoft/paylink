using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdFacepayUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFacepayUploadModel : AlipayObject
    {
        /// <summary>
        /// 用户输入的邀请码
        /// </summary>
        [JsonProperty("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// Base64编码的人脸图片
        /// </summary>
        [JsonProperty("face_image")]
        public string FaceImage { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [JsonProperty("store_id")]
        public string StoreId { get; set; }
    }
}
