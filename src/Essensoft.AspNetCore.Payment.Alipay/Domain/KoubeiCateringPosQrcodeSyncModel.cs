using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosQrcodeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosQrcodeSyncModel : AlipayObject
    {
        /// <summary>
        /// 需要同步的桌台与二维码信息
        /// </summary>
        [JsonProperty("list")]
        public List<QrcodeEntity> List { get; set; }
    }
}
