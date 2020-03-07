using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoTemplatelistBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMorphoTemplatelistBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 闪蝶身份验证信息
        /// </summary>
        [JsonPropertyName("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [JsonPropertyName("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
