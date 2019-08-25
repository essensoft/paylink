using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetinfoCorrectionSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetinfoCorrectionSyncModel : AlipayObject
    {
        /// <summary>
        /// 物料信息更正请求
        /// </summary>
        [JsonProperty("asset_correction")]
        public AssetInfoCorrectionItem AssetCorrection { get; set; }
    }
}
