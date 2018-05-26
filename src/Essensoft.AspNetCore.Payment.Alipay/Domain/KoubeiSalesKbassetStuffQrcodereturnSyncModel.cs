using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        [XmlArray("return_qrcodes")]
        [XmlArrayItem("access_return_qrcode")]
        public List<AccessReturnQrcode> ReturnQrcodes { get; set; }
    }
}
