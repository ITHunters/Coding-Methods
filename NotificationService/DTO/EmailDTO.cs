using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.DTO
{
    public class EmailDTO :IMessage
    {
        [Required]
        public string To { get;}

        [Required]
        public string From { get; }

        [Required]
        public string Subject { get; }

        [Required]
        public string Body { get; }

        public EmailDTO(string _to, string _from, string _subject, string _body)
        {
            To = _to;
            From = _from;
            Subject = _subject;
            Body = _body;
        }

    }
}
