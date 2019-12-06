using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseRelationCombinedQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseRelationCombinedQueryModel : AlipayObject
    {
        /// <summary>
        /// 最大需要返回的列表值
        /// </summary>
        [JsonPropertyName("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 关系查询的业务类型编号，此类型由mobilerelation分配，不同的类型对应不同的结果集
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
