using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IntentQueryRequest Data Structure.
    /// </summary>
    public class IntentQueryRequest : AlipayObject
    {
        /// <summary>
        /// 用户的请求来自的操作动作来源
        /// </summary>
        [JsonPropertyName("action_src")]
        public string ActionSrc { get; set; }

        /// <summary>
        /// 客户端操作系统类型
        /// </summary>
        [JsonPropertyName("client_os")]
        public string ClientOs { get; set; }

        /// <summary>
        /// 客户端版本号
        /// </summary>
        [JsonPropertyName("client_version")]
        public string ClientVersion { get; set; }

        /// <summary>
        /// 用户当前的城市code
        /// </summary>
        [JsonPropertyName("current_city")]
        public string CurrentCity { get; set; }

        /// <summary>
        /// 用户当前位置坐标
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// nluJsonParam
        /// </summary>
        [JsonPropertyName("nlu_json_param")]
        public string NluJsonParam { get; set; }

        /// <summary>
        /// 用户输入的query
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /// <summary>
        /// 用户具体一次的请求的id,唯一
        /// </summary>
        [JsonPropertyName("query_id")]
        public string QueryId { get; set; }

        /// <summary>
        /// 服务器端分配的场景code
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 请求的不同入口
        /// </summary>
        [JsonPropertyName("search_src")]
        public string SearchSrc { get; set; }

        /// <summary>
        /// 用户多轮会话的id
        /// </summary>
        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户的id
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}
