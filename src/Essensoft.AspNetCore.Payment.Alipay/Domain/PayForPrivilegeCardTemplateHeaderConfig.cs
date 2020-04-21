using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PayForPrivilegeCardTemplateHeaderConfig Data Structure.
    /// </summary>
    public class PayForPrivilegeCardTemplateHeaderConfig : AlipayObject
    {
        /// <summary>
        /// 卡模板头部logo图片URL，通过https://docs.open.alipay.com/common/105258 接口上传图片获得
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 卡模板头部底图URL，通过https://docs.open.alipay.com/common/105258上传图片获得
        /// </summary>
        [JsonPropertyName("strip")]
        public string Strip { get; set; }

        /// <summary>
        /// 卡模板头部显示名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
