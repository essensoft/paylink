using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryBizinfoApplyModel Data Structure.
    /// </summary>
    public class AlipayEbppIndustryBizinfoApplyModel : AlipayObject
    {
        /// <summary>
        /// 业务能力码，标识业务场景
        /// </summary>
        [JsonPropertyName("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// 业务账户号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务机构简称
        /// </summary>
        [JsonPropertyName("biz_inst")]
        public string BizInst { get; set; }

        /// <summary>
        /// 业务类型，公服业务：IND
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 外部申请流水号，支持幂等
        /// </summary>
        [JsonPropertyName("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 请求上下文，json格式
        /// </summary>
        [JsonPropertyName("request_context")]
        public string RequestContext { get; set; }
    }
}
