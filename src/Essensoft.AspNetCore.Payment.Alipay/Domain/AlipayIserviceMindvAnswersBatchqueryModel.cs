using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceMindvAnswersBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvAnswersBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 对应填写的任务id_用以获取指定任务的结果数据    snapshot_id 和 job_id 有且只能有一个不为空
        /// </summary>
        [JsonProperty("job_id")]
        public long JobId { get; set; }

        /// <summary>
        /// 分页数据页码，默认从0开始
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页数据中每页的数据数量，默认为 10
        /// </summary>
        [JsonProperty("per_page_size")]
        public long PerPageSize { get; set; }

        /// <summary>
        /// 问卷快照id_用以查询指定用户指定快照的答案数据    snapshot_id 和 job_id 有且只能有一个不为空
        /// </summary>
        [JsonProperty("snapshot_id")]
        public long SnapshotId { get; set; }

        /// <summary>
        /// 对应账号类型下的唯一账号主键_用以区分对应的填写用户
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 账号类型_用以区分不同账号体系的用户    ALIPAY-支付宝  HEMA-盒马  ALIBABA_INC-内部域账号
        /// </summary>
        [JsonProperty("user_type")]
        public string UserType { get; set; }
    }
}
