using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginrelationQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerappPluginrelationQueryModel : AlipayObject
    {
        /// <summary>
        /// 应用ID列表
        /// </summary>
        [JsonPropertyName("mini_app_id_list")]
        public List<string> MiniAppIdList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 插件ID
        /// </summary>
        [JsonPropertyName("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 插件使用关系状态，取值包括WORKING/WAIT_WORKING/STOP_WORKING/EXECUTING
        /// </summary>
        [JsonPropertyName("plugin_relation_status_list")]
        public List<string> PluginRelationStatusList { get; set; }

        /// <summary>
        /// 运行类型，取值包括ONLINE/TRIAL/REVIEW/DEBUG
        /// </summary>
        [JsonPropertyName("run_model_type")]
        public string RunModelType { get; set; }

        /// <summary>
        /// 是否展示邀测信息
        /// </summary>
        [JsonPropertyName("show_beta_info")]
        public bool ShowBetaInfo { get; set; }
    }
}
