using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 关闭订单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_3.shtml">JSAPI支付 - 关单API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_3.shtml">APP支付 - 关单API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_3.shtml">H5支付 - 关单API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_3.shtml">Native支付 - 关单API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_3.shtml">小程序支付 - 关单API</a> - 最新更新时间：2020.05.26</para>
    /// </remarks>
    public class WeChatPayTransactionsOutTradeNoCloseRequest : IWeChatPayPostRequest<WeChatPayTransactionsOutTradeNoCloseResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一，详见【商户订单号】。
        /// 特殊规则：最小字符长度为6
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        public string OutTradeNo { get; set; }

        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/pay/transactions/out-trade-no/{OutTradeNo}/close";
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
