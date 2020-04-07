using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GsfCoffee.Coffee
{
    public interface IGsfInitAppService: IApplicationService
    {
       int Main { get; set; }
    }
}
