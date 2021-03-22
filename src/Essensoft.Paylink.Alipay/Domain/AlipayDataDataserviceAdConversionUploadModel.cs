using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdConversionUploadModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdConversionUploadModel : AlipayObject
    {
        /// <summary>
        /// 代理商访问灯火平台的token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 转化数据列表, 最多1000条
        /// </summary>
        [JsonPropertyName("conversion_data_list")]
        public List<ConversionData> ConversionDataList { get; set; }
    }
}
