using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeProvcityQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppProdmodeProvcityQueryModel : AlipayObject
    {
        /// <summary>
        /// 省市编号
        /// </summary>
        [JsonPropertyName("adcode")]
        public string Adcode { get; set; }

        /// <summary>
        /// 查询类型，queryType=1,查询省下面的市信息
        /// </summary>
        [JsonPropertyName("query_type")]
        public string QueryType { get; set; }
    }
}
