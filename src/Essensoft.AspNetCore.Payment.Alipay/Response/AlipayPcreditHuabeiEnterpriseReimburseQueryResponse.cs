using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiEnterpriseReimburseQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiEnterpriseReimburseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 导出数据详情列表
        /// </summary>
        [JsonPropertyName("record_detail_list")]
        public List<RecordDetail> RecordDetailList { get; set; }
    }
}
