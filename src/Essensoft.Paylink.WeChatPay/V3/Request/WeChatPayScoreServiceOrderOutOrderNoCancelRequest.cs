using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 微信支付分 - 取消支付分订单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_16.shtml">微信支付分 - 取消支付分订单API</a> - 最新更新时间：2020.04.23</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderOutOrderNoCancelRequest : IWeChatPayPostRequest<WeChatPayScoreServiceOrderOutOrderNoCancelResponse>
    {
        private WeChatPayObject bodyModel;

        /// <summary>
        /// 商户服务订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部服务订单号（不是交易单号），与创建订单时一致。
        /// <para>示例值：2304203423948239423</para>
        /// </remarks>
        public string OutOrderNo { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/serviceorder/{OutOrderNo}/cancel";
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
