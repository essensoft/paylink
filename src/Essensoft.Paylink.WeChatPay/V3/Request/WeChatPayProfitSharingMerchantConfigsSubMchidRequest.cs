using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 资金应用 - 分账 - 查询最大分账比例
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_7.shtml">分账(服务商) - 查询最大分账比例API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingMerchantConfigsSubMchidRequest : IWeChatPayGetRequest<WeChatPayProfitSharingMerchantConfigsSubMchidResponse>
    {
        private WeChatPayObject queryModel;

        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 微信支付分配的子商户号，即分账的出资商户号。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        public string SubMchid { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/profitsharing/merchant-configs/{SubMchid}";
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
