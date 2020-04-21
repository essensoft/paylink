using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardUserInfo Data Structure.
    /// </summary>
    public class CardUserInfo : AlipayObject
    {
        /// <summary>
        /// 用户唯一标识, 根据user_id_type类型来定 （目前暂支持支付宝userId）    支付宝userId说明：支付宝用户号是以2088开头的16位纯数字组成
        /// </summary>
        [JsonPropertyName("user_uni_id")]
        public string UserUniId { get; set; }

        /// <summary>
        /// ID类型：UID， 即传值UID即可
        /// </summary>
        [JsonPropertyName("user_uni_id_type")]
        public string UserUniIdType { get; set; }
    }
}
