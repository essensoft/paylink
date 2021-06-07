using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 资金应用 - 分账 - 查询剩余待分金额
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_6.shtml">分账 - 查询剩余待分金额API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_6.shtml">分账(服务商) - 查询剩余待分金额API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingTransactionsTransactionIdAmountsRequest : IWeChatPayGetRequest<WeChatPayProfitSharingTransactionsTransactionIdAmountsResponse>
    {
        private WeChatPayObject queryModel;

        /// <summary>
        /// 微信订单号
        /// </summary>
        /// <remarks>
        /// 微信支付订单号
        /// <para>示例值：4208450740201411110007820472</para>
        /// </remarks>
        public string TransactionId { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/profitsharing/transactions/{TransactionId}/amounts";
        }

        public WeChatPayObject GetQueryModel()
        {
            return queryModel;
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            this.queryModel = queryModel;
        }
    }
}
