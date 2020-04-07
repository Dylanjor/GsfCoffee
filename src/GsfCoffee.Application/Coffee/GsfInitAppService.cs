using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GsfCoffee.Coffee
{
    public class GsfInitAppService: ApplicationService,IGsfInitAppService
    {
        public int main { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// 主方法
        /// </summary>
        public async Task<int> Main() {
            return (1 + 2);
        }
    }
}
