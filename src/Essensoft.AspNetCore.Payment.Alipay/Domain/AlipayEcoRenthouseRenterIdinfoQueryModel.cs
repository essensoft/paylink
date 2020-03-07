using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseRenterIdinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseRenterIdinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
