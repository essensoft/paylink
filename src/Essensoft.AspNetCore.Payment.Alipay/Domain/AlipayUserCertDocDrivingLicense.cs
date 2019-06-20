using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertDocDrivingLicense Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertDocDrivingLicense : AlipayObject
    {
        /// <summary>
        /// 准驾车型
        /// </summary>
        [JsonProperty("clazz")]
        public string Clazz { get; set; }

        /// <summary>
        /// 证号
        /// </summary>
        [JsonProperty("driving_license_no")]
        public string DrivingLicenseNo { get; set; }

        /// <summary>
        /// base64后的主页照片
        /// </summary>
        [JsonProperty("encoded_img_main")]
        public string EncodedImgMain { get; set; }

        /// <summary>
        /// base64编码后的副页图片
        /// </summary>
        [JsonProperty("encoded_img_vice")]
        public string EncodedImgVice { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        [JsonProperty("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 档案编号
        /// </summary>
        [JsonProperty("file_no")]
        public string FileNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [JsonProperty("valide_date")]
        public string ValideDate { get; set; }
    }
}
