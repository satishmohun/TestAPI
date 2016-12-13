using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public interface IStudent
    {
        int Get();
        string Get(int id);
    }
}
