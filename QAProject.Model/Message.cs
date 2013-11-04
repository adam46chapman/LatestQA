using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using QAProject.Data;

namespace QAProject.Models
{
    public class Message : QAContext
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PostDate { get; set; }
    }
    public class MessageListViewModel
    {
        public List<Data.Message> MessageList { get; set; }

        //constructor
        public MessageListViewModel()
        {
            using (QAContext ctx = new QAContext())
            {
                this.MessageList = ctx.Message.ToList();
            }
        }
    }
}   
