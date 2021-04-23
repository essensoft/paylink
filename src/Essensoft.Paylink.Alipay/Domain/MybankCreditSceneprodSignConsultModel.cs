using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodSignConsultModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodSignConsultModel : AlipayObject
    {
        /// <summary>
        /// 网商申请单号，S结尾
        /// </summary>
        [JsonPropertyName("app_seq_no")]
        public string AppSeqNo { get; set; }

        /// <summary>
        /// 机构发给银行签约咨询的相关内容，与机构合约内容保持一致
        /// </summary>
        [JsonPropertyName("data_info")]
        public string DataInfo { get; set; }

        /// <summary>
        /// 签约环节，用于区分签约的类型
        /// </summary>
        [JsonPropertyName("sign_stage")]
        public string SignStage { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，比如支付宝userid或者身份证，与site值相关
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
