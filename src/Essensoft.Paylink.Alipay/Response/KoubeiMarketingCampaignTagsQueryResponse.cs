using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignTagsQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignTagsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询成功时返回人群标签信息查询失败时为空 code:表示标签code name:表示标签名称 valueRange：表示标签的取值范围 value:表示标签具体取值 label:描述信息 标签相关的详细信息参见附件。<a href="https://gw.alipayobjects.com/os/bmw-prod/4b028911-cb1a-40e9-8abe-49cb04c9a379.zip">标签信息</a>
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; }
    }
}
