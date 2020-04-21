using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAddressQueryModel Data Structure.
    /// </summary>
    public class AlipayUserAddressQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户地址唯一ID。通过调用小程序开放api(my.chooseAddress)获取。
        /// </summary>
        [JsonPropertyName("address_id")]
        public string AddressId { get; set; }
    }
}
