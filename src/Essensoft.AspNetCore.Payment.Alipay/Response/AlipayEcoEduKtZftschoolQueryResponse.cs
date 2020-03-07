using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduKtZftschoolQueryResponse.
    /// </summary>
    public class AlipayEcoEduKtZftschoolQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户进件失败原因。有则返回，进件成功则不返回，失败原因可参考直付通接口说明，https://docs.alipay.com/pre-open/api_pre/ant.merchant.expand.indirect.zft.create
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 支付宝中小学教育缴费分配给学校的编码，学校在支付宝的标识，发账单需带此参数
        /// </summary>
        [JsonPropertyName("school_no")]
        public string SchoolNo { get; set; }

        /// <summary>
        /// 直付通二级商户id，商户进件审核通过后会有smid，发账单接口的school_pid填写此字段，如果为空，则审核未通过，无法发账单
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 进件流程状态  CREATED 已创建  SUBMITTED 已提交  SUBMIT_FAIL 提交失败  AUDIT_SUCCESS 审核成功  AUDIT_FAIL 审核失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
