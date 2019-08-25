using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSupplierAssetModifyModel : AlipayObject
    {
        /// <summary>
        /// 供应商设备信息
        /// </summary>
        [JsonProperty("record")]
        public SupplierAssetResponse Record { get; set; }
    }
}
