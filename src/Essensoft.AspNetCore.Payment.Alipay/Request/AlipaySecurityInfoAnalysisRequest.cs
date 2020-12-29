using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.security.info.analysis
    /// </summary>
    public class AlipaySecurityInfoAnalysisRequest : IAlipayRequest<AlipaySecurityInfoAnalysisResponse>
    {
        /// <summary>
        /// 客户端的基带版本
        /// </summary>
        public string EnvClientBaseBand { get; set; }

        /// <summary>
        /// 客户端连接的基站信息
        /// </summary>
        public string EnvClientBaseStation { get; set; }

        /// <summary>
        /// 客户端的经纬度坐标
        /// </summary>
        public string EnvClientCoordinates { get; set; }

        /// <summary>
        /// 操作的客户端的imei
        /// </summary>
        public string EnvClientImei { get; set; }

        /// <summary>
        /// 操作的客户端的imsi
        /// </summary>
        public string EnvClientImsi { get; set; }

        /// <summary>
        /// IOS设备的UDID
        /// </summary>
        public string EnvClientIosUdid { get; set; }

        /// <summary>
        /// 操作的客户端ip
        /// </summary>
        public string EnvClientIp { get; set; }

        /// <summary>
        /// 操作的客户端mac
        /// </summary>
        public string EnvClientMac { get; set; }

        /// <summary>
        /// 操作的客户端分辨率，格式为：水平像素^垂直像素；如：800^600
        /// </summary>
        public string EnvClientScreen { get; set; }

        /// <summary>
        /// 客户端设备的统一识别码UUID
        /// </summary>
        public string EnvClientUuid { get; set; }

        /// <summary>
        /// JS SDK生成的 tokenID
        /// </summary>
        public string JsTokenId { get; set; }

        /// <summary>
        /// 签约的支付宝账号对应的支付宝唯一用户号
        /// </summary>
        public string PartnerId { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        public string SceneCode { get; set; }

        /// <summary>
        /// 卖家账户ID
        /// </summary>
        public string UserAccountNo { get; set; }

        /// <summary>
        /// 用户绑定银行卡号
        /// </summary>
        public string UserBindBankcard { get; set; }

        /// <summary>
        /// 用户绑定银行卡的卡类型
        /// </summary>
        public string UserBindBankcardType { get; set; }

        /// <summary>
        /// 用户绑定手机号
        /// </summary>
        public string UserBindMobile { get; set; }

        /// <summary>
        /// 用户证件类型
        /// </summary>
        public string UserIdentityType { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string UserRealName { get; set; }

        /// <summary>
        /// 用户注册时间
        /// </summary>
        public string UserRegDate { get; set; }

        /// <summary>
        /// 用户注册Email
        /// </summary>
        public string UserRegEmail { get; set; }

        /// <summary>
        /// 用户注册手机号
        /// </summary>
        public string UserRegMobile { get; set; }

        /// <summary>
        /// 用户证件号码
        /// </summary>
        public string UserrIdentityNo { get; set; }

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
            return "alipay.security.info.analysis";
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
                { "env_client_base_band", EnvClientBaseBand },
                { "env_client_base_station", EnvClientBaseStation },
                { "env_client_coordinates", EnvClientCoordinates },
                { "env_client_imei", EnvClientImei },
                { "env_client_imsi", EnvClientImsi },
                { "env_client_ios_udid", EnvClientIosUdid },
                { "env_client_ip", EnvClientIp },
                { "env_client_mac", EnvClientMac },
                { "env_client_screen", EnvClientScreen },
                { "env_client_uuid", EnvClientUuid },
                { "js_token_id", JsTokenId },
                { "partner_id", PartnerId },
                { "scene_code", SceneCode },
                { "user_account_no", UserAccountNo },
                { "user_bind_bankcard", UserBindBankcard },
                { "user_bind_bankcard_type", UserBindBankcardType },
                { "user_bind_mobile", UserBindMobile },
                { "user_identity_type", UserIdentityType },
                { "user_real_name", UserRealName },
                { "user_reg_date", UserRegDate },
                { "user_reg_email", UserRegEmail },
                { "user_reg_mobile", UserRegMobile },
                { "userr_identity_no", UserrIdentityNo }
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
