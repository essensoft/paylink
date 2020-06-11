﻿using System.Text.Json;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Domain;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class WeChatPayV3Controller : Controller
    {
        private readonly IWeChatPayV3Client _client;
        private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        public WeChatPayV3Controller(IWeChatPayV3Client client, IOptions<WeChatPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 微信支付指引页
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取平台证书列表
        /// </summary>
        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> GetCertificates()
        {
            if (Request.Method == "POST")
            {
                var request = new WeChatPayCertificatesRequest();
                var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
                ViewData["response"] = response.Body;
                return View();
            }

            return View();
        }

        /// <summary>
        /// APP支付-App下单API
        /// </summary>
        [HttpGet]
        public IActionResult AppPay()
        {
            return View();
        }

        /// <summary>
        /// APP支付-App下单API
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> AppPay(WeChatPayAppPayV3ViewModel viewModel)
        {
            var model = new WeChatPayTransactionsAppModel
            {
                AppId = _optionsAccessor.Value.AppId,
                MchId = _optionsAccessor.Value.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
            };

            var request = new WeChatPayTransactionsAppRequest();
            request.SetBizModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.StatusCode == 200)
            {
                var req = new WeChatPayAppSdkRequest
                {
                    PrepayId = response.PrepayId
                };

                var parameter = await _client.ExecuteAsync(req, _optionsAccessor.Value);

                // 将参数(parameter)给 ios/android端 让他调起微信APP(https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=8_5)
                ViewData["parameter"] = JsonSerializer.Serialize(parameter);
                ViewData["response"] = response.Body;
                return View();
            }

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 公众号支付-JSAPI下单
        /// </summary>
        [HttpGet]
        public IActionResult PubPay()
        {
            return View();
        }

        /// <summary>
        /// 公众号支付-JSAPI下单
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> PubPay(WeChatPayPubPayV3ViewModel viewModel)
        {
            var model = new WeChatPayTransactionsJsApiModel
            {
                AppId = _optionsAccessor.Value.AppId,
                MchId = _optionsAccessor.Value.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
                Payer = new Payer { OpenId = viewModel.OpenId }
            };

            var request = new WeChatPayTransactionsJsApiRequest();
            request.SetBizModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.StatusCode == 200)
            {
                var req = new WeChatPayJsApiSdkRequest
                {
                    Package = "prepay_id=" + response.PrepayId
                };

                var parameter = await _client.ExecuteAsync(req, _optionsAccessor.Value);

                // 将参数(parameter)给 公众号前端 让他在微信内H5调起支付(https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=7_7&index=6)
                ViewData["parameter"] = JsonSerializer.Serialize(parameter);
                ViewData["response"] = response.Body;
                return View();
            }

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 扫码支付-Native下单API
        /// </summary>
        [HttpGet]
        public IActionResult QrCodePay()
        {
            return View();
        }

        /// <summary>
        /// 扫码支付-Native下单API
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> QrCodePay(WeChatPayQrCodePayV3ViewModel viewModel)
        {
            var model = new WeChatPayTransactionsNativeModel
            {
                AppId = _optionsAccessor.Value.AppId,
                MchId = _optionsAccessor.Value.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
            };

            var request = new WeChatPayTransactionsNativeRequest();
            request.SetBizModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            // response.CodeUrl 给前端生成二维码
            ViewData["qrcode"] = response.CodeUrl;
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// H5支付-H5下单API
        /// </summary>
        [HttpGet]
        public IActionResult H5Pay()
        {
            return View();
        }

        /// <summary>
        /// H5支付-H5下单API
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> H5Pay(WeChatPayH5PayV3ViewModel viewModel)
        {
            var model = new WeChatPayTransactionsH5Model
            {
                AppId = _optionsAccessor.Value.AppId,
                MchId = _optionsAccessor.Value.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
                SceneInfo = new SceneInfo { PayerClientIp = "127.0.0.1" }
            };

            var request = new WeChatPayTransactionsH5Request();
            request.SetBizModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            // h5_url为拉起微信支付收银台的中间页面，可通过访问该url来拉起微信客户端，完成支付,h5_url的有效期为5分钟。
            ViewData["response"] = response.Body;
            return View();
        }
    }
}