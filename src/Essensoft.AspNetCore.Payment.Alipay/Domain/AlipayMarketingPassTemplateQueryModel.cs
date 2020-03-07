using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingPassTemplateQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingPassTemplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 页码，必须为大于0的整数， 1表示第一页，2表示第2页；  不填则默认为1，查第1页数据。
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，必须为大于0的整数，最大值为20；  不填则默认20。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 模板ID（编号），创建模板接口返回的模板ID
        /// </summary>
        [JsonPropertyName("tpl_id")]
        public string TplId { get; set; }
    }
}
