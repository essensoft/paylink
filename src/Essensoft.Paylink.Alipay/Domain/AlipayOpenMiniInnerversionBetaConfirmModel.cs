using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBetaConfirmModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionBetaConfirmModel : AlipayObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 拒绝理由
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 操作：pass/reject。接受或者拒绝
        /// </summary>
        [JsonPropertyName("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 小程序所属PID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 要确认邀测结果的插件appid
        /// </summary>
        [JsonPropertyName("plugin_id")]
        public string PluginId { get; set; }
    }
}
