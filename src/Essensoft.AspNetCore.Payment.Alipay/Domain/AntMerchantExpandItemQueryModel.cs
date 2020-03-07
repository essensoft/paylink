using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemQueryModel : AlipayObject
    {
        /// <summary>
        /// 商品前台类目id: null 表示所有分类
        /// </summary>
        [JsonPropertyName("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 商品状态：EFFECT、INVALID、PAUSE；不填返回所有状态商品
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品归属主体id
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型:  5: 店铺  4: 主站MID  3: 参与者  2: 角色  1: 联系人
        /// </summary>
        [JsonPropertyName("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 未分类类目: true 的时候 front_category_id 必须不填（null）
        /// </summary>
        [JsonPropertyName("undefined_category")]
        public bool UndefinedCategory { get; set; }
    }
}
