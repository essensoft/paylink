using Newtonsoft.Json;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieMemberCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieMemberCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 凤蝶业务空间创建成功后，返回该成员的基本信息
        /// </summary>
        [JsonProperty("data")]
        public FengdieSpaceMemberCreateModel Data { get; set; }
    }
}
