using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountFinriskCompanyVerifyGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountFinriskCompanyVerifyGetModel : AlipayObject
    {
        /// <summary>
        /// 请求系统
        /// </summary>
        [JsonProperty("app")]
        public string App { get; set; }

        /// <summary>
        /// 业务参数列表
        /// </summary>
        [JsonProperty("param")]
        public string Param { get; set; }

        /// <summary>
        /// 外部请求唯一标识
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 防伪场景编码
        /// </summary>
        [JsonProperty("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
