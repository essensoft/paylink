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
    public class WeChatPayApplyment4SubApplymentBusinessCodeRequest : IWeChatPayGetRequest<WeChatPayApplyment4SubApplymentBusinessCodeResponse>
    {
        /// <summary>
        /// 业务申请编号
        /// </summary>
        /// <remarks>
        /// 1、只能由数字、字母或下划线组成，建议前缀为服务商商户号。
        /// 2、服务商自定义的唯一编号。
        /// 3、每个编号对应一个申请单，每个申请单审核通过后生成一个微信支付商户号。
        /// 4、若申请单被驳回，可填写相同的“业务申请编号”，即可覆盖修改原申请单信息。
        /// <para>示例值：1900013511_10000</para>
        /// </remarks>
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
