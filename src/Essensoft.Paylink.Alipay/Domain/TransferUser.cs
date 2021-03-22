using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TransferUser Data Structure.
    /// </summary>
    public class TransferUser : AlipayObject
    {
        /// <summary>
        /// 生日
        /// </summary>
        [JsonPropertyName("birth_date")]
        public string BirthDate { get; set; }

        /// <summary>
        /// 证件信息
        /// </summary>
        [JsonPropertyName("credential")]
        public TransferCredential Credential { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 用户地址信息
        /// </summary>
        [JsonPropertyName("user_address")]
        public TransferAddressInfo UserAddress { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名字信息
        /// </summary>
        [JsonPropertyName("user_name")]
        public TransferUserName UserName { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonPropertyName("user_phone_no")]
        public string UserPhoneNo { get; set; }
    }
}
