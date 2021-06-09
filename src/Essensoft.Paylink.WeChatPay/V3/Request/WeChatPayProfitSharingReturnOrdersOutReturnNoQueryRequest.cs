using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 资金应用 - 分账 - 查询分账回退结果
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_4.shtml">分账 - 查询分账回退结果API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_4.shtml">分账(服务商) - 查询分账回退结果API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingReturnOrdersOutReturnNoQueryRequest : IWeChatPayGetRequest<WeChatPayProfitSharingReturnOrdersOutReturnNoQueryResponse>
    {
        private WeChatPayObject queryModel;

        /// <summary>
        /// 商户回退单号
        /// </summary>
        /// <remarks>
        /// 调用回退接口提供的商户系统内部的回退单号
        /// <para>示例值：R20190516001</para>
        /// </remarks>
        public string OutReturnNo { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/profitsharing/return-orders/{OutReturnNo}";
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
