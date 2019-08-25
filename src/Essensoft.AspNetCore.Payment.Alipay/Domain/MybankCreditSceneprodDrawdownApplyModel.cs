using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodDrawdownApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodDrawdownApplyModel : AlipayObject
    {
        /// <summary>
        /// 客户姓名
        /// </summary>
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 网商业务订单号,64个字符以内、只能包含字母、数字、下划线；需保证在外部网商端不重复
        /// </summary>
        [JsonProperty("mybk_order_no")]
        public string MybkOrderNo { get; set; }

        /// <summary>
        /// 操作类型： APPLY： 放款申请 ， RETRY： 修改信息后重试支付
        /// </summary>
        [JsonProperty("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 外部平台订单号,64个字符以内、只能包含字母、数字、下划线；需保证在外部平台端不重复
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 扩展参数，JSON格式，5000个字符以内
        /// </summary>
        [JsonProperty("out_param")]
        public string OutParam { get; set; }

        /// <summary>
        /// 外部请求流水号,32个字符以内、只能包含字母、数字、下划线；需保证在外部平台端不重复
        /// </summary>
        [JsonProperty("out_seq_no")]
        public string OutSeqNo { get; set; }

        /// <summary>
        /// 支付信息明细
        /// </summary>
        [JsonProperty("payment_detail_list")]
        public List<SceneProdPaymentAccountInfo> PaymentDetailList { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，该字段内容与site的内容相关
        /// </summary>
        [JsonProperty("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
