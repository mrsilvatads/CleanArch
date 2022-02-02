using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; protected set;}

        //Propriedades que poderia ser inserida nessa classe para ser herdada
        //DateTime CreatedDate { get; set;}
        //DateTime ModifieDate { get; set; }
        //string  CreateBy { get; set; }
        //string ModifieBy { get; set; }
    }
}
