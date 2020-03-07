using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodDataBatchqueryModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodDataBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 订单信息查询参数+ 复杂类型中包括申请单号和客户支付宝uid，通过传递这个列表数据进行批量查询订单信息+ 其中的app_seqno是网商银行的申请单号，通过mybank.credit.sceneprod.loan.apply接口返回的apply_no获取，其中site_user_id是客户的支付宝id，机构通过服务窗获取。
        /// </summary>
        [JsonPropertyName("app_seqno_list")]
        public List<SceneProdDataQueryParam> AppSeqnoList { get; set; }
    }
}
