using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkModifyModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsInboundworkModifyModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 入库作业id
        /// </summary>
        [JsonPropertyName("inbound_work_id")]
        public string InboundWorkId { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonPropertyName("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 入库作业明细列表
        /// </summary>
        [JsonPropertyName("work_details")]
        public List<WorkDetail> WorkDetails { get; set; }
    }
}
