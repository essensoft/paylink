using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户编号，由机构定义，需要保证在机构下唯一，如果未传sub_merchant_id ，则必传 external_id 和 org_pid
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 机构pid，根据org_pid + external_id 可以唯一确定商户，如果未传sub_merchant_id ，则必传 external_id 和 org_pid
        /// </summary>
        [JsonProperty("org_pid")]
        public string OrgPid { get; set; }

        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号，如果未传 external_id 和 org_pid，则必传sub_merchant_id
        /// </summary>
        [JsonProperty("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
