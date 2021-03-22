using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CategoryRequireInfo Data Structure.
    /// </summary>
    public class CategoryRequireInfo : AlipayObject
    {
        /// <summary>
        /// 营业执照页面是否必填
        /// </summary>
        [JsonPropertyName("business_licence_required")]
        public bool BusinessLicenceRequired { get; set; }

        /// <summary>
        /// 类目code（各级类目code下划线"_"拼接）
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目名称（各级类目名称下划线"_"拼接）
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目要求原始描述信息
        /// </summary>
        [JsonPropertyName("category_requirements")]
        public string CategoryRequirements { get; set; }

        /// <summary>
        /// 门头照页面是否必填
        /// </summary>
        [JsonPropertyName("door_photo_required")]
        public bool DoorPhotoRequired { get; set; }

        /// <summary>
        /// 特殊资质页面是否必填
        /// </summary>
        [JsonPropertyName("special_licence_required")]
        public bool SpecialLicenceRequired { get; set; }
    }
}
