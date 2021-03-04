using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandAssetinfoSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 物料信息反馈处理结果
        /// </summary>
        [JsonPropertyName("info_results")]
        public List<AssetResult> InfoResults { get; set; }
    }
}
