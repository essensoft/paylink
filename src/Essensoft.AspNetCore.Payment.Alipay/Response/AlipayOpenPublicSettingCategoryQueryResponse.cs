using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicSettingCategoryQueryResponse.
    /// </summary>
    public class AlipayOpenPublicSettingCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回已设置的一级行业分类名称
        /// </summary>
        [JsonPropertyName("primary_category")]
        public string PrimaryCategory { get; set; }

        /// <summary>
        /// 返回已设置的二级行业分类名称
        /// </summary>
        [JsonPropertyName("secondary_category")]
        public string SecondaryCategory { get; set; }
    }
}
