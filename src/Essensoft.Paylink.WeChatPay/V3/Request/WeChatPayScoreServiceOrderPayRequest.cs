using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 微信支付分 - 商户发起催收扣款
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_19.shtml">微信支付分 - 商户发起催收扣款API</a> - 最新更新时间：2020.03.05</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderPayRequest : IWeChatPayPostRequest<WeChatPayScoreServiceOrderPayResponse>
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
            return $"https://api.mch.weixin.qq.com/v3/payscore/serviceorder/{OutOrderNo}/pay";
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
