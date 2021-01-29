using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - 商户订单号查询
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_2.shtml">JSAPI支付 - 查询订单API - 商户订单号查询</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_2.shtml">APP支付 - 查询订单API - 商户订单号查询</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_2.shtml">H5支付 - 查询订单API - 商户订单号查询</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_2.shtml">Native支付 - 查询订单API - 商户订单号查询</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_2.shtml">小程序支付 - 查询订单API - 商户订单号查询</a></para>
    /// 最新更新时间：2021.1.14
    /// </summary>
    public class WeChatPayTransactionsOutTradeNoRequest : IWeChatPayGetRequest<WeChatPayTransactionsOutTradeNoResponse>
    {
        private WeChatPayObject queryModel;

        /// <summary>
        /// 商户订单号
        /// 商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一，详见【商户订单号】。
        /// 特殊规则：最小字符长度为6
        /// 示例值：1217752501201407033233368018
        /// </summary>
        public string OutTradeNo { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/pay/transactions/out-trade-no/{OutTradeNo}";
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
