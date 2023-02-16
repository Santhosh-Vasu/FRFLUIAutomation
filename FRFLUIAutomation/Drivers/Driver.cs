using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRFLUIAutomation.Drivers
{
    public class Driver:IDisposable
    {
        private readonly Task<IPage> _page;
        private IBrowser? _browser;
        
        public Driver() =>_page = InitalizePlaywright();

        
        public IPage Page => _page.Result;
             

        public async Task<IPage> InitalizePlaywright()
        {
            var playwright = await Playwright.CreateAsync();
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            return await _browser.NewPageAsync();
        }

        public void Dispose() => _browser?.CloseAsync();
        
    }
}
