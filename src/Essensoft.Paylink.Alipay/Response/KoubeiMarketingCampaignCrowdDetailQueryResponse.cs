using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdDetailQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// op：表示操作符，目前支持 EQ（相等）、GT（大于）、GTEQ（大于等于）、LT（小于）、LTEQ（小于等于）、NEQ（不等）、LIKE（模糊匹配）、IN（在枚举范围内）、NOTIN（不在枚举范围内）、BETWEEN（范围比较）、LEFTDAYS（几天以内）、RIGHTDAYS（几天以外）、LOCATE（地理位置比较）LBS（地图位置数据）； tagCode：标签code，详细标签 code 参见附件 <a href="https://gw.alipayobjects.com/os/bmw-prod/4b028911-cb1a-40e9-8abe-49cb04c9a379.zip">标签信息</a>。  value：标签值。
        /// </summary>
        [JsonPropertyName("crowd_group_info")]
        public string CrowdGroupInfo { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
