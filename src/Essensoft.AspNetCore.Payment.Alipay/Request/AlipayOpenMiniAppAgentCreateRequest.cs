using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.open.mini.app.agent.create
    /// </summary>
    public class AlipayOpenMiniAppAgentCreateRequest : IAlipayUploadRequest<AlipayOpenMiniAppAgentCreateResponse>
    {
        /// <summary>
        /// 商家小程序描述信息，简要描述小程序主要功能（20-200个字），例：xx小程序提供了xx功能，主要解决了XX问题。
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序logo图片文件，最大256KB，长宽比1:1, 不允许涉及政治敏感与色情；图片格式必须为：png、jpeg、jpg，建议上传像素为180*180
        /// </summary>
        public FileItem AppLogo { get; set; }

        /// <summary>
        /// 小程序的中文名称，3-40个字符，一个中文对应两个字符，必须全局唯一，详细规则可参见名称审核规范：https://opendocs.alipay.com/mini/operation/standard/auditing/name
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 小程序的简介，用于简短描述小程序提供的功能，10-32个字符，一个中文两个字符，详细的审核规范请参见：https://opendocs.alipay.com/mini/operation/standard/auditing/cvdkep
        /// </summary>
        public string AppSlogan { get; set; }

        /// <summary>
        /// 联系人姓名，仅仅在开发者从未入驻过开放平台的情况下需要提供该字段
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 开发者联系人信息，仅在开发者从未入驻过开放平台的情况下需要提供；如果开发者已经入驻过开放平台，那么该字段无需提供。
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// 支付宝会员用户登录号，如果是企业账户，应该使用企业的支付宝登录号，
        /// </summary>
        public string LoginId { get; set; }

        /// <summary>
        /// 新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list，需要注意个人账户类目是受限的，不能使用企业类目，但是企业可以使用个人类目。
        /// </summary>
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商家小程序的客服电话，用于向用户展示客服信息
        /// </summary>
        public string ServicePhone { get; set; }

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

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.mini.app.agent.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "app_desc", AppDesc },
                { "app_name", AppName },
                { "app_slogan", AppSlogan },
                { "contact_name", ContactName },
                { "contact_phone", ContactPhone },
                { "login_id", LoginId },
                { "mini_category_ids", MiniCategoryIds },
                { "out_biz_no", OutBizNo },
                { "service_phone", ServicePhone }
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

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>
            {
                { "app_logo", AppLogo }
            };
            return parameters;
        }

        #endregion
    }
}
