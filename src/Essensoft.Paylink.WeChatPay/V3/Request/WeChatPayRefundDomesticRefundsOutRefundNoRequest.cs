using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 查询单笔退款
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_10.shtml">基础支付 - JSAPI支付 - 查询单笔退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_10.shtml">基础支付 - APP支付 - 查询单笔退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_10.shtml">基础支付 - H5支付 - 查询单笔退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_10.shtml">基础支付 - Native支付 - 查询单笔退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_10.shtml">基础支付 - 小程序支付 - 查询单笔退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_10.shtml">基础支付(服务商) - JSAPI支付 - 查询单笔退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_10.shtml">基础支付(服务商) - APP支付 - 查询单笔退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_10.shtml">基础支付(服务商) - H5支付 - 查询单笔退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_10.shtml">基础支付(服务商) - Native支付 - 查询单笔退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_10.shtml">基础支付(服务商) - 小程序支付 - 查询单笔退款API</a> - 最新更新时间：2021.05.28</para>
    /// </remarks>
    public class WeChatPayRefundDomesticRefundsOutRefundNoRequest : IWeChatPayGetRequest<WeChatPayRefundDomesticRefundsOutRefundNoResponse>
    {
        private WeChatPayObject queryModel;

        /// <summary>
        /// 商户退款单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部的退款单号，商户系统内部唯一，只能是数字、大小写字母_-|*@ ，同一退款单号多次请求只退一笔。
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
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

        public bool GetNeedQueryModel()
        {
            return true;
        }
    }
}
