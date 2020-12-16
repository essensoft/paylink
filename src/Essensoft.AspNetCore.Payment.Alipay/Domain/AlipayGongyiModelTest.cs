using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayGongyiModelTest Data Structure.
    /// </summary>
    public class AlipayGongyiModelTest : AlipayObject
    {
        /// <summary>
        /// zhangsan
        /// </summary>
        [JsonPropertyName("buyer")]
        public string Buyer { get; set; }

        /// <summary>
        /// buyer@163.com
        /// </summary>
        [JsonPropertyName("buyer_email")]
        public string BuyerEmail { get; set; }

        /// <summary>
        /// 10.12
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// asdf
        /// </summary>
        [JsonPropertyName("seller")]
        public string Seller { get; set; }

        /// <summary>
        /// seller@email.com
        /// </summary>
        [JsonPropertyName("seller_email")]
        public string SellerEmail { get; set; }

        /// <summary>
        /// userfino
        /// </summary>
        [JsonPropertyName("userinfo")]
        public AlipayGongyiUserInfoTest Userinfo { get; set; }
    }
}
