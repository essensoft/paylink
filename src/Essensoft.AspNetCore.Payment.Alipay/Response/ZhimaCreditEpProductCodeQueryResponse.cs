using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpProductCodeQueryResponse.
    /// </summary>
    public class ZhimaCreditEpProductCodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务明细信息：  biz_no:业务借据号  biz_date：支用日期  biz_amount:支用金额  biz_user_id:业务消费者唯一标志
        /// </summary>
        [JsonPropertyName("biz_info")]
        public List<BizResData> BizInfo { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_cnt")]
        public long TotalCnt { get; set; }
    }
}
