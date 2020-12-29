using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.member.coupon.querylist
    /// </summary>
    public class AlipayMemberCouponQuerylistRequest : IAlipayRequest<AlipayMemberCouponQuerylistResponse>
    {
        /// <summary>
        /// 红包发放者商户信息，json格式。商户可以传自己的PID，平台商可以传其它商户的PID用于查询指定商户的信息  目前仅支持如下key：    unique：商户唯一标识    unique_type：支持以下1种取值。  PID：商户所在平台商的partner id[唯一]
        /// </summary>
        public string MerchantInfo { get; set; }

        /// <summary>
        /// 翻页页码：翻页查询时使用，表明当前要查询第几页，若page_size为0，则此字段不生效
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 翻页每页条数：翻页查询时使用，表明每页返回的记录数量，范围为1至20；为空或者为0时表示不使用翻页查询，返回所有数量
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// 优惠券状态列表，如果指定则只返回指定状态的优惠券.  目前状态主要有以下几种：  VALID：可使用  WRITED_OFF：已核销,  EXPIRED：已过期  CLOSED：已关闭   注意：  多个状态以逗号隔开
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 劵所有者买家用户信息，必须是支付宝的用户，json格式。  目前仅支持如下key：    unique：用户唯一标识    unique_type：支持以下1种取值。  UID：用户支付宝账户的唯一ID  OPENID：用户支付宝账户在某商户下的唯一ID
        /// </summary>
        public string UserInfo { get; set; }

        #region IAlipayRequest Members
        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {
            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public string GetApiName()
        {
            return "alipay.member.coupon.querylist";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "merchant_info", MerchantInfo },
                { "page_no", PageNo },
                { "page_size", PageSize },
                { "status", Status },
                { "user_info", UserInfo }
            };
            return parameters;
        }

        public AlipayObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AlipayObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
