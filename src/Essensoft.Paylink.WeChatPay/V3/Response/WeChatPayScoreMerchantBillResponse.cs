using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 微信支付分 - 商户申请获取对账单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_29.shtml">微信支付分 - 商户申请获取对账单API</a> - 最新更新时间：2021.09.18</para>
    /// </remarks>
    public class WeChatPayScoreMerchantBillResponse : WeChatPayResponse
    {
        /// <summary>
        /// 账单的分块数量
        /// </summary>
        /// <remarks>
        /// <para>示例值：1</para>
        /// </remarks>
        [JsonPropertyName("download_bill_count")]
        public string DownloadBillCount { get; set; }

        /// <summary>
        /// 下载信息明细
        /// </summary>
        /// <remarks>
        /// 账单每个分块的详细信息
        /// </remarks>
        [JsonPropertyName("download_bill_list")]
        public List<ScoreDownloadMerchantBill> DownloadBillList { get; set; }
    }
}
