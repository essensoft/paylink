using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryAccountstatusModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenInstantdeliveryAccountstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 要更新的商家账户列表
        /// </summary>
        [JsonPropertyName("logistics_account_infos")]
        public List<LogisticsAccountInfo> LogisticsAccountInfos { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
