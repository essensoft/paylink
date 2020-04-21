using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserAppBizDataInfo Data Structure.
    /// </summary>
    public class UserAppBizDataInfo : AlipayObject
    {
        /// <summary>
        /// 信息分类，详见功能包说明，动态变更的
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 业务描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 业务结束时间，毫秒时间戳
        /// </summary>
        [JsonPropertyName("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户业务流水id，应该是商户侧数据的唯一键
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 业务开始时间，毫秒时间戳
        /// </summary>
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 业务状态，详见功能包说明，不同信息分类，对应的状态不同
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 业务跳转相对地址，接口方会将该相对地址拼接到商户小程序地址后面，最终展示给用户的地址：alipays://platformapi/startApp?appId=88888888888&page=test
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
