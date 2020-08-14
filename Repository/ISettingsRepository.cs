
namespace NullJsonTest.Repositories
{
    using System.Collections.Generic;
    using NullJsonTest.Models;

    public interface ISettingsRepository
    {
        int CreateSetting(Settings setting);
     
        IEnumerable<Settings> GetSettings();
    }
}