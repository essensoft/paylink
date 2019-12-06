using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesCreateModel : AlipayObject
    {
        /// <summary>
        /// 云凤蝶站点初始化数据
        /// </summary>
        [JsonPropertyName("activity")]
        public FengdieSitesCreateModel Activity { get; set; }

        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id（即创建空间成员接口的入参），应确保 operator 是参数 space_id 对应的空间成员
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作的空间 ID
        /// </summary>
        [JsonPropertyName("space_id")]
        public string SpaceId { get; set; }

        /// <summary>
        /// 创建站点使用的模板名称
        /// </summary>
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }
    }
}
