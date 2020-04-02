using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCookCateTopInfo Data Structure.
    /// </summary>
    public class KbdishCookCateTopInfo : AlipayObject
    {
        /// <summary>
        /// 口碑类目id
        /// </summary>
        [JsonPropertyName("catetory_id")]
        public string CatetoryId { get; set; }

        /// <summary>
        /// 菜谱id
        /// </summary>
        [JsonPropertyName("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 操作类型 top：置顶 cancelTop：取消置顶
        /// </summary>
        [JsonPropertyName("oper_type")]
        public string OperType { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}
