using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiQualityTestShieldTestcaseQueryModel Data Structure.
    /// </summary>
    public class KoubeiQualityTestShieldTestcaseQueryModel : AlipayObject
    {
        /// <summary>
        /// 接口支持两种维度的查询 1 测试集维度，如果想查询测试集，biz_id输入测试集id 2 测试用例维度，如果想查询测试用例，biz_id输入测试  单个查询（单个id  EG:123） 多个查询（多个id  EG:123,321） 全部查询（全部id  EG:ALL）
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 测试集维度：COLLECTION_TYPE 测试用例维度：CASE_TYPE 全部数据：ALL
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 参数名：isv名称 应用场景：isv需要输入自己的名称，用来查询当前isv下的测试用例
        /// </summary>
        [JsonPropertyName("isv_name")]
        public string IsvName { get; set; }
    }
}
