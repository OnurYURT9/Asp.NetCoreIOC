using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.WEB.Models
{
    public interface IDateService
    {
        DateTime GetDateTime { get; }
    }

    public interface ISingletonDateService : IDateService
    { }

    public interface IScopedDateService : IDateService
    { }

    public interface ITransientDateService : IDateService
    { }

}
