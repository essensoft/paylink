using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.mobile.recommend.get
    /// </summary>
    public class AlipayMobileRecommendGetRequest : IAlipayRequest<AlipayMobileRecommendGetResponse>
    {
        /// <summary>
        /// 请求上下文扩展信息，需要与接口负责人约定。格式为json对象。
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        /// 期望获取的最多推荐数量, 默认获取一个推荐内容, 0表示获取所有推荐内容
        /// </summary>
        public string Limit { get; set; }

        /// <summary>
        /// 所使用的场景id，请向接口负责人申请
        /// </summary>
        public string SceneId { get; set; }

        /// <summary>
        /// 获取推荐信息的开始位置, 默认从0开始
        /// </summary>
        public string StartIdx { get; set; }

        /// <summary>
        /// 用户openid
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
            return "alipay.mobile.recommend.get";
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
                { "ext_info", ExtInfo },
                { "limit", Limit },
                { "scene_id", SceneId },
                { "start_idx", StartIdx },
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
