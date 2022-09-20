using System;
using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 电商收付通 - 通过申请单ID查询申请状态 - 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_1_2.shtml">电商收付通 - 通过申请单ID查询申请状态</a> - 最新更新时间：2022.04.08</para>
    /// </remarks>
    public class WeChatPayEcommerceApplymentsQueryRequest : IWeChatPayGetRequest<WeChatPayEcommerceApplymentsQueryResponse>
    {
        /// <summary>
        /// 微信支付申请单号
        /// </summary>
        /// <remarks>
        /// 申请单的主键，唯一定义此资源的标识。
        /// <para>示例值：2000002124775691</para>
        /// </remarks>
        public string ApplymentId { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/ecommerce/applyments/{ApplymentId}";
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
