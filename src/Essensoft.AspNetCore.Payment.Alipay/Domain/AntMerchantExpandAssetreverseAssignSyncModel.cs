using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetreverseAssignSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetreverseAssignSyncModel : AlipayObject
    {
        /// <summary>
        /// 取消订单或退货指令接收反馈，最多200条
        /// </summary>
        [JsonProperty("reverse_results")]
        public List<AssetResult> ReverseResults { get; set; }
    }
}
