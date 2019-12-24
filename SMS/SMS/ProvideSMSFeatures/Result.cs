using System;
using System.Collections.Generic;
using System.Linq;

namespace SMS
{

    public class Result
    {
        public ResultStatus Status { get; private set; }
        public Exception Exception { get; private set; }

        public Result(ResultStatus status)
        {
            Status = status;
        }
        public Result(ResultStatus status, Exception ex)
        {
            Status = status;
            Exception = ex;
        }
    }
}