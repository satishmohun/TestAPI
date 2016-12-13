using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi.Models.Repository
{
    public class StudentRepo : IStudent
    {
        public int Get()
        {
            return 18;
        }

        public string Get(int id)
        {
            string result;
            if (id != 1)
                result = "Failure";
            else
                result = "Success";

            return result;

        }
    }
}