using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.discovery.taxi.order.confirm
    /// </summary>
    public class AlipayDiscoveryTaxiOrderConfirmRequest : IAlipayRequest<AlipayDiscoveryTaxiOrderConfirmResponse>
    {
        /// <summary>
        /// 司机纬度
        /// </summary>
        public string DriverLat { get; set; }

        /// <summary>
        /// 司机车牌
        /// </summary>
        public string DriverLicense { get; set; }

        /// <summary>
        /// 司机经度
        /// </summary>
        public string DriverLng { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        public string DriverName { get; set; }

        /// <summary>
        /// 司机手机号
        /// </summary>
        public string DriverPhone { get; set; }

        /// <summary>
        /// 是否支持支付宝付款
        /// </summary>
        public Nullable<bool> IsAlipaySupport { get; set; }

        /// <summary>
        /// 打车订单ID
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        public string PartnerId { get; set; }

        /// <summary>
        /// 收款账号
        /// </summary>
        public string Seller { get; set; }

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
            return "alipay.discovery.taxi.order.confirm";
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
                { "driver_lat", DriverLat },
                { "driver_license", DriverLicense },
                { "driver_lng", DriverLng },
                { "driver_name", DriverName },
                { "driver_phone", DriverPhone },
                { "is_alipay_support", IsAlipaySupport },
                { "out_biz_no", OutBizNo },
                { "partner_id", PartnerId },
                { "seller", Seller }
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
