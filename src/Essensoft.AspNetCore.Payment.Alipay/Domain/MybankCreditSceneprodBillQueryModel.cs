using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodBillQueryModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodBillQueryModel : AlipayObject
    {
        /// <summary>
        /// 网商银行的申请单号，通过mybank.credit.sceneprod.loan.apply接口返回的applyno获取
        /// </summary>
        [JsonPropertyName("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 支用号，银行直投模式才会使用，需要和app_seqno一并传来
        /// </summary>
        [JsonPropertyName("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝 ，PERSON 身份证
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，比如支付宝userid， 填入的值与site值相关。
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
