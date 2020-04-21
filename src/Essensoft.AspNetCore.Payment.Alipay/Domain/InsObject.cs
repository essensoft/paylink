using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsObject Data Structure.
    /// </summary>
    public class InsObject : AlipayObject
    {
        /// <summary>
        /// 标的物的标识id
        /// </summary>
        [JsonPropertyName("insured_object_id")]
        public string InsuredObjectId { get; set; }

        /// <summary>
        /// 标的信息;标准json 格式
        /// </summary>
        [JsonPropertyName("insured_object_info")]
        public string InsuredObjectInfo { get; set; }

        /// <summary>
        /// 标的类型;0:财产所在地;1:其它;2:车;3:资金债务;4:电商订单
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
