using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UserCardDetail: IEntity
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }

    }
}
