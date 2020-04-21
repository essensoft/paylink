using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosQrcodeSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosQrcodeSyncModel : AlipayObject
    {
        /// <summary>
        /// 需要同步的桌台与二维码信息
        /// </summary>
        [JsonPropertyName("list")]
        public List<QrcodeEntity> List { get; set; }
    }
}
