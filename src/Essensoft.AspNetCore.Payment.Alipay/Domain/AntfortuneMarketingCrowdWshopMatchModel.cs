using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneMarketingCrowdWshopMatchModel Data Structure.
    /// </summary>
    public class AntfortuneMarketingCrowdWshopMatchModel : AlipayObject
    {
        /// <summary>
        /// 财富号机构自建人群id，应用于财富号机构人群匹配。财富号合作机构通过财富号后台创建人群后获得人群id
        /// </summary>
        [JsonPropertyName("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，通过alipay.user.info.share接口获取
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
