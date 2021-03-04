using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 微信支付分 - 同步服务订单信息
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_20.shtml">微信支付分 - 同步服务订单信息API</a> - 最新更新时间：2020.03.05</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderSyncRequest : IWeChatPayPostRequest<WeChatPayScoreServiceOrderSyncResponse>
    {
        private WeChatPayObject bodyModel;

        /// <summary>
        /// 商户服务订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部订单号（不是交易单号），要求此参数只能由数字、大小写字母_-|*组成，且在同一个商户号下唯一，详见「商户订单号」，需要和创建订单的商户服务订单号一致。
        /// <para>示例值：1234323JKHDFE1243252</para>
        /// </remarks>
        public string OutOrderNo { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/serviceorder/{OutOrderNo}/sync";
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
