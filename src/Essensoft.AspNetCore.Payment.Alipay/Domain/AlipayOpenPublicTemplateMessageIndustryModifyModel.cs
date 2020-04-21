using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicTemplateMessageIndustryModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicTemplateMessageIndustryModifyModel : AlipayObject
    {
        /// <summary>
        /// 服务窗消息模板所属主行业一/二级编码
        /// </summary>
        [JsonPropertyName("primary_industry_code")]
        public string PrimaryIndustryCode { get; set; }

        /// <summary>
        /// 服务窗消息模板所属主行业一/二级名称，<a href="https://doc.open.alipay.com/doc2/detail?treeId=197&docType=1&articleId=105043">查看行业信息</a>
        /// </summary>
        [JsonPropertyName("primary_industry_name")]
        public string PrimaryIndustryName { get; set; }

        /// <summary>
        /// 服务窗消息模板所属副行业一/二级编码
        /// </summary>
        [JsonPropertyName("secondary_industry_code")]
        public string SecondaryIndustryCode { get; set; }

        /// <summary>
        /// 服务窗消息模板所属副行业一/二级名称
        /// </summary>
        [JsonPropertyName("secondary_industry_name")]
        public string SecondaryIndustryName { get; set; }
    }
}
