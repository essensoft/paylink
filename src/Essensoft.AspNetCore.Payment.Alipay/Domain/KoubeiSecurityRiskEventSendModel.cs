using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSecurityRiskEventSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSecurityRiskEventSendModel : AlipayObject
    {
        /// <summary>
        /// 每一个事件码对应的扩展信息，是Map<String,String>的类型JSON格式化的字符串，具体内容与场景相关，请联系接口负责人获取相关文档。
        /// </summary>
        [JsonProperty("business_info")]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// 事件发生的gmt事件，单位为毫秒
        /// </summary>
        [JsonProperty("gmt_occur")]
        public long GmtOccur { get; set; }

        /// <summary>
        /// 场景关联的产品名称，例如外部商户（EXT_MERCHANT），外部门店（EXT_SHOP）
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// 唯一标识请求的id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 业务场景码，描述一种具体的业务场景
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }
    }
}
