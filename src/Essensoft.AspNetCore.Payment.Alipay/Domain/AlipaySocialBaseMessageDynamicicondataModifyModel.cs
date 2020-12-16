using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseMessageDynamicicondataModifyModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseMessageDynamicicondataModifyModel : AlipayObject
    {
        /// <summary>
        /// 微动效业务编码
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 微动效数据
        /// </summary>
        [JsonPropertyName("op_data")]
        public SingleDynamicData OpData { get; set; }

        /// <summary>
        /// 操作类型： ADD-新增数据 DEL-删除数据
        /// </summary>
        [JsonPropertyName("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
