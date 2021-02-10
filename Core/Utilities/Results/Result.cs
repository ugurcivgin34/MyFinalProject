using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message):this(success) //
            //constructor kullanarak set etmiş olduk ama normalde get diyerek setlemeyi istemedik.Sadece constructor ile set yapmak istediğimiz için böyle yaptık
        {
            Message = message;
            
        }

        public Result(bool success) 
        { 
            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}