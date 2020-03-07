using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiQualityTestShieldCaselaunchApplyModel Data Structure.
    /// </summary>
    public class KoubeiQualityTestShieldCaselaunchApplyModel : AlipayObject
    {
        /// <summary>
        /// 需要执行的测试用例id,多个id用逗号隔开
        /// </summary>
        [JsonPropertyName("collection_ids")]
        public string CollectionIds { get; set; }

        /// <summary>
        /// 钉钉群的dingding_token，用来发送钉钉群消息
        /// </summary>
        [JsonPropertyName("dingding_token")]
        public string DingdingToken { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }
    }
}
