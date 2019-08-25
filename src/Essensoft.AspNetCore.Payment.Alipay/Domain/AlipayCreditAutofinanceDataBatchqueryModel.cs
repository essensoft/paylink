using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCreditAutofinanceDataBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCreditAutofinanceDataBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 订单信息查询参数+ 复杂类型中包括申请单号和客户支付宝uid，通过传递这个列表数据进行批量查询订单信息+ 其中的app_seqno是网商银行的申请单号，通过alipay.credit.autofinance.loan.apply 接口返回的applyno获取，其中uid是客户的支付宝id，机构通过服务窗获取。
        /// </summary>
        [JsonProperty("app_seqno_list")]
        public List<SceneDataQueryParam> AppSeqnoList { get; set; }
    }
}
