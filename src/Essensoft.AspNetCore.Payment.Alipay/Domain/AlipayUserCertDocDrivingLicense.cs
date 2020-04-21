using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertDocDrivingLicense Data Structure.
    /// </summary>
    public class AlipayUserCertDocDrivingLicense : AlipayObject
    {
        /// <summary>
        /// 准驾车型
        /// </summary>
        [JsonPropertyName("clazz")]
        public string Clazz { get; set; }

        /// <summary>
        /// 证号
        /// </summary>
        [JsonPropertyName("driving_license_no")]
        public string DrivingLicenseNo { get; set; }

        /// <summary>
        /// base64后的主页照片
        /// </summary>
        [JsonPropertyName("encoded_img_main")]
        public string EncodedImgMain { get; set; }

        /// <summary>
        /// base64编码后的副页图片
        /// </summary>
        [JsonPropertyName("encoded_img_vice")]
        public string EncodedImgVice { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 档案编号
        /// </summary>
        [JsonPropertyName("file_no")]
        public string FileNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [JsonPropertyName("valide_date")]
        public string ValideDate { get; set; }
    }
}
