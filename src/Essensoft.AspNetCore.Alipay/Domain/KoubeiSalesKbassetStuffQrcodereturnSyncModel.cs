using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffQrcodereturnSyncModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffQrcodereturnSyncModel : AlipayObject
    {
        /// <summary>
        /// 供应商回传码物料码值记录（最多200条）
        /// </summary>
        [JsonProperty("return_qrcodes")]
        public List<AccessReturnQrcode> ReturnQrcodes { get; set; }
    }
}
