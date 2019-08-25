using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 传入需要反馈的物料信息对象列表.
        /// </summary>
        [JsonProperty("asset_infos")]
        public List<AssetInfoItem> AssetInfos { get; set; }
    }
}
