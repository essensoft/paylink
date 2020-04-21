using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneProductInquiryApplyModel Data Structure.
    /// </summary>
    public class AlipayInsSceneProductInquiryApplyModel : AlipayObject
    {
        /// <summary>
        /// 保险产品的投保人,当产品价格和投保人有关时候需传值
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 投保业务参数，标准json格式支付串
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 份数
        /// </summary>
        [JsonPropertyName("copies_count")]
        public string CopiesCount { get; set; }

        /// <summary>
        /// 保险被保人,产品价格和被保人相关时传值。
        /// </summary>
        [JsonPropertyName("insureds")]
        public List<InsPerson> Insureds { get; set; }

        /// <summary>
        /// 询价流水号，标识一次询价请求
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 险种保障期限,数字+"Y/M/D"结尾,非固定期限险种或多固定期限险种必填
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 保险产品码，由保险产品小二分配
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 投保来源渠道，由保险产品小二分配
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 产品险种对应的保额(金额类型，单位为分，例如100000为1000元)。产品保额类型为金额时必传
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public long SumInsured { get; set; }
    }
}
