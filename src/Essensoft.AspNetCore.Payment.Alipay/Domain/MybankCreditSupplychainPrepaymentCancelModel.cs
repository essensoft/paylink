using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainPrepaymentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainPrepaymentCancelModel : AlipayObject
    {
        /// <summary>
        /// 买家身份信息
        /// </summary>
        [JsonProperty("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 预付申请单编号，由调用创建预付申请时自动分配。
        /// </summary>
        [JsonProperty("prepay_apply_no")]
        public string PrepayApplyNo { get; set; }

        /// <summary>
        /// 接口幂等字段，相同requestId请求系统默认认为是相同的请求。此处requestId要求的格式为"{机构IpRoleId}_{机构生成的唯一请求ID}"。
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
