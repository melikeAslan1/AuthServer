using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        public List<String> Errors { get; private set; }  //sadece aşagidakilerle set edilir.

        public bool IsShow { get; private set; } //true ise kullanıcıya gösterebilirsin.  false ise yazılımcının anlayacağı bir hatadır kullanıcıya göstermeye gerek yok.

        public ErrorDto() {
        
            Errors = new List<String>();
        
        }

        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error);
            isShow = true;
        }

        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }
    }

}
