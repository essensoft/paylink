using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 查询订单 - 商户订单号查询
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_2.shtml">JSAPI支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">APP支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">H5支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">Native支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">小程序支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// </remarks>
    public class WeChatPayPartnerTransactionsOutTradeNoRequest : IWeChatPayGetRequest<WeChatPayPartnerTransactionsOutTradeNoResponse>
    {
        private WeChatPayObject queryModel;

        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一，详见【商户订单号】。
        /// 特殊规则：最小字符长度为6
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        public string OutTradeNo { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/pay/partner/transactions/out-trade-no/{OutTradeNo}";
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
