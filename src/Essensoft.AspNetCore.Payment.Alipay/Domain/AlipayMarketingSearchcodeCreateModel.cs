using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingSearchcodeCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingSearchcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务标识，类似于业务主键，诸如pid、uid、门店id
        /// </summary>
        [JsonPropertyName("biz_linked_id")]
        public string BizLinkedId { get; set; }

        /// <summary>
        /// 搜索码的业务类型，新增业务请联系PD和开发分配
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 展示在搜索码搜索后，搜索box面板上banner的描述文案
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 搜索码的有效期，单位s
        /// </summary>
        [JsonPropertyName("timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// 展示在搜索码搜索后，box的面板上banner的标题字段
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 点击搜索box的banner后的跳转地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
