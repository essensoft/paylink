using System;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 查询申请单状态API（普通服务商）
    /// 最新更新时间：2020.2.11
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/tool/applyment4sub/chapter3_2.shtml
    /// </summary>
    public class WeChatPayApplyment4SubApplymentApplymentIdRequest : IWeChatPayGetRequest<WeChatPayApplyment4SubApplymentApplymentIdResponse>
    {
        /// <summary>
        /// 微信支付申请单号	
        /// 微信支付分配的申请单号。
        /// 示例值：2000001234567890
        /// </summary>
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
    }
}
