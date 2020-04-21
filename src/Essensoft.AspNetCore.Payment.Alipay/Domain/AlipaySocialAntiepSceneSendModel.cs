using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialAntiepSceneSendModel Data Structure.
    /// </summary>
    public class AlipaySocialAntiepSceneSendModel : AlipayObject
    {
        /// <summary>
        /// 行为业务参数，用于业务流处理时所需参数转换，map<String,String> 的 json格式
        /// </summary>
        [JsonPropertyName("action_biz_info")]
        public string ActionBizInfo { get; set; }

        /// <summary>
        /// 行为幂等id，用于防止重复提交
        /// </summary>
        [JsonPropertyName("action_biz_no")]
        public string ActionBizNo { get; set; }

        /// <summary>
        /// 上报行为的code码，用于服务端取出对应的场景信息并处理对应的后续行为
        /// </summary>
        [JsonPropertyName("action_code")]
        public string ActionCode { get; set; }

        /// <summary>
        /// 行为发生的时间戳，单位是ms
        /// </summary>
        [JsonPropertyName("action_time")]
        public long ActionTime { get; set; }

        /// <summary>
        /// 请求类型，需传OPENAPI
        /// </summary>
        [JsonPropertyName("request_type")]
        public string RequestType { get; set; }

        /// <summary>
        /// 场景类型,新增需找开发者协定值
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
