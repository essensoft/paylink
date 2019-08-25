using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationCustomerCertifyQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// zimId，用于查询认证结果
        /// </summary>
        [JsonProperty("zim_id")]
        public string ZimId { get; set; }
    }
}
