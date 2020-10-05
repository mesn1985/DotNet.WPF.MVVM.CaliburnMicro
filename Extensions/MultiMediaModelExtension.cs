using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Assignment5.Models;

namespace Assignment5.Extensions
{
    public static class MultiMediaModelExtension
    {
        public static Boolean isValid(this MultiMediaModel model)
        {
            if (string.IsNullOrEmpty(model.Title))
                return false;
            if (string.IsNullOrEmpty(model.Artist))
                return false;
            if (string.IsNullOrEmpty(model.Genre))
                return false;

            return true;
        }

    }
}
