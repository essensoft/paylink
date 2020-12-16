using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceGasInfoGroupcouponQueryResponse.
    /// </summary>
    public class AlipayCommerceGasInfoGroupcouponQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码,不填写默认查第1页
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页显示数量,不填写默认10条
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }

        /// <summary>
        /// 用户劵信息
        /// </summary>
        [JsonPropertyName("voucher_infos")]
        public List<VoucherInfoVO> VoucherInfos { get; set; }
    }
}
