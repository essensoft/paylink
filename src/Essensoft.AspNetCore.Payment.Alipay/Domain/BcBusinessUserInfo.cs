using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BcBusinessUserInfo Data Structure.
    /// </summary>
    public class BcBusinessUserInfo : AlipayObject
    {
        /// <summary>
        /// BC互动，B端实体对应的实际B端操作人员的头像地址
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// BC互动，B端实体对应的实际B端操作人员的用户名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// BC互动，B端实体对应的实际B端操作人员的用户帐号id
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}
