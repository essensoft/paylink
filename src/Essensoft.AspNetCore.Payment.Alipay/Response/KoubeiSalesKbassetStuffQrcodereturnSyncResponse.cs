using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffQrcodereturnSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffQrcodereturnSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 供应商回传码值被处理结果
        /// </summary>
        [JsonPropertyName("return_qrcode_results")]
        public List<AccessReturnQrcodeResult> ReturnQrcodeResults { get; set; }
    }
}
