using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_HtmlHelper.MODEL.Entity
{
   public class BaseEntity
    {
        public enum Status
        {
            none=0,
            Active=1,
            Updated=2,
            Passive=3
        }
        public int ID { get; set; }

        private DateTime? _AddDate = DateTime.Now;

        public DateTime? AddDate
        {
            get { return _AddDate; }
            set { _AddDate = value; }
        }

        private DateTime? _UpdateDate = DateTime.Now;

        public DateTime? UpdateDate
        {
            get { return _UpdateDate; }
            set { _UpdateDate = value; }
        }
        private DateTime? _DeleteDate = DateTime.Now;

        public DateTime? DeleteDate
        {
            get { return _DeleteDate; }
            set { _DeleteDate = value; }
        }

        private Status? _status = Status.Active;

        public Status? status
        {
            get { return _status; }
            set { _status = value; }
        }


    }
}
