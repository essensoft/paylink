using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetreverseCompleteSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetreverseCompleteSyncModel : AlipayObject
    {
        /// <summary>
        /// 取消订单或退货成功入参
        /// </summary>
        [JsonProperty("asset_reverse_details")]
        public List<AssetReverseDetail> AssetReverseDetails { get; set; }
    }
}
