using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotSupplierAssetModifyModel : AlipayObject
    {
        /// <summary>
        /// 供应商设备信息
        /// </summary>
        [JsonPropertyName("record")]
        public SupplierAssetResponse Record { get; set; }
    }
}
