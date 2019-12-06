using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodRepayDeputyApplyModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodRepayDeputyApplyModel : AlipayObject
    {
        /// <summary>
        /// 网商分配的申请单号
        /// </summary>
        [JsonPropertyName("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 如果需要调整代客还款信息的时候，该项必填
        /// </summary>
        [JsonPropertyName("bill_list")]
        public List<SceneProdDeputyPaymentBillDetail> BillList { get; set; }

        /// <summary>
        /// 网商分配的支用单号
        /// </summary>
        [JsonPropertyName("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 操作类型：申请/修改/删除：  APPLY   ,  查询：QUERY
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 机构编码，机构接入场景金融平台时分配，固定值
        /// </summary>
        [JsonPropertyName("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 产品编码，场景金融平台给机构提供的产品编码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，比如支付宝userid
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
