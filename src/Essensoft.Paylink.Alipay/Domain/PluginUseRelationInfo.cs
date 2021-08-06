using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PluginUseRelationInfo Data Structure.
    /// </summary>
    public class PluginUseRelationInfo : AlipayObject
    {
        /// <summary>
        /// 邀测驳回原因
        /// </summary>
        [JsonPropertyName("beta_memo")]
        public string BetaMemo { get; set; }

        /// <summary>
        /// 邀测插件版本号
        /// </summary>
        [JsonPropertyName("beta_plugin_version")]
        public string BetaPluginVersion { get; set; }

        /// <summary>
        /// 邀测二维码
        /// </summary>
        [JsonPropertyName("beta_qr_code_url")]
        public string BetaQrCodeUrl { get; set; }

        /// <summary>
        /// WAITCHECK-待确认;CHECKED-确认;REJECT-拒绝
        /// </summary>
        [JsonPropertyName("beta_status")]
        public string BetaStatus { get; set; }

        /// <summary>
        /// 激活时间
        /// </summary>
        [JsonPropertyName("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 订购时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 插件失效时间
        /// </summary>
        [JsonPropertyName("gmt_invalid")]
        public string GmtInvalid { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 插件构建版本
        /// </summary>
        [JsonPropertyName("plugin_deploy_version")]
        public string PluginDeployVersion { get; set; }

        /// <summary>
        /// 插件ID
        /// </summary>
        [JsonPropertyName("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 插件状态，取值包括EXECUTING/WAIT_WORKING/WORKING/STOP_WORKING/WAIT_BUY
        /// </summary>
        [JsonPropertyName("plugin_status")]
        public string PluginStatus { get; set; }

        /// <summary>
        /// 分端版本配置信息列表
        /// </summary>
        [JsonPropertyName("plugin_use_config_info_list")]
        public List<PluginUseConfigInfo> PluginUseConfigInfoList { get; set; }

        /// <summary>
        /// 插件版本
        /// </summary>
        [JsonPropertyName("plugin_version")]
        public string PluginVersion { get; set; }

        /// <summary>
        /// 插件运行状态，取值包括ONLINE/TRIAL/REVIEW/DEBUG
        /// </summary>
        [JsonPropertyName("run_mode_type")]
        public string RunModeType { get; set; }

        /// <summary>
        /// 渠道来源，取值包括SHOP_MINI/PLUGIN_DEBUG/PLUGIN_TRIAL/PLUGIN_AUDIT/GENERAL_SHOP_ID
        /// </summary>
        [JsonPropertyName("source_from")]
        public string SourceFrom { get; set; }
    }
}
