using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasSyncSingledataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasSyncSingledataSendModel : AlipayObject
    {
        /// <summary>
        /// 支持的最大客户端app版本号
        /// </summary>
        [JsonProperty("app_max_version")]
        public string AppMaxVersion { get; set; }

        /// <summary>
        /// 支持的最小客户端app版本号
        /// </summary>
        [JsonProperty("app_min_version")]
        public string AppMinVersion { get; set; }

        /// <summary>
        /// base64编码后的二进制业务数据，与payload二选一
        /// </summary>
        [JsonProperty("binary_payload")]
        public string BinaryPayload { get; set; }

        /// <summary>
        /// 透传至客户端的业务自定义标签属性
        /// </summary>
        [JsonProperty("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 业务场景标识，需要申请，文档：https://lark.alipay.com/team-sync/sync/biztype
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 参考文档：https://lark.alipay.com/team-sync/sync/server-down
        /// </summary>
        [JsonProperty("client_app")]
        public string ClientApp { get; set; }

        /// <summary>
        /// 希望接收数据的移动设备ID
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 是否需要立即推送给客户端app，默认为true
        /// </summary>
        [JsonProperty("immediate_sync")]
        public bool ImmediateSync { get; set; }

        /// <summary>
        /// 根据申请bizType决定，用户维度业务填写userId, 设备维度填写utdid
        /// </summary>
        [JsonProperty("link_token")]
        public string LinkToken { get; set; }

        /// <summary>
        /// 指定接收数据的客户端os类型
        /// </summary>
        [JsonProperty("os_type")]
        public string OsType { get; set; }

        /// <summary>
        /// 字符型业务数据体，与binary_payload二选一
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 业务数据唯一标识，无特殊要求，主要用做幂等控制
        /// </summary>
        [JsonProperty("third_msg_id")]
        public string ThirdMsgId { get; set; }

        /// <summary>
        /// 业务数据生效的结束时间
        /// </summary>
        [JsonProperty("valid_end")]
        public string ValidEnd { get; set; }

        /// <summary>
        /// 业务数据生效的起始时间
        /// </summary>
        [JsonProperty("valid_start")]
        public string ValidStart { get; set; }
    }
}
