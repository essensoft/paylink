using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    /// 后付费商户优惠
    /// </summary>
    public class PostDiscount : WeChatPayObject
    {
        /// <summary>
        /// 优惠名称       
        /// </summary>
        /// <remarks>
        /// 优惠名称说明；name和description若填写，则必须同时填写，优惠名称不可重复描述。
        /// 示例值：满20减1元 
        /// </remarks>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠使用条件说明
        /// </summary>
        /// <remarks>
        /// name和description若填写，则必须同时填写。
        /// 示例值：不与其他优惠叠加  
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 付费数量      
        /// </summary>
        /// <remarks>
        /// 付费项目的数量。
        /// 特殊规则：数量限制100，不填时默认1。
        /// 示例值：4 
        /// </remarks>
        [JsonPropertyName("count")]
        public uint Count { get; set; }

    }
}
