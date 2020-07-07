using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 查询订单API - 微信支付订单号查询
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_5.shtml
    /// </summary>
    public class WeChatPayTransactionsIdRequest : IWeChatPayGetRequest<WeChatPayTransactionsIdResponse>
    {
        /// <summary>
        /// 直连商户号
        /// 直连商户的商户号，由微信支付生成并下发。
        /// 示例值：1230000109
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// 微信支付订单号
        /// 微信支付系统生成的订单号
        /// 示例值：1217752501201407033233368018
        /// </summary>
        public string TransactionId { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/pay/transactions/id/{TransactionId}?mchid={MchId}";
        }
    }
}
