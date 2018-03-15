using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetinfoSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 传入需要反馈的物料信息对象列表.
        /// </summary>
        [JsonProperty("asset_infos")]
        public List<AssetInfoItem> AssetInfos { get; set; }
    }
}
