using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - 查询单笔退款
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_10.shtml">JSAPI支付 - 查询单笔退款</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_10.shtml">APP支付 - 查询单笔退款</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_10.shtml">H5支付 - 查询单笔退款</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_10.shtml">Native支付 - 查询单笔退款</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_10.shtml">小程序支付 - 查询单笔退款</a></para>
    /// 最新更新时间：2021.1.15
    /// </summary>
    public class WeChatPayRefundDomesticRefundsOutRefundNoRequest : IWeChatPayGetRequest<WeChatPayRefundDomesticRefundsOutRefundNoResponse>
    {
        private WeChatPayObject queryModel;

        /// <summary>
        /// 商户退款单号
        /// 商户系统内部的退款单号，商户系统内部唯一，只能是数字、大小写字母_-|*@ ，同一退款单号多次请求只退一笔。
        /// 示例值：1217752501201407033233368018
        /// </summary>
        public string OutRefundNo { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/refund/domestic/refunds/{OutRefundNo}";
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
