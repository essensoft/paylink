using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskAudioSetModel Data Structure.
    /// </summary>
    public class SsdataDataserviceRiskAudioSetModel : AlipayObject
    {
        /// <summary>
        /// 关键词创建人，也即使用者
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 要删除的关键词id
        /// </summary>
        [JsonPropertyName("id_list")]
        public List<string> IdList { get; set; }

        /// <summary>
        /// 新增或查询的关键词。新增时，可以传多个用以批量新增；查询时候，可以不传或只传一个。
        /// </summary>
        [JsonPropertyName("keyword_list")]
        public List<string> KeywordList { get; set; }

        /// <summary>
        /// 修改人，一般的修改指的是删除
        /// </summary>
        [JsonPropertyName("modifier")]
        public string Modifier { get; set; }

        /// <summary>
        /// add 表示新增；delete 表示删除；query 表示查询；
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 一页展示数量
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 关键词风险类型，批量增加时候，该批关键词为同一风险类型。1-涉政，2-涉黄
        /// </summary>
        [JsonPropertyName("risk_type")]
        public string RiskType { get; set; }
    }
}
