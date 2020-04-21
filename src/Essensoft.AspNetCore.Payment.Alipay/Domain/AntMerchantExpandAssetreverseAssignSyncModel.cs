using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetreverseAssignSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetreverseAssignSyncModel : AlipayObject
    {
        /// <summary>
        /// 取消订单或退货指令接收反馈，最多200条
        /// </summary>
        [JsonPropertyName("reverse_results")]
        public List<AssetResult> ReverseResults { get; set; }
    }
}
