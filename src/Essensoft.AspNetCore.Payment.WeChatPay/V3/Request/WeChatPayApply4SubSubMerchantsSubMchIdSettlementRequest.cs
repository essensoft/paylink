using System;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 商户进件 - 查询结算账户API（普通服务商）
    /// 最新更新时间：2019.09.09
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/tool/applyment4sub/chapter3_4.shtml
    /// </summary>
    public class WeChatPayApply4SubSubMerchantsSubMchIdSettlementRequest : IWeChatPayGetRequest<WeChatPayApply4SubSubMerchantsSubMchIdSettlementResponse>
    {
        /// <summary>
        /// 特约商户号	
        /// 请输入本服务商进件、已签约的特约商户号。
        /// 示例值：1900006491
        /// </summary>
        public string SubMchId { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/apply4sub/sub_merchants/{SubMchId}/settlement";
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
