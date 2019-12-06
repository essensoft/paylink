using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuditLicenseInfo Data Structure.
    /// </summary>
    public class AuditLicenseInfo : AlipayObject
    {
        /// <summary>
        /// 营业执照名称，需要与营业执照保持一致
        /// </summary>
        [JsonPropertyName("license_name")]
        public string LicenseName { get; set; }

        /// <summary>
        /// 营业执照号，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序应用营业执照号。
        /// </summary>
        [JsonPropertyName("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 营业执照照片地址列表
        /// </summary>
        [JsonPropertyName("license_pic_list")]
        public List<string> LicensePicList { get; set; }

        /// <summary>
        /// 营业执有效期，格式为yyyy-MM-dd，9999-12-31表示长期
        /// </summary>
        [JsonPropertyName("license_valid_date")]
        public string LicenseValidDate { get; set; }

        /// <summary>
        /// 门头照图片地址，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序门头照图片
        /// </summary>
        [JsonPropertyName("out_door_pic")]
        public string OutDoorPic { get; set; }
    }
}
