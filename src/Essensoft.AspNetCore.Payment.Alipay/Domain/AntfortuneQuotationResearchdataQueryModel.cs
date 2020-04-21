using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneQuotationResearchdataQueryModel Data Structure.
    /// </summary>
    public class AntfortuneQuotationResearchdataQueryModel : AlipayObject
    {
        /// <summary>
        /// 需要获取数据的结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 预留的扩展字段，json格式。
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 字段名称，需要访问的表中哪些字段。比如open代表开盘价
        /// </summary>
        [JsonPropertyName("fields")]
        public List<string> Fields { get; set; }

        /// <summary>
        /// 选择性参数，用于附带一些查询条件。
        /// </summary>
        [JsonPropertyName("opt")]
        public string Opt { get; set; }

        /// <summary>
        /// 请求唯一id，用于排查问题
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 需要获取数据的开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 对象唯一标识代码，比如股票就是600000.SH，基金就是003003
        /// </summary>
        [JsonPropertyName("symbols")]
        public List<string> Symbols { get; set; }

        /// <summary>
        /// 表明需要访问的金融信息数据哪张表
        /// </summary>
        [JsonPropertyName("table")]
        public string Table { get; set; }
    }
}
