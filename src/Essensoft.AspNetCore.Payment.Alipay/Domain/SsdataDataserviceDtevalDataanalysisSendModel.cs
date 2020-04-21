using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceDtevalDataanalysisSendModel Data Structure.
    /// </summary>
    public class SsdataDataserviceDtevalDataanalysisSendModel : AlipayObject
    {
        /// <summary>
        /// 业务编号, 唯一流水标识
        /// </summary>
        [JsonPropertyName("biz_number")]
        public string BizNumber { get; set; }

        /// <summary>
        /// 业务来源，暂只支持上数来源数据流入
        /// </summary>
        [JsonPropertyName("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 授权采集数据，爬取的完整数据加部分业务标识信息
        /// </summary>
        [JsonPropertyName("data_content")]
        public string DataContent { get; set; }

        /// <summary>
        /// 处理业务类型，包括运营商、公积金等
        /// </summary>
        [JsonPropertyName("process_biz_type")]
        public string ProcessBizType { get; set; }
    }
}
