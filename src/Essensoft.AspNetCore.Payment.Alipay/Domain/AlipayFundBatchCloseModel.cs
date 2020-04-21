using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundBatchCloseModel Data Structure.
    /// </summary>
    public class AlipayFundBatchCloseModel : AlipayObject
    {
        /// <summary>
        /// 支付宝内部的批次ID： 本参数和商户的批次号两者不能同时为空。 当本参数和商户的批次号两者同时提供时，将优先用商户的批次号进行查询。
        /// </summary>
        [JsonPropertyName("batch_trans_id")]
        public string BatchTransId { get; set; }

        /// <summary>
        /// 业务场景。不同场景值不同，具体值联系支付宝确认。
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务产品码。不同产品值不同，具体值联系支付宝确认。
        /// </summary>
        [JsonPropertyName("product_code")]
        public List<string> ProductCode { get; set; }
    }
}
