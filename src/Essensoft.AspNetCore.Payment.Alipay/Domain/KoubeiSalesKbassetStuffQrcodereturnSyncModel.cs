using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffQrcodereturnSyncModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffQrcodereturnSyncModel : AlipayObject
    {
        /// <summary>
        /// 供应商回传码物料码值记录（最多200条）
        /// </summary>
        [JsonPropertyName("return_qrcodes")]
        public List<AccessReturnQrcode> ReturnQrcodes { get; set; }
    }
}
