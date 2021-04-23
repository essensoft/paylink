using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdCreateModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdCreateModel : AlipayObject
    {
        /// <summary>
        /// 圈人的条件。 op：表示操作符，目前支持 EQ（相等）、GT（大于）、GTEQ（大于等于）、LT（小于）、LTEQ（小于等于）、NEQ（不等）、LIKE（模糊匹配）、IN（在枚举范围内）、NOTIN（不在枚举范围内）、BETWEEN（范围比较）、LEFTDAYS（几天以内）、RIGHTDAYS（几天以外）、LOCATE（地理位置比较）LBS（地图位置数据）； tagCode：标签code，详细标签 code 参见附件 <a href="https://gw.alipayobjects.com/os/bmw-prod/4b028911-cb1a-40e9-8abe-49cb04c9a379.zip">标签信息</a> 。 value：标签值。
        /// </summary>
        [JsonPropertyName("conditions")]
        public string Conditions { get; set; }

        /// <summary>
        /// 人群组的名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作人id，必须和operator_type配对出现，不填时默认是商户
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型,有以下值可填：MER（外部商户），MER_OPERATOR（外部商户操作员），PROVIDER（外部服务商），PROVIDER_STAFF（外部服务商员工），默认不需要填这个字段，默认为MER
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
