using System;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 商户进件（普通服务商）- 查询申请单状态API
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/tool/applyment4sub/chapter3_2.shtml">查询申请单状态API</a></para>
    /// 最新更新时间：2020.2.11
    /// </summary>
    public class WeChatPayApplyment4SubApplymentBusinessCodeRequest : IWeChatPayGetRequest<WeChatPayApplyment4SubApplymentBusinessCodeResponse>
    {
        /// <summary>
        /// 业务申请编号
        /// 1、只能由数字、字母或下划线组成，建议前缀为服务商商户号。
        /// 2、服务商自定义的唯一编号。
        /// 3、每个编号对应一个申请单，每个申请单审核通过后生成一个微信支付商户号。
        /// 4、若申请单被驳回，可填写相同的“业务申请编号”，即可覆盖修改原申请单信息。
        /// 示例值：1900013511_10000
        /// </summary>
        public string BusinessCode { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/applyment4sub/applyment/business_code/{BusinessCode}";
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
