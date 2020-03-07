using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopStaffInfo Data Structure.
    /// </summary>
    public class ShopStaffInfo : AlipayObject
    {
        /// <summary>
        /// 服务人员描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 工作人员名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务人员照片
        /// </summary>
        [JsonPropertyName("picture")]
        public string Picture { get; set; }
    }
}
