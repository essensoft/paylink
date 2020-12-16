using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetsDetailParams Data Structure.
    /// </summary>
    public class AssetsDetailParams : AlipayObject
    {
        /// <summary>
        /// 资产是否准入
        /// </summary>
        [JsonPropertyName("admit")]
        public string Admit { get; set; }

        /// <summary>
        /// 免息券信息
        /// </summary>
        [JsonPropertyName("int_free_info")]
        public string IntFreeInfo { get; set; }
    }
}
