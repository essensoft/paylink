using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarCarmodelBatchqueryResponse.
    /// </summary>
    public class AlipayEcoMycarCarmodelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 以下是对查询结果query_result：查询品牌信息返回的json格式的品牌信息列表中字段属性的详细描述说明；查询车系信息返回的json格式的车系信息列表中字段属性的详细描述说明；查询车型信息返回的json格式的车型信息列表中字段属性的详细描述说明。
        /// </summary>
        [JsonPropertyName("query_result")]
        public QueryResult QueryResult { get; set; }

        /// <summary>
        /// 查询类型，接口通过此参数判断本次请求是查询品牌信息还是车型信息等，brands（查询品牌），series（查询车系），company(厂商)，models（查询车型）
        /// </summary>
        [JsonPropertyName("query_type")]
        public string QueryType { get; set; }
    }
}
