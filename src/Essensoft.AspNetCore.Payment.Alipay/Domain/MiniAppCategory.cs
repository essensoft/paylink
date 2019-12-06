using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppCategory Data Structure.
    /// </summary>
    public class MiniAppCategory : AlipayObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 是否有子类目
        /// </summary>
        [JsonPropertyName("has_child")]
        public bool HasChild { get; set; }

        /// <summary>
        /// 是否需要营业执照
        /// </summary>
        [JsonPropertyName("need_license")]
        public bool NeedLicense { get; set; }

        /// <summary>
        /// 是否需要门头照
        /// </summary>
        [JsonPropertyName("need_out_door_pic")]
        public bool NeedOutDoorPic { get; set; }

        /// <summary>
        /// 是否需要营业执照
        /// </summary>
        [JsonPropertyName("need_special_license")]
        public bool NeedSpecialLicense { get; set; }

        /// <summary>
        /// 父类目id
        /// </summary>
        [JsonPropertyName("parent_category_id")]
        public string ParentCategoryId { get; set; }
    }
}
