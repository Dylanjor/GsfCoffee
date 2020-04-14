using System.Threading.Tasks;
using GsfCoffee.Configuration.Dto;

namespace GsfCoffee.Configuration
{
    public interface IConfigurationAppService
    {
        Task Con_ChangeUiTheme(ChangeUiThemeInput input);
    }
}
