using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCodedepositModel Data Structure.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherCodedepositModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券码的数量列表。接口参数为列表类型。  限制： 目前最大上传 1000 个。  单个code最长64位。  商户上传的券code列表，code允许包含的字符有0-9、a-z、A-Z、-、_、+、=、|。
        /// </summary>
        [JsonPropertyName("voucher_codes")]
        public List<string> VoucherCodes { get; set; }
    }
}
