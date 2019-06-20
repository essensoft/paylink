using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffQrcodereturnSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffQrcodereturnSyncModel : AlipayObject
    {
        /// <summary>
        /// 供应商回传码物料码值记录（最多200条）
        /// </summary>
        [JsonProperty("return_qrcodes")]
        public List<AccessReturnQrcode> ReturnQrcodes { get; set; }
    }
}
