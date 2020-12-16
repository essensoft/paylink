using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipaldmpSyncModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipaldmpSyncModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 商户人群id
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 商户人群名称
        /// </summary>
        [JsonPropertyName("data_name")]
        public string DataName { get; set; }

        /// <summary>
        /// 商户在灯火平台的唯一标签，请联系商户获取
        /// </summary>
        [JsonPropertyName("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 人群关联策略：${bizdate}-n : ${bizdate}为固定值，代表当天，n为天数。如果当天为28号，n=1，则表示拉取27号的数；${recent}: ${recent}为固定值，调度时拉取最近一次更新的数据
        /// </summary>
        [JsonPropertyName("strategy")]
        public string Strategy { get; set; }
    }
}
