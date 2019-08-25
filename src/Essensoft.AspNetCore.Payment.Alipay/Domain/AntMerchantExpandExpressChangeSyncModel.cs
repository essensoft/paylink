using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandExpressChangeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandExpressChangeSyncModel : AlipayObject
    {
        /// <summary>
        /// 传入需要上传的附件内容及相关业务参数
        /// </summary>
        [JsonProperty("asset_logistics_record")]
        public AssetLogisticsRecord AssetLogisticsRecord { get; set; }
    }
}
