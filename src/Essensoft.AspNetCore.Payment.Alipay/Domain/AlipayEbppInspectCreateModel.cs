using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInspectCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppInspectCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务类型。由巡检平台统一分配。
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 数据创建者
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 数据来源: 业务系统名称_TrSync
        /// </summary>
        [JsonPropertyName("data_from_type")]
        public string DataFromType { get; set; }

        /// <summary>
        /// 是否同步检测。true-同步检测，false-不需要同步检测。默认false。
        /// </summary>
        [JsonPropertyName("is_sync_check")]
        public bool IsSyncCheck { get; set; }

        /// <summary>
        /// 外部流程业务标识。一个标识可以同步多条数据。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务服务数据列表
        /// </summary>
        [JsonPropertyName("service_list")]
        public List<MstDataSyncServiceEntity> ServiceList { get; set; }
    }
}
