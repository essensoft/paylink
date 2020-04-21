using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserMaterialBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 物料列表
        /// </summary>
        [JsonPropertyName("material_infos")]
        public List<AdMaterialInfo> MaterialInfos { get; set; }

        /// <summary>
        /// 总大小
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
