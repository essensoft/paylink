using System;
using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 特约商户进件 - 查询申请单状态
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter11_1_2.shtml">特约商户进件 - 查询申请单状态API</a> - 最新更新时间：2020.2.11</para>
    /// </remarks>
    public class WeChatPayApplyment4SubApplymentApplymentIdRequest : IWeChatPayGetRequest<WeChatPayApplyment4SubApplymentApplymentIdResponse>
    {
        /// <summary>
        /// 微信支付申请单号
        /// </summary>
        /// <remarks>
        /// 微信支付分配的申请单号。
        /// <para>示例值：2000001234567890</para>
        /// </remarks>
        public string ApplymentId { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/applyment4sub/applyment/applyment_id/{ApplymentId}";
        }

        public WeChatPayObject GetQueryModel()
        {
            throw new NotImplementedException();
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            throw new NotImplementedException();
        }

        public bool GetNeedQueryModel()
        {
            return false;
        }
    }
}
