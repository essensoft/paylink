using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodAssetbillQueryResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodAssetbillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 单据流水列表
        /// </summary>
        [JsonPropertyName("asset_bill_info")]
        public List<AssetBillInfo> AssetBillInfo { get; set; }
    }
}
