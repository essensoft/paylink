using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 查询订单 - 微信支付订单号查询
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_2.shtml">JSAPI支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">APP支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">H5支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">Native支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">小程序支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// </remarks>
    public class WeChatPayPartnerTransactionsIdRequest : IWeChatPayGetRequest<WeChatPayPartnerTransactionsIdResponse>
    {
        private WeChatPayObject queryModel;

        /// <summary>
        /// 微信支付订单号
        /// </summary>
        /// <remarks>
        /// 微信支付系统生成的订单号
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        public string TransactionId { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/pay/partner/transactions/id/{TransactionId}";
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
