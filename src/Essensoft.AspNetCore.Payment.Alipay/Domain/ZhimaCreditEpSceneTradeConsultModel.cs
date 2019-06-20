using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneTradeConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpSceneTradeConsultModel : AlipayObject
    {
        /// <summary>
        /// 信用交易额度，单位为：人民币分，整型；
        /// </summary>
        [JsonProperty("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// 业务数据传输扩展参数，以json形式传输。具体行业需要传输的数据参见具体行业的对接文档
        /// </summary>
        [JsonProperty("biz_ext_param")]
        public string BizExtParam { get; set; }

        /// <summary>
        /// 客户评估单号
        /// </summary>
        [JsonProperty("customer_rating_no")]
        public string CustomerRatingNo { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，64位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性。
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品码，请填写示例值里提供的值
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }
    }
}
