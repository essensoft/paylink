using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - 合单支付 - 合单关闭订单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_12.shtml">基础支付 - 合单支付 -  合单关闭订单API</a> - 最新更新时间：2020.03.31</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_12.shtml">基础支付(服务商) - 合单支付 -  合单关闭订单API</a> - 最新更新时间：2020.03.31</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsOutTradeNoCloseRequest : IWeChatPayPostRequest<WeChatPayCombineTransactionsOutTradeNoCloseResponse>
    {
        /// <summary>
        /// 合单商户订单号
        /// </summary>
        /// <remarks>
        /// 合单支付总订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一 。
        /// <para>示例值：P20150806125346</para>
        /// </remarks>
        public string CombineOutTradeNo { get; set; }

        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/combine-transactions/out-trade-no/{CombineOutTradeNo}/close";
        }

        public WeChatPayObject GetBodyModel()
        {
            return bodyModel;
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            this.bodyModel = bodyModel;
        }
    }
}
