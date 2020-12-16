using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEinvpackageQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEinvpackageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发票包明细数据
        /// </summary>
        [JsonPropertyName("package_item_info_list")]
        public List<PackageItemOpenInfo> PackageItemInfoList { get; set; }
    }
}
