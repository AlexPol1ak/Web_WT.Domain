using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliak_UI_WT.Domain.Models
{
    public class ResponseData<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }  = true;
        public string? Error { get; set; } = null;

        public ResponseData() { }
        public ResponseData(T data, bool success, string? error = null): this()
        {
            Data = data;
            Success = success;
            Error = error;
        }

        public override string ToString()
        {
            string str = $"ResponseData: Success {Success}";
            if (!Success) str += Error != null ? $". Error: {Error}." : ". Error: Unknown.";
            return str;
        }
    }
}
