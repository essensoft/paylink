using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoiceQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfsettleprodInvoiceQueryModel : AlipayObject
    {
        /// <summary>
        /// 开票号
        /// </summary>
        [JsonPropertyName("kp_no")]
        public string KpNo { get; set; }

        /// <summary>
        /// 蚂蚁供应商2088账号PID
        /// </summary>
        [JsonPropertyName("seller_ip_role_ids")]
        public List<string> SellerIpRoleIds { get; set; }
    }
}
