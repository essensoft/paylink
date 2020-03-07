using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.gotone.message.courier.send
    /// </summary>
    public class AlipayGotoneMessageCourierSendRequest : IAlipayRequest<AlipayGotoneMessageCourierSendResponse>
    {
        /// <summary>
        /// 模板参数,键值对，以竖线分割
        /// </summary>
        public string Arguments { get; set; }

        /// <summary>
        /// 扩展信息。IMEI表示钱包客户端IMEI号；CURRENT_STEP表示消息进度节点,必须为数字； IS_CORRECT表示当前节点是正常还是异常分支，必须为Y或者N; todoPublicId表示钱包公众号id。注意：上诉key值必须严格匹配，大小写敏感
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        /// 业务配置码serviceCode
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 用户的支付宝ID
        /// </summary>
        public string UserId { get; set; }

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
            return "alipay.gotone.message.courier.send";
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
                { "arguments", Arguments },
                { "ext_info", ExtInfo },
                { "service_code", ServiceCode },
                { "user_id", UserId }
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
